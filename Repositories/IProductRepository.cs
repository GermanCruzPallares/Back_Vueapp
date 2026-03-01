using Back_Vueapp.Models;

namespace Back_Vueapp.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<IEnumerable<Product>> GetProductsWithCategoryAsync();
        Task<Product?> GetProductWithCategoryByIdAsync(int id);
    }
}
