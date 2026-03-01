using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Back_Vueapp.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUserHashes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$e/y4QWJmOqYibW7h.3V3u.hW2YmZ4iJ0eLZ4p0hK8u/S0WpHC626q");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "$2a$11$e/y4QWJmOqYibW7h.3V3u.hW2YmZ4iJ0eLZ4p0hK8u/S0WpHC626q");
        }
    }
}
