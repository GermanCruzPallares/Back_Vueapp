using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Back_Vueapp.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedDataToSpanishAndAddProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Calzado casual y deportivo para uso diario.", "Zapatillas" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Calzado resistente que cubre el pie y el tobillo.", "Botas" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Calzado ligero para climas cálidos.", "Sandalias" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "Zapatos elegantes para ocasiones especiales o negocios.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Color", "Description" },
                values: new object[] { "Blanco/Rojo", "Zapatillas retro clásicas." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Color", "Description" },
                values: new object[] { "Negro", "Zapatillas de running de alto rendimiento." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Color", "Description" },
                values: new object[] { "Negro", "Las icónicas zapatillas de lona." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Color", "Description" },
                values: new object[] { "Amarillo", "Clásicas botas de trabajo impermeables." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Color", "Description" },
                values: new object[] { "Granate", "Bota original de 8 ojales." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Color", "Description" },
                values: new object[] { "Marrón", "Sandalias cómodas de dos correas." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Color", "Description" },
                values: new object[] { "Azul Marino", "Ligeras y resistentes al agua." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Color", "Description" },
                values: new object[] { "Nogal", "Zapatos oxford de piel premium." });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "CategoryId", "Color", "Description", "Name", "Price", "Size" },
                values: new object[,]
                {
                    { 9, "Nike", 1, "Azul", "Zapatillas de running versátiles.", "Pegasus 40", 130.00m, "42" },
                    { 10, "Adidas", 1, "Blanco/Negro", "Zapatillas de estilo clásico.", "Samba OG", 110.00m, "41" },
                    { 11, "Vans", 1, "Negro/Blanco", "Zapatillas de skate clásicas.", "Old Skool", 75.00m, "40" },
                    { 12, "Panama Jack", 2, "Marrón", "Botas de piel resistentes.", "Classic Panama", 179.00m, "42" },
                    { 13, "Caterpillar", 2, "Miel", "Botas robustas de alta durabilidad.", "Colorado", 145.00m, "43" },
                    { 14, "Havaianas", 3, "Verde/Amarillo", "Las chanclas brasileñas más icónicas.", "Brasil Logo", 25.00m, "41" },
                    { 15, "Birkenstock", 3, "Negro", "Sandalias de dedo elegantes y cómodas.", "Gizeh", 100.00m, "39" },
                    { 16, "Lottusse", 4, "Negro", "Zapatos de vestir elegantes.", "Oxford Moderno", 220.00m, "43" },
                    { 17, "Sebago", 4, "Burdeos", "Mocasines de piel hechos a mano.", "Mocasín Clásico", 185.00m, "42" },
                    { 18, "New Balance", 1, "Gris", "Zapatillas icónicas de estilo retro.", "574 Core", 110.00m, "43" },
                    { 19, "Asics", 1, "Naranja", "Zapatillas de running con gran amortiguación.", "Novablast 3", 150.00m, "44" },
                    { 20, "Dr. Martens", 2, "Negro", "Botas con plataforma de estilo rebelde.", "Jadon Platform", 220.00m, "39" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$ANwqtp51D/xBuSJ3Dqp4aO2WzV.1/.MFPpCPn8geRA6DrUaurkdAC");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "$2a$11$7VX46zQRtAtD3p8wdIPWSuHnm3hO6E6ePFIJuXHNJFY223DOfZdlu");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Casual and athletic shoes for daily use.", "Sneakers" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Sturdy footwear covering the foot and ankle.", "Boots" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Light footwear for warm weather.", "Sandals" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "Elegant shoes for special occasions or business.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Color", "Description" },
                values: new object[] { "White/Red", "Classic retro sneakers." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Color", "Description" },
                values: new object[] { "Core Black", "High-performance running shoes." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Color", "Description" },
                values: new object[] { "Black", "The iconic canvas sneakers." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Color", "Description" },
                values: new object[] { "Wheat", "Classic waterproof work boots." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Color", "Description" },
                values: new object[] { "Cherry Red", "Original 8-eye boot." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Color", "Description" },
                values: new object[] { "Mocha", "Comfortable two-strap sandals." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Color", "Description" },
                values: new object[] { "Navy", "Water-friendly and lightweight." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Color", "Description" },
                values: new object[] { "Walnut", "Premium leather oxford shoes." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2b$10$CcnHQWe8XILnWo.stpzHzOYQaAtvpU1DtYXRsWQ4YzHafCpdkTbVm");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "$2b$10$ugHH26PNgkeciVkcrwETC.MZbtl3uqLjzMtjdv4Mar/MVNM/4hRq.");
        }
    }
}
