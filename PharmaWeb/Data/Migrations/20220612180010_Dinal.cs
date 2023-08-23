using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmaWeb.Data.Migrations
{
    public partial class Dinal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Dscription", "Name" },
                values: new object[] { "aterproofs the surface and in-depth skin, protects against water spots and humidity, maintains the breathability ", "Water resistant platsers" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Dscription", "Name" },
                values: new object[] { "", "Water resitant platsers" });
        }
    }
}
