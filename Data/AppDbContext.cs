using Microsoft.EntityFrameworkCore;
using Back_Vueapp.Models;
using BCrypt.Net;

namespace Back_Vueapp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure one-to-many relationship
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Products)
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CategoryId);

            // Decimal configuration for EF Core
            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasColumnType("decimal(18,2)");

            // Seed Data for Users (Password: admin123, user123)
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Username = "admin", PasswordHash = BCrypt.Net.BCrypt.HashPassword("admin123"), Role = "Admin" },
                new User { Id = 2, Username = "testuser", PasswordHash = BCrypt.Net.BCrypt.HashPassword("user123"), Role = "User" }
            );

            // Seed Data for Categories
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Sneakers", Description = "Casual and athletic shoes for daily use." },
                new Category { Id = 2, Name = "Boots", Description = "Sturdy footwear covering the foot and ankle." },
                new Category { Id = 3, Name = "Sandals", Description = "Light footwear for warm weather." },
                new Category { Id = 4, Name = "Formal", Description = "Elegant shoes for special occasions or business." }
            );

            // Seed Data for Products (Shoes)
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Air Max 90", CategoryId = 1, Brand = "Nike", Size = "42", Color = "White/Red", Description = "Classic retro sneakers.", Price = 129.99m },
                new Product { Id = 2, Name = "Ultraboost 22", CategoryId = 1, Brand = "Adidas", Size = "43", Color = "Core Black", Description = "High-performance running shoes.", Price = 180.00m },
                new Product { Id = 3, Name = "Chuck Taylor All Star", CategoryId = 1, Brand = "Converse", Size = "39", Color = "Black", Description = "The iconic canvas sneakers.", Price = 65.00m },
                
                new Product { Id = 4, Name = "6-Inch Premium", CategoryId = 2, Brand = "Timberland", Size = "44", Color = "Wheat", Description = "Classic waterproof work boots.", Price = 199.95m },
                new Product { Id = 5, Name = "1460 Smooth", CategoryId = 2, Brand = "Dr. Martens", Size = "41", Color = "Cherry Red", Description = "Original 8-eye boot.", Price = 160.00m },
                
                new Product { Id = 6, Name = "Arizona Soft Footbed", CategoryId = 3, Brand = "Birkenstock", Size = "40", Color = "Mocha", Description = "Comfortable two-strap sandals.", Price = 135.00m },
                new Product { Id = 7, Name = "Classic Clog", CategoryId = 3, Brand = "Crocs", Size = "42", Color = "Navy", Description = "Water-friendly and lightweight.", Price = 49.99m },
                
                new Product { Id = 8, Name = "Fifth Avenue Cap-Toe", CategoryId = 4, Brand = "Allen Edmonds", Size = "43", Color = "Walnut", Description = "Premium leather oxford shoes.", Price = 395.00m }
            );
        }
    }
}
