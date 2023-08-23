using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmaWeb.Data.Migrations
{
    public partial class r : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "NotARobot",
                table: "Appointments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "CreateAppointmentCommand",
                columns: table => new
                {
                    AfspraakID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WeekDays = table.Column<int>(type: "int", nullable: false),
                    DaysSession = table.Column<int>(type: "int", nullable: false),
                    Reasontest = table.Column<int>(type: "int", nullable: false),
                    NotARobot = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreateAppointmentCommand", x => x.AfspraakID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CreateAppointmentCommand");

            migrationBuilder.DropColumn(
                name: "NotARobot",
                table: "Appointments");
        }
    }
}
