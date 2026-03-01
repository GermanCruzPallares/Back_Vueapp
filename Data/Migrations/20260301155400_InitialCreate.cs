using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Back_Vueapp.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Casual and athletic shoes for daily use.", "Sneakers" },
                    { 2, "Sturdy footwear covering the foot and ankle.", "Boots" },
                    { 3, "Light footwear for warm weather.", "Sandals" },
                    { 4, "Elegant shoes for special occasions or business.", "Formal" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "CategoryId", "Color", "Description", "Name", "Price", "Size" },
                values: new object[,]
                {
                    { 1, "Nike", 1, "White/Red", "Classic retro sneakers.", "Air Max 90", 129.99m, "42" },
                    { 2, "Adidas", 1, "Core Black", "High-performance running shoes.", "Ultraboost 22", 180.00m, "43" },
                    { 3, "Converse", 1, "Black", "The iconic canvas sneakers.", "Chuck Taylor All Star", 65.00m, "39" },
                    { 4, "Timberland", 2, "Wheat", "Classic waterproof work boots.", "6-Inch Premium", 199.95m, "44" },
                    { 5, "Dr. Martens", 2, "Cherry Red", "Original 8-eye boot.", "1460 Smooth", 160.00m, "41" },
                    { 6, "Birkenstock", 3, "Mocha", "Comfortable two-strap sandals.", "Arizona Soft Footbed", 135.00m, "40" },
                    { 7, "Crocs", 3, "Navy", "Water-friendly and lightweight.", "Classic Clog", 49.99m, "42" },
                    { 8, "Allen Edmonds", 4, "Walnut", "Premium leather oxford shoes.", "Fifth Avenue Cap-Toe", 395.00m, "43" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
