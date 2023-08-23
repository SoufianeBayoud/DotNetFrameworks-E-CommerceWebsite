using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmaWeb.Data.Migrations
{
    public partial class z : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Afspraak");

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    AfspraakID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WeekDays = table.Column<int>(type: "int", nullable: true),
                    DaysSession = table.Column<int>(type: "int", nullable: true),
                    Reasontest = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.AfspraakID);
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AfspraakID", "BirthDate", "DaysSession", "FirstName", "LastName", "PhoneNumber", "Reasontest", "WeekDays" },
                values: new object[] { 1, new DateTime(2002, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Mohamed", "Ben", "0484881725", 1, 0 });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AfspraakID", "BirthDate", "DaysSession", "FirstName", "LastName", "PhoneNumber", "Reasontest", "WeekDays" },
                values: new object[] { 2, new DateTime(2000, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Jan", "Jansens", "04845831725", 1, 1 });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AfspraakID", "BirthDate", "DaysSession", "FirstName", "LastName", "PhoneNumber", "Reasontest", "WeekDays" },
                values: new object[] { 3, new DateTime(1998, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Piet", "Pinter", "0484811318", 0, 4 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.CreateTable(
                name: "Afspraak",
                columns: table => new
                {
                    AfspraakID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DaysSession = table.Column<int>(type: "int", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reasontest = table.Column<int>(type: "int", nullable: true),
                    WeekDays = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Afspraak", x => x.AfspraakID);
                });

            migrationBuilder.InsertData(
                table: "Afspraak",
                columns: new[] { "AfspraakID", "BirthDate", "DaysSession", "FirstName", "LastName", "PhoneNumber", "Reasontest", "WeekDays" },
                values: new object[] { 1, new DateTime(2002, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Mohamed", "Ben", "0484881725", 1, 0 });

            migrationBuilder.InsertData(
                table: "Afspraak",
                columns: new[] { "AfspraakID", "BirthDate", "DaysSession", "FirstName", "LastName", "PhoneNumber", "Reasontest", "WeekDays" },
                values: new object[] { 2, new DateTime(2000, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Jan", "Jansens", "04845831725", 1, 1 });

            migrationBuilder.InsertData(
                table: "Afspraak",
                columns: new[] { "AfspraakID", "BirthDate", "DaysSession", "FirstName", "LastName", "PhoneNumber", "Reasontest", "WeekDays" },
                values: new object[] { 3, new DateTime(1998, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Piet", "Pinter", "0484811318", 0, 4 });
        }
    }
}
