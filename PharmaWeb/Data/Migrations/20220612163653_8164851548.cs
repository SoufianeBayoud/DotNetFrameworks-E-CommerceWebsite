using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmaWeb.Data.Migrations
{
    public partial class _8164851548 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "Dscription",
                value: "Rhinathiol Syrup is used for Bronchiectasis, Chronic obstructive pulmonary disease, Respiratory tract infections and other conditions.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "Dscription",
                value: "sugar-free and sweetened with stevia, Plantil drinkable solution is a real treat! PLANTS. Plantain leaf fluid extract (Plantago lanceolata)");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "Dscription",
                value: "hand with bandage on it. BANDAGES ; tapes and wraps on hand · TAPES & WRAPS ; Nexcare bandage on someone's shoulder.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "Dscription",
                value: "Ultralight * Improved grip * Improved elasticity * Top performance under compression * Abrasion resistant * Improved compression set (from +100° to -40°) ");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "Dscription",
                value: "These drugs... these are covered by insurance companies and medicare.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "Dscription",
                value: "Salvequick Aqua Block is a thin and flexible plaster that allows the skin to breathe and is 100% waterproof at the same time.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "Dscription",
                value: "Cosmetic cream that is applied to the face at night.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "Dscription",
                value: "ivea Sun provides immediate protection against sunburn, long-term skin damage and helps reduce the risk of sun allergies. ");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "Dscription",
                value: "his is only a cosmetic issue and does not affect the functionality of the security update. How to obtain and install the update.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Dscription", "Name" },
                values: new object[] { "This balm to milk creamy facial polish is gentle yet powerful thanks to finely milled rice powder and nourishing almond oil. ", "IMPERIAL GLOW FACIAL POLISH" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "Dscription",
                value: "Performance skincare for MEN - Combining high performance natural ingredients such as Marine Collagen, Hyaluronic Acid, Peptides...");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "Dscription",
                value: "");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "Dscription",
                value: "");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "Dscription",
                value: "");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "Dscription",
                value: "");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "Dscription",
                value: "");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "Dscription",
                value: "");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "Dscription",
                value: "");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "Dscription",
                value: "");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "Dscription",
                value: "");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Dscription", "Name" },
                values: new object[] { "", "MPERIAL GLOW FACIAL POLISH" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "Dscription",
                value: "");
        }
    }
}
