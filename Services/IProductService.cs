using Back_Vueapp.DTOs.Product;

namespace Back_Vueapp.Services
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetAllProductsAsync();
        Task<ProductDto?> GetProductByIdAsync(int id);
        Task<ProductDto> CreateProductAsync(ProductCreateDto dto);
        Task<bool> UpdateProductAsync(int id, ProductUpdateDto dto);
        Task<bool> DeleteProductAsync(int id);
    }
}
