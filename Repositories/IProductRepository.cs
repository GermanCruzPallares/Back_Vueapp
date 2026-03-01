using Back_Vueapp.Models;

namespace Back_Vueapp.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<IEnumerable<Product>> GetProductsWithCategoryAsync();
        Task<Product?> GetProductWithCategoryByIdAsync(int id);
        Task<(IEnumerable<Product> Items, int TotalCount)> GetPagedAsync(
            string? search, 
            int page, 
            int pageSize, 
            string? sortBy, 
            bool isAscending,
            int? categoryId,
            DateTime? startDate,
            DateTime? endDate);
    }
}
