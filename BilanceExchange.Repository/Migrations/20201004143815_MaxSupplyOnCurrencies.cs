using Microsoft.EntityFrameworkCore.Migrations;

namespace Bilance_Exchange.Repository.Migrations
{
    public partial class MaxSupplyOnCurrencies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "MaxSupply",
                table: "Currencies",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaxSupply",
                table: "Currencies");
        }
    }
}
