using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmaWeb.Data.Migrations
{
    public partial class delete2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Products");
        }
    }
}
