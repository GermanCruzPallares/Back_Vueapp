using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Back_Vueapp.Data.Migrations
{
    /// <inheritdoc />
    public partial class MassiveSeed200_Fresh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 5, "Calzado técnico diseñado para correr largas distancias.", "Running" },
                    { 6, "Calzado de montaña y senderismo de alta resistencia.", "Trekking" },
                    { 7, "Calzado cómodo y duradero para niños y niñas.", "Infantil" },
                    { 8, "Calzado sin cordones cómodo y versátil para el día a día.", "Mocasines" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description" },
                values: new object[] { new DateTime(2026, 2, 19, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(6953), "Zapatillas retro clásicas con unidad Air visible." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(6969));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2026, 2, 1, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(6972), "Chuck Taylor" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 1, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7184));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 1, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7187));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2026, 2, 27, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7239), "Arizona Soft" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 28, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7242));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2025, 11, 1, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7276), "Fifth Ave Cap-Toe" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 14, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 9, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7051));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 4, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7054));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 1, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 1, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7192));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 26, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7244));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7247));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 1, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7278));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 1, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7282));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7057));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CategoryId", "CreatedAt" },
                values: new object[] { 5, new DateTime(2026, 2, 17, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7309) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 1, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7195));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7059));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 10, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7061));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 31, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7084));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 21, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7087));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 11, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7089));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 1, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7092));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 21, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7095));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2025, 11, 11, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7103), "Fresh Foam X" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 1, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7106));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 22, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7108));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 12, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 2, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7113));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 22, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7115));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 12, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7117));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 2, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7119));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "CategoryId", "Color", "CreatedAt", "Description", "Name", "Price", "Size" },
                values: new object[,]
                {
                    { 36, "Nike", 1, "Blanco", new DateTime(2026, 2, 21, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7125), "El clásico blanco atemporal de Nike.", "Air Force 1 '07", 110.00m, "44" },
                    { 37, "Adidas", 1, "Beige", new DateTime(2026, 2, 16, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7128), "Reedición moderna de la zapatilla Campus.", "Campus 00s", 100.00m, "42" },
                    { 38, "Vans", 1, "Rojo", new DateTime(2026, 2, 7, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7130), "La zapatilla más sencilla y auténtica de Vans.", "Authentic", 60.00m, "39" },
                    { 39, "Puma", 1, "Azul Marino", new DateTime(2026, 1, 27, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7133), "Icónica zapatilla de ante con herencia deportiva.", "Suede Classic", 80.00m, "41" },
                    { 40, "Asics", 1, "Azul/Plata", new DateTime(2026, 1, 15, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7135), "Zapatillas de estabilidad para corredores de larga distancia.", "Gel-Kayano 30", 165.00m, "43" },
                    { 41, "Nike", 1, "Negro/Amarillo", new DateTime(2026, 1, 5, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7137), "Zapatilla icónica conocida como 'Tuned Air'.", "Air Max Plus", 160.00m, "42" },
                    { 42, "Adidas", 1, "Blanco", new DateTime(2025, 12, 26, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7140), "Zapatilla moderna con tecnología Boost.", "NMD_R1", 140.00m, "44" },
                    { 43, "Reebok", 1, "Blanco", new DateTime(2025, 12, 16, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7157), "La zapatilla de cuero más clásica de Reebok.", "Classic Leather", 90.00m, "40" },
                    { 44, "Lacoste", 1, "Blanco/Verde", new DateTime(2025, 12, 6, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7160), "Zapatillas deportivas con el icónico cocodrilo.", "Tauco Mid", 130.00m, "41" },
                    { 45, "On Running", 1, "Blanco/Negro", new DateTime(2025, 11, 26, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7170), "Máxima amortiguación con tecnología CloudTec.", "Cloudmonster", 179.00m, "42" },
                    { 46, "Puma", 1, "Rojo/Blanco", new DateTime(2025, 11, 16, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7172), "Zapatillas de piloto con suela ultrafina.", "Speedcat OG", 100.00m, "43" },
                    { 47, "Nike", 1, "Plata", new DateTime(2025, 11, 6, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7175), "Diseño inspirado en el tren bala japonés.", "Air Max 97", 175.00m, "41" },
                    { 48, "Adidas", 1, "Blanco/Verde", new DateTime(2025, 10, 27, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7177), "Zapatilla de atletismo de los Juegos Olímpicos del 72.", "Sl 72 OG", 100.00m, "42" },
                    { 49, "Reebok", 1, "Blanco/Verde", new DateTime(2025, 10, 17, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7179), "Zapatilla de tenis con estilo minimalista.", "Club C 85", 85.00m, "44" },
                    { 50, "Converse", 1, "Negro", new DateTime(2025, 10, 7, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7182), "Versión premium de los clásicos Chuck Taylor.", "Chucks 70", 85.00m, "40" },
                    { 51, "Timberland", 2, "Marrón", new DateTime(2026, 2, 22, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7197), "Botas de senderismo clásicas con suela de vibram.", "Euro Hiker", 170.00m, "43" },
                    { 52, "Dr. Martens", 2, "Negro", new DateTime(2026, 2, 11, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7203), "Botines chelsea sin cordones con elástico lateral.", "2976 Chelsea", 175.00m, "40" },
                    { 53, "Salomon", 2, "Negro/Rojo", new DateTime(2026, 2, 1, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7206), "Botas de montaña impermeables Gore-Tex.", "Icon GTX", 215.00m, "42" },
                    { 54, "5.11 Tactical", 2, "Coyote", new DateTime(2026, 1, 22, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7208), "Botas tácticas ligeras para uso profesional.", "Bota Militar 511", 185.00m, "43" },
                    { 55, "Adidas", 2, "Marrón/Beige", new DateTime(2026, 1, 12, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7210), "Botas casual con suela de goma robusta.", "Ransom", 130.00m, "41" },
                    { 56, "Columbia", 2, "Topo/Gris", new DateTime(2026, 1, 2, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7213), "Botas de senderismo ligeras para mujer.", "Wmns Hadley Mid", 140.00m, "40" },
                    { 57, "Camper", 2, "Marrón Oscuro", new DateTime(2025, 12, 23, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7215), "Bota de piel artesanal con diseño atemporal.", "Bota Clásica", 210.00m, "44" },
                    { 58, "Geox", 2, "Negro", new DateTime(2025, 12, 13, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7218), "Botas con membrana transpirable antideslizante.", "Cortina Plus", 150.00m, "43" },
                    { 59, "Vans", 2, "Negro", new DateTime(2025, 12, 3, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7220), "Botín con plataforma de tipo creeper.", "Creeper Boot", 110.00m, "42" },
                    { 60, "Keen", 2, "Gris/Naranja", new DateTime(2025, 11, 23, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7222), "Botas de senderismo ligeras y resistentes al agua.", "Terradora II", 160.00m, "41" },
                    { 61, "Sorel", 2, "Camel", new DateTime(2025, 11, 13, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7225), "Botas de invierno con forro polar extraíble.", "Bota Polar", 195.00m, "43" },
                    { 62, "Palladium", 2, "Caqui", new DateTime(2025, 11, 3, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7227), "Botines de lona inspirados en botas militares.", "Clarington", 100.00m, "40" },
                    { 63, "UGG", 2, "Castaño", new DateTime(2025, 10, 24, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7230), "Bota clásica con forro de piel de oveja.", "Emporium Boot", 230.00m, "39" },
                    { 64, "Sendra", 2, "Marrón", new DateTime(2025, 10, 14, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7235), "Bota campera artesanal de piel vacuna.", "Bota Motero", 280.00m, "44" },
                    { 65, "Red Wing", 2, "Avellana", new DateTime(2025, 10, 4, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7237), "Bota de trabajo de piel de alta calidad.", "Lace Boot", 320.00m, "43" },
                    { 66, "Birkenstock", 3, "Beige", new DateTime(2026, 2, 23, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7249), "Sandalia de tiras cruzadas con plantilla anatómica.", "Yara", 120.00m, "41" },
                    { 67, "Havaianas", 3, "Azul", new DateTime(2026, 2, 20, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7251), "Sandalia de tiras resistente al agua.", "Itacaré", 35.00m, "42" },
                    { 68, "Crocs", 3, "Rosa", new DateTime(2026, 2, 18, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7254), "Sandalias planas con detalle de flores.", "Capri", 45.00m, "40" },
                    { 69, "Camper", 3, "Marrón", new DateTime(2026, 2, 13, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7257), "Sandalia de piel con diseño artesanal.", "Uji", 110.00m, "39" },
                    { 70, "Birkenstock", 3, "Dorado", new DateTime(2026, 2, 10, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7259), "Sandalia con plataforma y cierre de hebilla.", "Papillio Larisa", 130.00m, "38" },
                    { 71, "Nike", 3, "Negro", new DateTime(2026, 2, 6, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7262), "Chancla deportiva con plantilla acolchada.", "Sport Slide", 30.00m, "43" },
                    { 72, "Adidas", 3, "Azul Marino", new DateTime(2026, 2, 2, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7264), "Sandalias de baño clásicas y ligeras.", "Adilette Aqua", 25.00m, "42" },
                    { 73, "Teva", 3, "Multi", new DateTime(2026, 1, 28, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7267), "Sandalia de senderismo con correa ajustable.", "Una", 65.00m, "41" },
                    { 74, "Teva", 3, "Negro", new DateTime(2026, 1, 23, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7269), "Sandalia con plataforma de goma gruesa.", "Flatform Universal", 85.00m, "40" },
                    { 75, "Melissa", 3, "Transparente", new DateTime(2026, 1, 18, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7271), "Sandalia de plástico reciclado con aroma.", "Luna", 60.00m, "38" },
                    { 76, "OluKai", 3, "Marrón/Beige", new DateTime(2026, 1, 13, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7274), "Chancla hawaiana de alta calidad.", "Olu Kai Ohana", 55.00m, "42" },
                    { 77, "Allen Edmonds", 4, "Negro", new DateTime(2026, 2, 12, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7286), "Zapato oxford estilo americano de piel Horween.", "Park Avenue", 420.00m, "44" },
                    { 78, "Geox", 4, "Marrón Oscuro", new DateTime(2026, 1, 31, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7288), "Zapato de piel con suela transpirable.", "G700 Blucher", 155.00m, "41" },
                    { 79, "Paraboot", 4, "Nogal", new DateTime(2026, 1, 17, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7291), "Zapato de piel Griff de fabricación francesa.", "Richelieu", 350.00m, "42" },
                    { 80, "Church's", 4, "Marrón", new DateTime(2026, 1, 3, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7293), "Mocasín penny clásico de piel Calf.", "Loafer Penny", 480.00m, "43" },
                    { 81, "Carmina", 4, "Miel", new DateTime(2025, 12, 20, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7297), "Derby de punta en ala con brogue.", "Derby Wingtip", 310.00m, "40" },
                    { 82, "Magnanni", 4, "Coñac", new DateTime(2025, 12, 8, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7299), "Zapato monk de hebilla doble de cuero.", "Monk Strap", 280.00m, "42" },
                    { 83, "Grenson", 4, "Oliva", new DateTime(2025, 11, 24, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7302), "Botín formal de punta reforzada en piel Dainite.", "Cap-Toe Boot", 330.00m, "41" },
                    { 84, "Ted Baker", 4, "Negro", new DateTime(2025, 11, 8, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7304), "Botín chelsea de cuero pulido para negocios.", "Chelsea Formal", 200.00m, "43" },
                    { 85, "Tricker's", 4, "Barro", new DateTime(2025, 10, 25, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7307), "Oxford country de piel con suela cuero grueso.", "Oxford Brogue", 490.00m, "44" },
                    { 146, "Puma", 1, "Blanco/Azul", new DateTime(2026, 1, 25, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7500), "Zapatillas de baloncesto estilo retro.", "Clyde Court", 95.00m, "42" },
                    { 147, "Nike", 1, "Negro/Rojo", new DateTime(2026, 1, 14, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7502), "La mayor unidad Air de Nike en el talón.", "Air Max 270", 150.00m, "44" },
                    { 148, "Adidas", 1, "Blanco", new DateTime(2026, 1, 4, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7504), "Zapatilla de entrenamiento rápido.", "Adizero Boston 12", 130.00m, "43" },
                    { 149, "Reebok", 1, "Multicolor", new DateTime(2025, 12, 25, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7507), "Zapatilla con suela en zigzag de alta energía.", "Zig Kinetica", 110.00m, "41" },
                    { 150, "Puma", 1, "Crema/Rosa", new DateTime(2025, 12, 15, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7509), "Zapatilla retro de running con estética 80s.", "Future Rider", 80.00m, "40" },
                    { 171, "Dr. Martens", 2, "Amarillo", new DateTime(2026, 2, 7, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7579), "Bota 1460 en amarillo, edición atrevida.", "Neo Punk Boot", 170.00m, "42" },
                    { 172, "Steve Madden", 2, "Negro", new DateTime(2026, 1, 28, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7581), "Botín chelsea con tacón de bloque.", "Heeled Chelsea", 110.00m, "39" },
                    { 173, "Timberland", 2, "Verde Oliva", new DateTime(2026, 1, 18, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7584), "Bota de cuero para uso rural con forro de lana.", "Country Premium", 215.00m, "43" },
                    { 174, "Camper", 2, "Rojo", new DateTime(2026, 1, 8, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7586), "Botín de piel con cierre lateral.", "Saloma Boot", 195.00m, "41" },
                    { 175, "Lucchese", 2, "Marrón/Turquesa", new DateTime(2025, 12, 29, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7588), "Bota cowboy artesana de piel de cuero.", "Cowboy Heritage", 420.00m, "43" },
                    { 176, "Steve Madden", 3, "Nude", new DateTime(2026, 2, 18, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7640), "Sandalia de plataforma con tiras cruzadas.", "Alisa Platform", 80.00m, "38" },
                    { 177, "Birkenstock", 3, "Marrón", new DateTime(2026, 2, 8, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7643), "Sandalia de piel con plantilla anatómica profunda.", "Fussbett", 145.00m, "42" },
                    { 178, "Havaianas", 3, "Coral", new DateTime(2026, 1, 29, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7645), "Sandalia de tira ancha en color coral vibrante.", "Havana Slide", 30.00m, "41" },
                    { 179, "See by Chloé", 3, "Natural", new DateTime(2026, 1, 19, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7647), "Sandalia impermeable de piel trenzada.", "Salt Waterproof", 195.00m, "39" },
                    { 180, "Fitflop", 3, "Negro", new DateTime(2026, 1, 9, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7649), "Sandalia cuña ergonómica de máxima comodidad.", "Juno Wedge", 90.00m, "40" },
                    { 181, "Edward Green", 4, "Negro", new DateTime(2026, 2, 6, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7653), "Oxford de lujo inglés en piel calf box.", "Captoe Oxford", 850.00m, "42" },
                    { 182, "Crockett & Jones", 4, "Marrón", new DateTime(2026, 1, 17, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7655), "Doble monk de piel Burnished Calf.", "Double Monk Strap", 560.00m, "43" },
                    { 183, "John Lobb", 4, "Negro", new DateTime(2025, 12, 28, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7658), "Zapato Balmoral de piel box calf inglesa.", "Balmorals", 1200.00m, "41" },
                    { 184, "Gaziano & Girling", 4, "Borgoña", new DateTime(2025, 12, 8, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7660), "Oxford de una sola pieza en piel de becerro.", "Wholecut Oxford", 950.00m, "42" },
                    { 185, "Vass", 4, "Mostaza", new DateTime(2025, 11, 18, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7663), "Bota formal húngara hecha a mano.", "Stitchdown Boot", 420.00m, "44" },
                    { 186, "Asics", 1, "Azul/Blanco", new DateTime(2025, 9, 19, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7665), "Zapatilla casual con tecnología Gel de Asics.", "Gel-Nimbus 26", 155.00m, "41" },
                    { 187, "Nike", 1, "Rojo/Blanco", new DateTime(2025, 9, 9, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7667), "La primera zapatilla con ventana Air visible.", "Air Max 1", 130.00m, "40" },
                    { 188, "Adidas", 1, "Negro/Rojo", new DateTime(2025, 8, 30, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7672), "Versión streetwear del NMD clásico.", "NMD_S1", 150.00m, "42" },
                    { 189, "Asics", 1, "Crema/Azul", new DateTime(2025, 8, 20, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7674), "Edición lifestyle de la Gel-1090 retro.", "Gel-1090", 120.00m, "43" },
                    { 190, "New Balance", 1, "Gris", new DateTime(2025, 8, 10, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7676), "Made in USA, la zapatilla premium de New Balance.", "990v6", 185.00m, "41" },
                    { 191, "Asics", 1, "Multi", new DateTime(2025, 7, 31, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7678), "Zapatilla de running con Gel completo 360 grados.", "Gel-Quantum 360", 160.00m, "42" },
                    { 192, "Adidas", 1, "Negro", new DateTime(2025, 7, 21, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7680), "Zapatilla de running con suela Bounce ligera.", "UltraBounce", 70.00m, "44" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$FR8VKzioJR./Z.N9ggFMEOxO2VI7twF3YAKTNypTfOFic54qHWpXq");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "$2a$11$xSxap32MgL32WGDzCWQPzuJzqFA4mRiTSwD90K91YdKncGXqSGNiW");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "CategoryId", "Color", "CreatedAt", "Description", "Name", "Price", "Size" },
                values: new object[,]
                {
                    { 86, "Nike", 5, "Rosa Neón", new DateTime(2026, 2, 15, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7313), "Zapatilla de competición con placa de carbono.", "Vaporfly 3", 250.00m, "42" },
                    { 87, "Adidas", 5, "Blanco/Rojo", new DateTime(2026, 2, 8, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7316), "La zapatilla con la que se baten récords mundiales.", "Adizero Adios Pro", 225.00m, "43" },
                    { 88, "Saucony", 5, "Amarillo Neón", new DateTime(2026, 1, 29, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7318), "Zapatilla de maratón con placa de nylon.", "Endorphin Pro 3", 200.00m, "41" },
                    { 89, "Nike", 5, "Naranja/Blanco", new DateTime(2026, 1, 19, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7321), "Placa de carbono y doble cámara Air para records.", "Alphafly 3", 285.00m, "44" },
                    { 90, "Asics", 5, "Azul", new DateTime(2026, 1, 9, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7362), "Zapatilla de estabilidad para pronadores.", "GT-2000 12", 130.00m, "42" },
                    { 91, "Brooks", 5, "Gris/Azul", new DateTime(2025, 12, 30, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7365), "Máxima amortiguación para rodadores neutros.", "Glycerin 21", 165.00m, "43" },
                    { 92, "Mizuno", 5, "Azul/Plata", new DateTime(2025, 12, 19, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7367), "Zapatilla neutral de alto rendimiento.", "Wave Rider 27", 145.00m, "41" },
                    { 93, "Saucony", 5, "Blanco/Naranja", new DateTime(2025, 12, 9, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7369), "Zapatilla de running con amortiguación PWRRUN+.", "Triumph 21", 165.00m, "44" },
                    { 94, "Asics", 5, "Negro/Plata", new DateTime(2025, 11, 29, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7372), "Zapatilla de máxima amortiguación de Asics.", "Nimbus 26", 175.00m, "43" },
                    { 95, "Brooks", 5, "Azul Celeste", new DateTime(2025, 11, 19, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7374), "Zapatilla versátil y muy cómoda para entrenamientos diarios.", "Ghost 16", 140.00m, "42" },
                    { 96, "On Running", 5, "Blanco", new DateTime(2025, 11, 9, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7376), "Doble capa CloudTec para máxima amortiguación.", "Cloudstratus", 195.00m, "40" },
                    { 97, "Puma", 5, "Negro/Amarillo", new DateTime(2025, 10, 30, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7379), "Zapatilla de competición con placa de carbono.", "Deviate Nitro 3", 220.00m, "41" },
                    { 98, "New Balance", 5, "Blanco/Naranja", new DateTime(2025, 10, 20, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7381), "Zapatilla elite de New Balance para maratón.", "Fuel Cell SC Elite", 250.00m, "42" },
                    { 99, "Mizuno", 5, "Azul/Blanco", new DateTime(2025, 10, 10, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7383), "Máxima protección y amortiguación de Mizuno.", "Wave Sky 7", 155.00m, "43" },
                    { 100, "Nike", 5, "Bosque", new DateTime(2025, 9, 30, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7385), "Zapatilla de trail running de Nike.", "Pegasus Trail 5", 135.00m, "44" },
                    { 101, "Merrell", 6, "Marrón/Negro", new DateTime(2026, 2, 20, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7391), "La bota de senderismo más vendida del mundo.", "Merrell Moab 3", 150.00m, "43" },
                    { 102, "Adidas", 6, "Negro/Gris", new DateTime(2026, 2, 10, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7393), "Zapatilla de trail ligera con membrana Gore-Tex.", "Terrex Swift R3", 165.00m, "42" },
                    { 103, "Salomon", 6, "Azul/Gris", new DateTime(2026, 1, 31, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7395), "Zapatilla de senderismo con suela Contagrip.", "X Ultra 4 GTX", 180.00m, "44" },
                    { 104, "The North Face", 6, "Caqui/Verde", new DateTime(2026, 1, 21, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7398), "Bota ligera para rutas de montaña de nivel medio.", "Litewave Endure II", 140.00m, "41" },
                    { 105, "Lowa", 6, "Gris", new DateTime(2026, 1, 11, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7400), "Bota de montaña con membrana Gore-Tex de Lowa.", "Renegade GTX", 230.00m, "43" },
                    { 106, "Vasque", 6, "Rojo/Gris", new DateTime(2026, 1, 1, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7402), "Bota de trekking con soporte de tobillo.", "Crossrock Mid", 155.00m, "42" },
                    { 107, "La Sportiva", 6, "Negro/Amarillo", new DateTime(2025, 12, 22, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7404), "Zapatilla de fastpacking ultraligera.", "Speedhike", 200.00m, "40" },
                    { 108, "Keen", 6, "Barro/Verde", new DateTime(2025, 12, 12, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7407), "Bota impermeable con puntera protectora.", "Venture 3 Mid", 145.00m, "44" },
                    { 109, "Columbia", 6, "Gris/Azul", new DateTime(2025, 12, 2, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7409), "Zapatilla de trekking con tecnología Omni-Tech.", "Cascade Low 2", 110.00m, "43" },
                    { 110, "Quechua", 6, "Negro", new DateTime(2025, 11, 22, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7411), "Zapatilla de trekking de precio asequible.", "Terroc 500", 60.00m, "42" },
                    { 111, "Arc'teryx", 6, "Gris Oscuro", new DateTime(2025, 11, 12, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7413), "Zapatilla de aproximación polivalente.", "Approach GTX", 260.00m, "41" },
                    { 112, "Merrell", 6, "Oliva", new DateTime(2025, 11, 2, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7416), "Zapatilla ligera de senderismo con suela Vibram.", "Anacapa Breeze Low", 135.00m, "43" },
                    { 113, "Hanwag", 6, "Marrón", new DateTime(2025, 10, 23, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7418), "Bota clásica de cuero para alta montaña.", "Granite III GTX", 280.00m, "44" },
                    { 114, "Asolo", 6, "Verde/Negro", new DateTime(2025, 10, 13, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7420), "Bota de trekking italiana con cierre BOA.", "Trailspace Mid", 240.00m, "42" },
                    { 115, "Scarpa", 6, "Naranja/Negro", new DateTime(2025, 10, 3, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7422), "Zapatilla de aproximación con suela Vibram MegaGrip.", "Wildfire Edge", 185.00m, "41" },
                    { 116, "Nike", 7, "Blanco/Rojo", new DateTime(2026, 2, 24, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7424), "Versión mini del clásico Air Max para los más pequeños.", "Air Max 90 Kids", 85.00m, "32" },
                    { 117, "Adidas", 7, "Blanco/Negro", new DateTime(2026, 2, 19, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7427), "La zapatilla clásica en talla infantil.", "Superstar Kids", 65.00m, "33" },
                    { 118, "Converse", 7, "Rojo", new DateTime(2026, 2, 14, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7429), "Los Chuck Taylor en versión infantil muy resistente.", "Chuck Taylor Jr", 50.00m, "34" },
                    { 119, "Vans", 7, "Negro", new DateTime(2026, 2, 9, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7431), "Zapatillas de skate para niños con velcro.", "Old Skool Kids", 55.00m, "31" },
                    { 120, "Asics", 7, "Multi", new DateTime(2026, 2, 4, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7437), "Zapatilla de triatlón de alto rendimiento para niños.", "Gel-Noosa Tri 15 Jr", 90.00m, "35" },
                    { 121, "New Balance", 7, "Azul/Amarillo", new DateTime(2026, 1, 30, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7439), "Zapatilla de running con velcro para preescolares.", "Fresh Foam 680 Jr", 60.00m, "33" },
                    { 122, "Bobux", 7, "Rosa", new DateTime(2026, 1, 25, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7442), "Zapato de primeros pasos ultraflexible.", "Hopalong Jr", 55.00m, "22" },
                    { 123, "Crocs", 7, "Verde Lima", new DateTime(2026, 1, 20, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7444), "Zuecos de niño ligeros y fáciles de poner.", "Crocs Kids Classic", 35.00m, "29" },
                    { 124, "Timberland", 7, "Amarillo", new DateTime(2026, 1, 15, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7446), "La bota Timberland clásica en versión infantil.", "Bota 6 Inch Jr", 100.00m, "34" },
                    { 125, "George", 7, "Rosa", new DateTime(2026, 1, 10, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7448), "Zapatilla con luces y diseño de Peppa Pig para bebés.", "Peppa Pig Sneaker", 25.00m, "26" },
                    { 126, "Skechers", 7, "Negro/Rojo", new DateTime(2026, 1, 5, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7450), "Zapatilla con ruedas y diseño de Star Wars.", "Star Wars Skechers", 40.00m, "30" },
                    { 127, "Nike", 7, "Negro", new DateTime(2025, 12, 31, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7453), "Zapatilla sin cordones elásticos para niños activos.", "Nike Flex Runner", 50.00m, "32" },
                    { 128, "Adidas", 7, "Verde", new DateTime(2025, 12, 26, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7455), "Bota de senderismo impermeable para pequeños aventureros.", "Terrex Kids", 80.00m, "35" },
                    { 129, "New Balance", 7, "Naranja", new DateTime(2025, 12, 21, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7457), "Zapatilla minimalista para niños con pie sano.", "Minimus Kids", 55.00m, "31" },
                    { 130, "Merrell", 7, "Verde/Azul", new DateTime(2025, 12, 16, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7459), "Zapatilla barefoot para niños en crecimiento.", "Merrell Bare Access", 65.00m, "33" },
                    { 131, "Sebago", 8, "Azul Marino", new DateTime(2026, 2, 23, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7462), "Náutico clásico de piel con cordón.", "Loafer Docksides", 175.00m, "42" },
                    { 132, "Cole Haan", 8, "Cognac", new DateTime(2026, 2, 15, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7464), "Mocasín penny con suela de cuero flexible.", "Penny Loafer", 200.00m, "43" },
                    { 133, "G.H. Bass", 8, "Marrón", new DateTime(2026, 2, 5, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7466), "El penny loafer más clásico de América.", "Weejuns Bass", 160.00m, "41" },
                    { 134, "Tod's", 8, "Cuero Natural", new DateTime(2026, 1, 26, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7470), "Mocasín de guisantes artesanal de lujo italiano.", "Tod's Gommino", 520.00m, "44" },
                    { 135, "Gucci", 8, "Negro", new DateTime(2026, 1, 16, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7472), "Mocasín con detalle de herraje equestre de Gucci.", "Horsebit Loafer", 780.00m, "42" },
                    { 136, "Salvatore Ferragamo", 8, "Marrón Oscuro", new DateTime(2026, 1, 6, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7475), "Mocasín de lujo con herraje dorado.", "Bit Loafer", 680.00m, "43" },
                    { 137, "Minnetonka", 8, "Arena", new DateTime(2025, 12, 27, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7477), "Mocasín de conducción con suela de goma tipo Nido.", "Driving Moc", 80.00m, "40" },
                    { 138, "Alden", 8, "Borgoña", new DateTime(2025, 12, 17, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7480), "Mocasín con borlas de cordovan.", "Tassel Loafer", 650.00m, "42" },
                    { 139, "Sperry", 8, "Avellana", new DateTime(2025, 12, 7, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7482), "Náutico antideslizante con costura de 360 grados.", "Boat Shoe", 110.00m, "41" },
                    { 140, "Camper", 8, "Verde", new DateTime(2025, 11, 27, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7484), "Mocasín flexible de diseño casual mediterráneo.", "Oslo Moc", 140.00m, "43" },
                    { 141, "Steve Madden", 8, "Negro", new DateTime(2025, 11, 17, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7487), "Mocasín con suela grunge de lug.", "Lug Sole Loafer", 90.00m, "39" },
                    { 142, "Naot", 8, "Corcho", new DateTime(2025, 11, 7, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7490), "Mocasín con plantilla de corcho moldeable.", "Naot Kayla", 130.00m, "40" },
                    { 143, "Vans", 8, "Cuadros B&N", new DateTime(2025, 10, 28, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7493), "El slip-on de ajedrez más icónico de Vans.", "Slip-On Checkers", 70.00m, "42" },
                    { 144, "UGG", 8, "Castaño", new DateTime(2025, 10, 18, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7495), "Mocasín con forro de piel de oveja para casa y calle.", "Resort Moc", 120.00m, "43" },
                    { 145, "Rockport", 8, "Negro", new DateTime(2025, 10, 8, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7498), "Mocasín de negocios con suela de goma ligera.", "Larson", 100.00m, "41" },
                    { 151, "Brooks", 5, "Azul/Naranja", new DateTime(2026, 1, 24, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7511), "Zapatilla de tempo run con placa de carbono parcial.", "Boston 12", 160.00m, "42" },
                    { 152, "Asics", 5, "Blanco/Naranja", new DateTime(2026, 1, 14, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7513), "Zapatilla de competición para corredores de zancada.", "Metaspeed Sky+", 250.00m, "43" },
                    { 153, "Saucony", 5, "Blanco", new DateTime(2026, 1, 4, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7516), "Zapatilla de entrenamiento rápido con paleta de nylon.", "Endorphin Speed 4", 175.00m, "41" },
                    { 154, "On Running", 5, "Blanco/Rojo", new DateTime(2025, 12, 25, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7519), "Zapatilla de maratón con placa de carbono de On.", "Cloudboom Echo", 265.00m, "44" },
                    { 155, "Hoka", 5, "Celeste/Blanco", new DateTime(2025, 12, 15, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7521), "La zapatilla de máxima amortiguación de Hoka.", "Clifton 9", 145.00m, "42" },
                    { 156, "Danner", 6, "Marrón/Oliva", new DateTime(2026, 2, 3, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7523), "Bota de cuero Full Grain para alta montaña.", "Stormking Mid", 300.00m, "43" },
                    { 157, "La Sportiva", 6, "Negro/Amarillo", new DateTime(2026, 1, 24, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7526), "Bota trail running con Grip FrixionAll.", "Ultra Raptor II", 210.00m, "42" },
                    { 158, "Scarpa", 6, "Azul/Amarillo", new DateTime(2026, 1, 14, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7528), "Zapatilla de aproximación con Vibram TC Pro.", "TX4 Approach", 175.00m, "41" },
                    { 159, "Keen", 6, "Marrón", new DateTime(2026, 1, 4, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7530), "Zapatilla de trekking impermeable con puntera protectora.", "Targhee III", 150.00m, "44" },
                    { 160, "Salewa", 6, "Negro/Rojo", new DateTime(2025, 12, 25, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7553), "Zapatilla de aproximación polivalente.", "Salewa Wildfire", 165.00m, "43" },
                    { 161, "Skechers", 7, "Rosa/Purpura", new DateTime(2026, 2, 21, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7556), "Zapatillas con luces para niñas.", "Skechers Twinkle", 45.00m, "28" },
                    { 162, "Nike", 7, "Blanco/Verde", new DateTime(2026, 2, 11, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7558), "Las Jordan 1 Low en versión infantil.", "Jordan 1 Low Kids", 75.00m, "35" },
                    { 163, "Adidas", 7, "Blanco", new DateTime(2026, 2, 1, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7561), "La Forum Adidas en versión kids.", "Forum Kids", 65.00m, "34" },
                    { 164, "Biomecanics", 7, "Azul", new DateTime(2026, 1, 22, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7563), "Zapatilla respetuosa con el pie del niño.", "Equilibrio Velcro", 50.00m, "27" },
                    { 165, "Nike", 7, "Gris", new DateTime(2026, 1, 12, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7565), "Zapatilla de entrenamiento para jóvenes atletas.", "Flex Supreme IV", 55.00m, "33" },
                    { 166, "Bass Weejuns", 8, "Burgundy", new DateTime(2026, 2, 13, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7567), "Mocasín con borla y lengüeta kiltie.", "Kiltie Tassel", 170.00m, "42" },
                    { 167, "Clarks", 8, "Maíz", new DateTime(2026, 2, 3, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7570), "El mocasín-bota más icónico de Clarks.", "Wallabee", 150.00m, "43" },
                    { 168, "Paraboot", 8, "Marrón Oscuro", new DateTime(2026, 1, 24, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7572), "Mocasín francés de piel Norwegian welt.", "Fez Loafer", 320.00m, "41" },
                    { 169, "Castañer", 8, "Natural", new DateTime(2026, 1, 14, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7575), "Alpargata de esparto artesanal con suela de yute.", "Esparteña Lona", 90.00m, "40" },
                    { 170, "Clarks", 8, "Arena", new DateTime(2026, 1, 4, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7577), "Bota-mocasín de ante clásica y versátil.", "Desert Trek", 135.00m, "42" },
                    { 193, "Nike", 5, "Blanco/Azul", new DateTime(2025, 12, 5, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7683), "Diseñada para reducir lesiones de running.", "React Infinity 4", 160.00m, "43" },
                    { 194, "Hoka", 5, "Amarillo", new DateTime(2025, 11, 25, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7685), "Zapatilla de entrenamiento rápido de Hoka.", "Mach 6", 145.00m, "41" },
                    { 195, "Hoka", 6, "Naranja/Negro", new DateTime(2025, 12, 15, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7687), "Zapatilla trail running para terrenos variados.", "Jackal II", 150.00m, "43" },
                    { 196, "Hoka", 6, "Azul/Blanco", new DateTime(2025, 12, 5, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7689), "La mejor zapatilla de trail extremo de Hoka.", "Speedgoat 5 GTX", 185.00m, "42" },
                    { 197, "Nike", 7, "Azul/Naranja", new DateTime(2026, 1, 2, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7692), "Bota de fútbol sala para jóvenes talentos.", "Superfly 8 Jr", 60.00m, "36" },
                    { 198, "Adidas", 7, "Blanco/Dorado", new DateTime(2025, 12, 23, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7694), "Bota de fútbol clásica para niños.", "Copa Pure Jr", 55.00m, "35" },
                    { 199, "Ancient Greek", 8, "Natural", new DateTime(2026, 1, 6, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7696), "Mocasín artesanal de rafia tejida a mano.", "Raffia Loafer", 200.00m, "40" },
                    { 200, "Birkenstock", 8, "Negro", new DateTime(2025, 12, 27, 19, 59, 7, 73, DateTimeKind.Utc).AddTicks(7699), "Zueco/mocasín cerrado con plantilla de corcho moldeable.", "Birkenstock Boston", 120.00m, "43" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description" },
                values: new object[] { new DateTime(2026, 2, 19, 19, 35, 37, 914, DateTimeKind.Utc).AddTicks(5446), "Zapatillas retro clásicas." });

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
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2026, 2, 1, 19, 35, 37, 914, DateTimeKind.Utc).AddTicks(5459), "Chuck Taylor All Star" });

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
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2026, 2, 27, 19, 35, 37, 914, DateTimeKind.Utc).AddTicks(5471), "Arizona Soft Footbed" });

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
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2025, 11, 1, 19, 35, 37, 914, DateTimeKind.Utc).AddTicks(5474), "Fifth Avenue Cap-Toe" });

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
                columns: new[] { "CategoryId", "CreatedAt" },
                values: new object[] { 1, new DateTime(2026, 2, 17, 19, 35, 37, 914, DateTimeKind.Utc).AddTicks(5510) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 1, 19, 35, 37, 914, DateTimeKind.Utc).AddTicks(5511));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 20, 19, 35, 37, 914, DateTimeKind.Utc).AddTicks(5513));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 10, 19, 35, 37, 914, DateTimeKind.Utc).AddTicks(5515));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 31, 19, 35, 37, 914, DateTimeKind.Utc).AddTicks(5517));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 21, 19, 35, 37, 914, DateTimeKind.Utc).AddTicks(5518));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 11, 19, 35, 37, 914, DateTimeKind.Utc).AddTicks(5520));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 12, 1, 19, 35, 37, 914, DateTimeKind.Utc).AddTicks(5522));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 21, 19, 35, 37, 914, DateTimeKind.Utc).AddTicks(5524));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2025, 11, 11, 19, 35, 37, 914, DateTimeKind.Utc).AddTicks(5527), "Fresh Foam" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 1, 19, 35, 37, 914, DateTimeKind.Utc).AddTicks(5528));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 22, 19, 35, 37, 914, DateTimeKind.Utc).AddTicks(5536));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 12, 19, 35, 37, 914, DateTimeKind.Utc).AddTicks(5538));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 2, 19, 35, 37, 914, DateTimeKind.Utc).AddTicks(5540));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 22, 19, 35, 37, 914, DateTimeKind.Utc).AddTicks(5541));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 12, 19, 35, 37, 914, DateTimeKind.Utc).AddTicks(5543));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 2, 19, 35, 37, 914, DateTimeKind.Utc).AddTicks(5545));

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
    }
}
