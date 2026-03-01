namespace Back_Vueapp.DTOs.Product
{
    public class ProductDto
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Brand { get; set; }
        public string? Size { get; set; }
        public string? Color { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public required string CategoryName { get; set; }
        public int CategoryId { get; set; }
    }

    public class ProductCreateDto
    {
        public required string Name { get; set; }
        public string? Brand { get; set; }
        public string? Size { get; set; }
        public string? Color { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
    }

    public class ProductUpdateDto
    {
        public required string Name { get; set; }
        public string? Brand { get; set; }
        public string? Size { get; set; }
        public string? Color { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
    }
}
