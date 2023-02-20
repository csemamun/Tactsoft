using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tactsoft.Data.Migrations
{
    public partial class RenameTableColumnName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CompanyName",
                table: "Currencies",
                newName: "CurrencyName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CurrencyName",
                table: "Currencies",
                newName: "CompanyName");
        }
    }
}
