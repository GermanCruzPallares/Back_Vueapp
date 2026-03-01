namespace Back_Vueapp.DTOs.Category
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
    }

    public class CategoryCreateDto
    {
        public required string Name { get; set; }
        public string? Description { get; set; }
    }

    public class CategoryUpdateDto
    {
        public required string Name { get; set; }
        public string? Description { get; set; }
    }
}
