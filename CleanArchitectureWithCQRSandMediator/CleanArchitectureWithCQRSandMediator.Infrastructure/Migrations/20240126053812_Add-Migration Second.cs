using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanArchitectureWithCQRSandMediator.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddMigrationSecond : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "Author", "Description", "Name" },
                values: new object[] { 1, "Wole Soyinka", "A very interesting book", "Shakespeare" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
