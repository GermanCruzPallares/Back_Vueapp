using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Back_Vueapp.DTOs.Product;
using Back_Vueapp.Services;

namespace Back_Vueapp.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        // Paged and filtered search
        [HttpGet]
        public async Task<ActionResult<PagedProductResponse>> GetProducts(
            [FromQuery] string? search = null,
            [FromQuery] int page = 1,
            [FromQuery] int pageSize = 12,
            [FromQuery] string? sortBy = "id",
            [FromQuery] bool isAscending = false,
            [FromQuery] int? categoryId = null,
            [FromQuery] DateTime? startDate = null,
            [FromQuery] DateTime? endDate = null)
        {
            var result = await _productService.GetPagedProductsAsync(
                search, page, pageSize, sortBy, isAscending, categoryId, startDate, endDate);
            return Ok(result);
        }

        // Return all products for dashboard/charts
        [HttpGet("all")]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetAllProducts()
        {
            var products = await _productService.GetAllProductsAsync();
            return Ok(products);
        }



        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDto>> GetProduct(int id)
        {
            var product = await _productService.GetProductByIdAsync(id);
            if (product == null) return NotFound();

            return Ok(product);
        }

        [HttpPost]
        public async Task<ActionResult<ProductDto>> CreateProduct(ProductCreateDto dto)
        {
            var createdProduct = await _productService.CreateProductAsync(dto);
            return CreatedAtAction(nameof(GetProduct), new { id = createdProduct.Id }, createdProduct);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, ProductUpdateDto dto)
        {
            var success = await _productService.UpdateProductAsync(id, dto);
            if (!success) return NotFound();

            return NoContent();
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var success = await _productService.DeleteProductAsync(id);
            if (!success) return NotFound();

            return NoContent();
        }
    }
}
