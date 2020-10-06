using Microsoft.EntityFrameworkCore.Migrations;

namespace Bilance_Exchange.Repository.Migrations
{
    public partial class SeedCurrenciesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "MaxSupply", "Name", "ShortName" },
                values: new object[] { 2, 21000000.0, "Bitcoin", "BTC" });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "MaxSupply", "Name", "ShortName" },
                values: new object[] { 3, null, "Dollar", "USDR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
