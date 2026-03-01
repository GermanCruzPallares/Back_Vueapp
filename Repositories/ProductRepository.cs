using Microsoft.EntityFrameworkCore;
using Back_Vueapp.Data;
using Back_Vueapp.Models;

namespace Back_Vueapp.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Product>> GetProductsWithCategoryAsync()
        {
            return await _dbSet.Include(p => p.Category).ToListAsync();
        }

        public async Task<Product?> GetProductWithCategoryByIdAsync(int id)
        {
            return await _dbSet.Include(p => p.Category).FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<(IEnumerable<Product> Items, int TotalCount)> GetPagedAsync(
            string? search, 
            int page, 
            int pageSize, 
            string? sortBy, 
            bool isAscending,
            int? categoryId,
            DateTime? startDate,
            DateTime? endDate)
        {
            var query = _dbSet.Include(p => p.Category).AsQueryable();

            // Filters
            if (!string.IsNullOrEmpty(search))
            {
                var lowerSearch = search.ToLower();
                query = query.Where(p => p.Name.ToLower().Contains(lowerSearch) || 
                                       (p.Description != null && p.Description.ToLower().Contains(lowerSearch)));
            }

            if (categoryId.HasValue)
            {
                query = query.Where(p => p.CategoryId == categoryId.Value);
            }

            if (startDate.HasValue)
            {
                query = query.Where(p => p.CreatedAt >= startDate.Value);
            }

            if (endDate.HasValue)
            {
                query = query.Where(p => p.CreatedAt <= endDate.Value);
            }

            // Sorting
            if (!string.IsNullOrEmpty(sortBy))
            {
                switch (sortBy.ToLower())
                {
                    case "name":
                        query = isAscending ? query.OrderBy(p => p.Name) : query.OrderByDescending(p => p.Name);
                        break;
                    case "price":
                        query = isAscending ? query.OrderBy(p => p.Price) : query.OrderByDescending(p => p.Price);
                        break;
                    case "date":
                        query = isAscending ? query.OrderBy(p => p.CreatedAt) : query.OrderByDescending(p => p.CreatedAt);
                        break;
                    default:
                        query = query.OrderByDescending(p => p.Id);
                        break;
                }
            }
            else
            {
                query = query.OrderByDescending(p => p.Id);
            }

            int totalCount = await query.CountAsync();
            var items = await query.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();

            return (items, totalCount);
        }
    }
}
