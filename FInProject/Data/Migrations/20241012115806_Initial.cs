using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FInProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ProductName = table.Column<string>(type: "text", nullable: false),
                    RawMaterialCost = table.Column<decimal>(type: "numeric", nullable: false),
                    AuxiliaryMaterialCost = table.Column<decimal>(type: "numeric", nullable: false),
                    ScrapCost = table.Column<decimal>(type: "numeric", nullable: false),
                    BaseSalary = table.Column<decimal>(type: "numeric", nullable: false),
                    AdditionalSalary = table.Column<decimal>(type: "numeric", nullable: false),
                    ManufacturingOverheads = table.Column<decimal>(type: "numeric", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
