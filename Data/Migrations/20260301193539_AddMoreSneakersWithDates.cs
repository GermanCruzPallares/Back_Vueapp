using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Back_Vueapp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreSneakersWithDates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 19, 19, 35, 37, 914, DateTimeKind.Utc).AddTicks(5446));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 19, 35, 37, 914, DateTimeKind.Utc).AddTicks(5456));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 19, 35, 37, 914, DateTimeKind.Utc).AddTicks(5459));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 1, 19, 35, 37, 914, DateTimeKind.Utc).AddTicks(5466));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 1, 19, 35, 37, 914, DateTimeKind.Utc).AddTicks(5469));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 19, 35, 37, 914, DateTimeKind.Utc).AddTicks(5471));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 28, 19, 35, 37, 914, DateTimeKind.Utc).AddTicks(5473));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 1, 19, 35, 37, 914, DateTimeKind.Utc).AddTicks(5474));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 14, 19, 35, 37, 914, DateTimeKind.Utc).AddTicks(5476));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 9, 19, 35, 37, 914, DateTimeKind.Utc).AddTicks(5478));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 4, 19, 35, 37, 914, DateTimeKind.Utc).AddTicks(5480));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 1, 19, 35, 37, 914, DateTimeKind.Utc).AddTicks(5481));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 1, 19, 35, 37, 914, DateTimeKind.Utc).AddTicks(5483));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 26, 19, 35, 37, 914, DateTimeKind.Utc).AddTicks(5485));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 19, 35, 37, 914, DateTimeKind.Utc).AddTicks(5502));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 1, 19, 35, 37, 914, DateTimeKind.Utc).AddTicks(5504));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 1, 19, 35, 37, 914, DateTimeKind.Utc).AddTicks(5506));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 19, 35, 37, 914, DateTimeKind.Utc).AddTicks(5507));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 17, 19, 35, 37, 914, DateTimeKind.Utc).AddTicks(5510));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 1, 19, 35, 37, 914, DateTimeKind.Utc).AddTicks(5511));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "CategoryId", "Color", "CreatedAt", "Description", "Name", "Price", "Size" },
                values: new object[,]
                {
                    { 21, "Adidas", 1, "Gris", new DateTime(2026, 1, 20, 19, 35, 37, 914, DateTimeKind.Utc).AddTicks(5513), "Zapatillas exclusivas de diseño.", "Yeezy Boost 350", 220.00m, "42" },
                    { 22, "Nike", 1, "Rojo/Negro", new DateTime(2026, 1, 10, 19, 35, 37, 914, DateTimeKind.Utc).AddTicks(5515), "Zapatillas legendarias de baloncesto.", "Air Jordan 1", 170.00m, "43" },
                    { 23, "Nike", 1, "Blanco", new DateTime(2025, 12, 31, 19, 35, 37, 914, DateTimeKind.Utc).AddTicks(5517), "Zapatillas casuales de estilo retro.", "Court Vision", 75.00m, "41" },
                    { 24, "Adidas", 1, "Blanco/Azul", new DateTime(2025, 12, 21, 19, 35, 37, 914, DateTimeKind.Utc).AddTicks(5518), "Zapatillas clásicas de los 80.", "Forum Low", 100.00m, "42" },
                    { 25, "Vans", 1, "Azul", new DateTime(2025, 12, 11, 19, 35, 37, 914, DateTimeKind.Utc).AddTicks(5520), "Zapatillas de skate de caña alta.", "Sk8-Hi", 85.00m, "43" },
                    { 26, "Adidas", 1, "Blanco", new DateTime(2025, 12, 1, 19, 35, 37, 914, DateTimeKind.Utc).AddTicks(5522), "Zapatillas retro versátiles.", "Continental 80", 90.00m, "40" },
                    { 27, "Nike", 1, "Blanco/Negro", new DateTime(2025, 11, 21, 19, 35, 37, 914, DateTimeKind.Utc).AddTicks(5524), "Zapatillas vintage de baloncesto.", "Blazer Mid '77", 105.00m, "42" },
                    { 28, "New Balance", 1, "Verde", new DateTime(2025, 11, 11, 19, 35, 37, 914, DateTimeKind.Utc).AddTicks(5527), "Zapatillas de running ultra cómodas.", "Fresh Foam", 140.00m, "44" },
                    { 29, "Converse", 1, "Gris", new DateTime(2025, 11, 1, 19, 35, 37, 914, DateTimeKind.Utc).AddTicks(5528), "Zapatillas casuales resistentes.", "Star Player", 70.00m, "41" },
                    { 30, "Asics", 1, "Multi", new DateTime(2025, 10, 22, 19, 35, 37, 914, DateTimeKind.Utc).AddTicks(5536), "Zapatillas icónicas con lengüeta dividida.", "Gel-Lyte III", 120.00m, "42" },
                    { 31, "Nike", 1, "Verde/Blanco", new DateTime(2025, 10, 12, 19, 35, 37, 914, DateTimeKind.Utc).AddTicks(5538), "Zapatillas de culto muy populares.", "Dunk Low", 110.00m, "43" },
                    { 32, "Adidas", 1, "Blanco/Verde", new DateTime(2025, 10, 2, 19, 35, 37, 914, DateTimeKind.Utc).AddTicks(5540), "Zapatillas minimalistas clásicas.", "Stan Smith", 95.00m, "42" },
                    { 33, "Puma", 1, "Rojo/Azul", new DateTime(2025, 9, 22, 19, 35, 37, 914, DateTimeKind.Utc).AddTicks(5541), "Zapatillas modernas con estética chunky.", "RS-X Efekt", 120.00m, "41" },
                    { 34, "Nike", 1, "Negro", new DateTime(2025, 9, 12, 19, 35, 37, 914, DateTimeKind.Utc).AddTicks(5543), "Zapatillas de running equilibradas.", "Quest 5", 80.00m, "43" },
                    { 35, "Adidas", 1, "Blanco/Negro", new DateTime(2025, 9, 2, 19, 35, 37, 914, DateTimeKind.Utc).AddTicks(5545), "Zapatillas legendarias con puntera de goma.", "Superstar", 105.00m, "40" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$UyKNp7ynan6aai/fDzH0oesNG1foeMxZQD70cawuwxHtycDewqeEC");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "$2a$11$i6Bcz1sCvVRRykthrQ1m/.LEWQ54Bynb0ClEWh.8oylD/DSEWmxsG");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Products");

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
    }
}
