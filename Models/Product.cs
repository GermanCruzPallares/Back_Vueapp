namespace Back_Vueapp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Brand { get; set; }
        public string? Size { get; set; }
        public string? Color { get; set; }
        public string? Description { get; set; }
        public required decimal Price { get; set; }
        public required int CategoryId { get; set; }
        public Category? Category { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
