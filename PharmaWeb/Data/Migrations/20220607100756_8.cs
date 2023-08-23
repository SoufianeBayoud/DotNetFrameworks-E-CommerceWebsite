using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmaWeb.Data.Migrations
{
    public partial class _8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CreateAppointmentCommand");

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Productnumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Medicines" },
                    { 2, "Nutrition & Vitamins" },
                    { 3, "Children" },
                    { 4, "Plasters" },
                    { 5, "Cosmetics" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Image", "Name", "Price", "Productnumber" },
                values: new object[,]
                {
                    { 1, 1, "https://www.buy-pharma.md/img/uploads/10193-Paroxetine-20-Mg-Box.jpg", "Fluoxentine", 25.989999999999998, "33A5vs65V" },
                    { 2, 2, "https://d3gr7hv60ouvr1.cloudfront.net/CACHE/images/products/56643b63a65e49ee88778be94af3a4c3/f9f541367200a9faa097c8b660641b4f.jpg", "Supradyn Energy", 32.990000000000002, "00SPR02" },
                    { 3, 3, "https://www.pharmacy.biz/wp-content/uploads/sites/1/2020/02/RB_Nurofen_STRAWBERRY_100ml_RBL1800496_0000000_FOP.jpg", "Neurofen for kids", 18.359999999999999, "NEU4653B" },
                    { 4, 4, "https://www.farmavazquez.com/80250/590494.jpg", "Nexcare Bandages", 2.9900000000000002, "56165ZV" },
                    { 5, 5, "https://cdn2.shopify.com/s/files/1/0012/9669/5349/products/058469_A.png", "Night cream", 9.9900000000000002, "NCHT3562" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.CreateTable(
                name: "CreateAppointmentCommand",
                columns: table => new
                {
                    AfspraakID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DaysSession = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NotARobot = table.Column<bool>(type: "bit", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reasontest = table.Column<int>(type: "int", nullable: false),
                    WeekDays = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreateAppointmentCommand", x => x.AfspraakID);
                });
        }
    }
}
