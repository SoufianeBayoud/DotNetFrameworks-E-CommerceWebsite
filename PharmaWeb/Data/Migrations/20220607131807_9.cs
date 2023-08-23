using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmaWeb.Data.Migrations
{
    public partial class _9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Dscription",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Stock",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Dscription", "Stock" },
                values: new object[] { "Fluoxetine, sold under the brand names Prozac and Sarafem among others, is an antidepressant of the selective serotonin reuptake inhibitor (SSRI) class.", 100 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "Dscription", "Image", "Name", "Price", "Productnumber", "Stock" },
                values: new object[] { 1, "Sensodyne Complete Protection toothpastes provide all the oral care benefits you need in 1 complete sensitivity toothpaste. They protect against plaque, maintain healthy gums, help restore your teeth's natural whiteness, and provide lasting sensitivity protection with twice daily brushing.", "https://www.pngkey.com/png/full/866-8669390_sensodyne-rapid.png", "Sensodyne", 15.99, "999SENS", 20 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "Dscription", "Image", "Name", "Price", "Productnumber", "Stock" },
                values: new object[] { 1, "A drug, also medicine and drug, is a chemical substance or complex of chemical substances with an intended pharmacological, immunological or metabolic effect on the body.", "https://www.onlinemedicineshop.com/wp-content/uploads/2020/11/Eromycin-DS-500-mg-Tablet-1200x1012.jpg", "SQUARE", 4.9900000000000002, "33A5vs65V", 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "Dscription", "Image", "Name", "Price", "Productnumber", "Stock" },
                values: new object[] { 1, "This lens solution is suitable for soft lenses. Cleans the lenses very thoroughly", "https://lion-corp.s3.amazonaws.com/uploads/grn/product/normal_image/436/SucrateG.png", "Daxolerin", 5.9900000000000002, "ZBE545VZ", 33 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "Dscription", "Image", "Name", "Price", "Productnumber", "Stock" },
                values: new object[] { 1, "Fissure Control was developed from natural and USDA organic therapeutic ingredients to relieve rectal pain and fissures.", "https://m.media-amazon.com/images/I/51lLxmOJL0L._SL500_.jpg", "Fissure", 10.99, "864ZZEB452", 50 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Dscription", "Image", "Name", "Price", "Productnumber", "Stock" },
                values: new object[,]
                {
                    { 6, 2, "Supradyn Complex Energy is a daily supplement of vitamins and minerals your body and gives support to keep your energy levels up.", "https://d3gr7hv60ouvr1.cloudfront.net/CACHE/images/products/56643b63a65e49ee88778be94af3a4c3/f9f541367200a9faa097c8b660641b4f.jpg", "Supradyn Energy", 32.990000000000002, "00SPR02", 230 },
                    { 7, 2, "Gold Standard 100% Whey is a combination of whey isolate, concentrated whey and hydrolysed whey. Achieve Your Goals! ", "https://5.imimg.com/data5/SELLER/Default/2021/11/IU/WP/KW/83231331/optimum-nutrition-on-gold-standard-100-whey-protein-powder-4-kg-500x500.jpg", "Nutrition gold", 21.989999999999998, "GZZEB55", 20 },
                    { 8, 2, "β-Alanine (or beta-alanine) is a naturally occurring beta amino acid, which is an amino acid in which the amino group is attached to the β-carbon", "https://6dsportsnutrition.com/media/catalog/product/cache/51ac8a5d408dc9e4d755285704d58e61/6/d/6dsportsnutrition.com-shop_images_2022-6d_beta-alanine_-_sr_carnosyn_-_1080x1080.png", "BETA alanine", 23.550000000000001, "BBZ6565vZ", 10 },
                    { 9, 2, "Starlabs WP8 Myobolic 2.0 contains a precise combination of fast-release whey (concentrates, hydrolysates and isolates)", "https://sport-nutrition.be/web/image/product.template/6762/image_512?unique=f43c6c6", "WP8", 30.359999999999999, "BBBZ56", 33 },
                    { 10, 2, "relieves pain and reduces inflammation and temperature as well as relieving headaches and other types of pain. It also relieves cold and flu symptoms.", "https://lion-corp.s3.amazonaws.com/uploads/grn/product/normal_image/436/SucrateG.png", "JapanCZ", 5.9900000000000002, "BHEBE6", 50 },
                    { 11, 3, "Nurofen provides effective pain relief for headaches, migraines, muscular pain, joint pain, period pain and more.", "https://www.pharmacy.biz/wp-content/uploads/sites/1/2020/02/RB_Nurofen_STRAWBERRY_100ml_RBL1800496_0000000_FOP.jpg", "Neurofen for kids", 18.359999999999999, "NEU4653B", 55 },
                    { 12, 3, "This medicine is an analgesic (painkiller) and an antipyretic (it reduces fever).", "https://www.pixelpharma.be/files/products/3734886/3734886_71b27e961230c566364a302978ea01f8_nl.jpg", "Dafalgan Pediaterie", 8.3499999999999996, "6546BDRB", 20 },
                    { 13, 3, "This metal-powder blend consists of a steel powder formed by atomizing a steel melt and mixed with 0.3-0.7 % by wt.", "https://m.media-amazon.com/images/I/61NrauwGIRL._AC_SX425_.jpg", "Powderd blend", 14.85, "151645VIT", 10 },
                    { 14, 3, "", "https://img.newpharma.net/images/products/nl/500/muco-rhinathiol-2-siroop-kinderen-diepzittende-slijmhoest-fles-200ml.2003.jpg", "Muco Rhinatol", 15.99, "MUC63165", 33 },
                    { 15, 3, "", "https://files.apotheeksollie.be/cache/products/images/cache_400x400/8d4dfe8ceab63d55c4992b8965da4796cdd20d38.jpeg", "Plantil", 11.99, "PL216C", 50 },
                    { 16, 4, "", "https://www.farmavazquez.com/80250/590494.jpg", "Nexcare Bandages", 2.9900000000000002, "56165ZV", 76 },
                    { 17, 4, "", "https://assets.sainsburys-groceries.co.uk/gol/3288603/1/640x640.jpg", "Water resitant platsers", 8.3499999999999996, "564645BG", 20 },
                    { 18, 4, "", "https://digitalcontent.api.tesco.com/v2/media/ghs/952dcead-b078-4cec-9727-3cb161434316/9b17af9e-f14f-4f9a-854d-100f778351fa_1148989823.jpeg?h=540&w=540", "Fabric Plasters", 3.4500000000000002, "35BB65C", 10 },
                    { 19, 4, "", "https://www.flemingmedical.co.uk/product/image/large/md02-3%3D1_0.jpg", "Medicare", 6.9900000000000002, "MEDI32516", 33 },
                    { 20, 4, "", "https://wwwcederrothcom.cdn.triggerfish.cloud/uploads/2020/11/6444-salvequick-textile-plaster-r.png", "Salvequick", 2.9900000000000002, "SAL21651", 50 },
                    { 21, 5, "", "https://cdn2.shopify.com/s/files/1/0012/9669/5349/products/058469_A.png", "Night cream", 9.9900000000000002, "NCHT3562", 90 },
                    { 22, 5, "", "https://images-us.nivea.com/-/media/media-center-items/7/a/1/f7b2b73e509f4ec7a56cb87a8dd2f5e0-web_1010x1180_transparent_png.png", "Nivea sun cream", 29.989999999999998, "NIV2654", 20 },
                    { 23, 5, "", "https://media.cnn.com/api/v1/images/stellar/prod/210415112813-sustainable-beauty-brands-lead.jpg?q=w_2500,h_1406,x_0,y_0,c_fill", "Ila pack cosmetic", 59.990000000000002, "5165SVSDV5", 10 },
                    { 24, 5, "", "https://media.s-bol.com/92v6yP526n44/1095x1200.jpg", "MPERIAL GLOW FACIAL POLISH", 25.989999999999998, "26GZE65C", 33 },
                    { 25, 5, "", "https://www.luxuryformen.com/media/catalog/product/cache/fc49963b087eb4c20dab947be5959514/f/a/face_polish_1100_x_1100.jpg", "Humanity Cosmetics", 39.990000000000002, "464A554vV", 50 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DropColumn(
                name: "Dscription",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Stock",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "Image", "Name", "Price", "Productnumber" },
                values: new object[] { 2, "https://d3gr7hv60ouvr1.cloudfront.net/CACHE/images/products/56643b63a65e49ee88778be94af3a4c3/f9f541367200a9faa097c8b660641b4f.jpg", "Supradyn Energy", 32.990000000000002, "00SPR02" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "Image", "Name", "Price", "Productnumber" },
                values: new object[] { 3, "https://www.pharmacy.biz/wp-content/uploads/sites/1/2020/02/RB_Nurofen_STRAWBERRY_100ml_RBL1800496_0000000_FOP.jpg", "Neurofen for kids", 18.359999999999999, "NEU4653B" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "Image", "Name", "Price", "Productnumber" },
                values: new object[] { 4, "https://www.farmavazquez.com/80250/590494.jpg", "Nexcare Bandages", 2.9900000000000002, "56165ZV" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "Image", "Name", "Price", "Productnumber" },
                values: new object[] { 5, "https://cdn2.shopify.com/s/files/1/0012/9669/5349/products/058469_A.png", "Night cream", 9.9900000000000002, "NCHT3562" });
        }
    }
}
