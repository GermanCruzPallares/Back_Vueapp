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
    }
}
