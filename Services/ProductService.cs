using Back_Vueapp.DTOs.Product;
using Back_Vueapp.Models;
using Back_Vueapp.Repositories;

namespace Back_Vueapp.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IRepository<Category> _categoryRepository;

        public ProductService(IProductRepository productRepository, IRepository<Category> categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }

        public async Task<IEnumerable<ProductDto>> GetAllProductsAsync()
        {
            var products = await _productRepository.GetProductsWithCategoryAsync();
            return products.Select(p => MapToDto(p));
        }

        public async Task<PagedProductResponse> GetPagedProductsAsync(
            string? search, 
            int page, 
            int pageSize, 
            string? sortBy, 
            bool isAscending, 
            int? categoryId = null,
            DateTime? startDate = null,
            DateTime? endDate = null)
        {
            var (items, totalCount) = await _productRepository.GetPagedAsync(search, page, pageSize, sortBy, isAscending, categoryId, startDate, endDate);
            
            return new PagedProductResponse
            {
                Items = items.Select(p => MapToDto(p)).ToList(),
                TotalItems = totalCount
            };
        }

        public async Task<ProductDto?> GetProductByIdAsync(int id)
        {
            var p = await _productRepository.GetProductWithCategoryByIdAsync(id);
            if (p == null) return null;

            return MapToDto(p);
        }

        public async Task<ProductDto> CreateProductAsync(ProductCreateDto dto)
        {
            var product = new Product
            {
                Name = dto.Name,
                Brand = dto.Brand,
                Size = dto.Size,
                Color = dto.Color,
                Description = dto.Description,
                Price = dto.Price,
                CategoryId = dto.CategoryId
            };

            await _productRepository.AddAsync(product);
            await _productRepository.SaveChangesAsync();

            // Load category name for response
            var category = await _categoryRepository.GetByIdAsync(product.CategoryId);
            product.Category = category;

            return MapToDto(product);
        }

        public async Task<bool> UpdateProductAsync(int id, ProductUpdateDto dto)
        {
            var product = await _productRepository.GetByIdAsync(id);
            if (product == null) return false;

            product.Name = dto.Name;
            product.Brand = dto.Brand;
            product.Size = dto.Size;
            product.Color = dto.Color;
            product.Description = dto.Description;
            product.Price = dto.Price;
            product.CategoryId = dto.CategoryId;

            _productRepository.Update(product);
            return await _productRepository.SaveChangesAsync();
        }

        public async Task<bool> DeleteProductAsync(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            if (product == null) return false;

            _productRepository.Remove(product);
            return await _productRepository.SaveChangesAsync();
        }

        private static ProductDto MapToDto(Product p)
        {
            return new ProductDto
            {
                Id = p.Id,
                Name = p.Name,
                Brand = p.Brand,
                Size = p.Size,
                Color = p.Color,
                Description = p.Description,
                Price = p.Price,
                CategoryId = p.CategoryId,
                CategoryName = p.Category?.Name ?? "Unknown",
                CreatedAt = p.CreatedAt
            };
        }
    }
}
