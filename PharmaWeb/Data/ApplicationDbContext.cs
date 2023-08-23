using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PharmaWeb.Models;

namespace PharmaWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            

            builder.Entity<Appointment>().HasData(
               new Appointment()
               {
                   AfspraakID = 1,
                   FirstName = "Mohamed",
                   LastName = "Ben",
                   BirthDate = new DateTime(2002, 6, 5) /*MM-dd-yyyy*/ ,
                   PhoneNumber = "0484881725",
                   WeekDays = WeekDays.Monday,
                   DaysSession = DaysSession.Session2,
                   Reasontest = Reasontest.reason2,
                   NotARobot = false,
                   IsDeleted = false
               },
                new Appointment()
                {
                    AfspraakID = 2,
                    FirstName = "Jan",
                    LastName = "Jansens",
                    BirthDate = new DateTime(2000, 4, 15) /*MM-dd-yyyy*/ ,
                    PhoneNumber = "04845831725",
                    WeekDays = WeekDays.Tuesday,
                    DaysSession = DaysSession.Session1,
                    Reasontest = Reasontest.reason2,
                    NotARobot = false,
                    IsDeleted = false
                },
                 new Appointment()
                 {
                     AfspraakID = 3,
                     FirstName = "Piet",
                     LastName = "Pinter",
                     BirthDate = new DateTime(1998, 10, 20) /*MM-dd-yyyy*/ ,
                     PhoneNumber = "0484811318",
                     WeekDays = WeekDays.Friday,
                     DaysSession = DaysSession.Session3,
                     Reasontest = Reasontest.reason1,
                     NotARobot = false,
                     IsDeleted = false
                 }

              
            );

            builder.Entity<Category>().HasData(
              new Category() { Id = 1, Name = "Medicines" },
              new Category() { Id = 2, Name = "Nutrition & Vitamins" },
              new Category() { Id = 3, Name = "Children" },
              new Category() { Id = 4, Name = "Plasters" },
              new Category() { Id = 5, Name = "Cosmetics" }
              );

            builder.Entity<Product>().HasData(
              new Product() { Id = 1, Name = "Fluoxentine", Dscription= "Fluoxetine, sold under the brand names Prozac and Sarafem among others, is an antidepressant of the selective serotonin reuptake inhibitor (SSRI) class.",  Stock = 100 , CategoryId = 1, Price = 25.99, Productnumber = "33A5vs65V", Image = "https://www.buy-pharma.md/img/uploads/10193-Paroxetine-20-Mg-Box.jpg",IsDeleted = false },
              new Product() { Id = 2, Name = "Sensodyne",Dscription= "Sensodyne Complete Protection toothpastes provide all the oral care benefits you need in 1 complete sensitivity toothpaste. They protect against plaque, maintain healthy gums, help restore your teeth's natural whiteness, and provide lasting sensitivity protection with twice daily brushing.", Stock =20, CategoryId = 1, Price = 15.99, Productnumber = "999SENS", Image = "https://www.pngkey.com/png/full/866-8669390_sensodyne-rapid.png", IsDeleted = false },
              new Product() { Id = 3, Name = "SQUARE", Dscription = "A drug, also medicine and drug, is a chemical substance or complex of chemical substances with an intended pharmacological, immunological or metabolic effect on the body.", Stock = 10, CategoryId = 1, Price = 4.99, Productnumber = "33A5vs65V", Image = "https://www.onlinemedicineshop.com/wp-content/uploads/2020/11/Eromycin-DS-500-mg-Tablet-1200x1012.jpg", IsDeleted = false },
              new Product() { Id = 4, Name = "Daxolerin", Dscription = "This lens solution is suitable for soft lenses. Cleans the lenses very thoroughly", Stock = 33, CategoryId = 1, Price = 5.99, Productnumber = "ZBE545VZ", Image = "https://lion-corp.s3.amazonaws.com/uploads/grn/product/normal_image/436/SucrateG.png", IsDeleted = false },
              new Product() { Id = 5, Name = "Fissure", Dscription = "Fissure Control was developed from natural and USDA organic therapeutic ingredients to relieve rectal pain and fissures.", Stock = 50, CategoryId = 1, Price = 10.99, Productnumber = "864ZZEB452", Image = "https://m.media-amazon.com/images/I/51lLxmOJL0L._SL500_.jpg", IsDeleted = false },

              new Product() { Id = 6, Name = "Supradyn Energy", Dscription = "Supradyn Complex Energy is a daily supplement of vitamins and minerals your body and gives support to keep your energy levels up.", Stock = 230, CategoryId = 2, Price = 32.99, Productnumber = "00SPR02", Image = "https://d3gr7hv60ouvr1.cloudfront.net/CACHE/images/products/56643b63a65e49ee88778be94af3a4c3/f9f541367200a9faa097c8b660641b4f.jpg", IsDeleted = false },
              new Product() { Id = 7, Name = "Nutrition gold", Dscription = "Gold Standard 100% Whey is a combination of whey isolate, concentrated whey and hydrolysed whey. Achieve Your Goals! ", Stock = 20, CategoryId = 2, Price = 21.99, Productnumber = "GZZEB55", Image = "https://5.imimg.com/data5/SELLER/Default/2021/11/IU/WP/KW/83231331/optimum-nutrition-on-gold-standard-100-whey-protein-powder-4-kg-500x500.jpg", IsDeleted = false },
              new Product() { Id = 8, Name = "BETA alanine", Dscription = "β-Alanine (or beta-alanine) is a naturally occurring beta amino acid, which is an amino acid in which the amino group is attached to the β-carbon", Stock = 10, CategoryId = 2, Price = 23.55, Productnumber = "BBZ6565vZ", Image = "https://6dsportsnutrition.com/media/catalog/product/cache/51ac8a5d408dc9e4d755285704d58e61/6/d/6dsportsnutrition.com-shop_images_2022-6d_beta-alanine_-_sr_carnosyn_-_1080x1080.png", IsDeleted = false },
              new Product() { Id = 9, Name = "WP8", Dscription = "Starlabs WP8 Myobolic 2.0 contains a precise combination of fast-release whey (concentrates, hydrolysates and isolates)", Stock = 33, CategoryId = 2, Price = 30.36, Productnumber = "BBBZ56", Image = "https://sport-nutrition.be/web/image/product.template/6762/image_512?unique=f43c6c6", IsDeleted = false },
              new Product() { Id = 10, Name = "JapanCZ", Dscription = "relieves pain and reduces inflammation and temperature as well as relieving headaches and other types of pain. It also relieves cold and flu symptoms.", Stock = 50, CategoryId = 2, Price = 5.99, Productnumber = "BHEBE6", Image = "https://lion-corp.s3.amazonaws.com/uploads/grn/product/normal_image/436/SucrateG.png", IsDeleted = false },

              new Product() { Id = 11,Name = "Neurofen for kids", Dscription = "Nurofen provides effective pain relief for headaches, migraines, muscular pain, joint pain, period pain and more.", Stock = 55, CategoryId = 3, Price = 18.36, Productnumber="NEU4653B", Image= "https://www.pharmacy.biz/wp-content/uploads/sites/1/2020/02/RB_Nurofen_STRAWBERRY_100ml_RBL1800496_0000000_FOP.jpg", IsDeleted = false },
              new Product() { Id = 12, Name = "Dafalgan Pediaterie", Dscription = "This medicine is an analgesic (painkiller) and an antipyretic (it reduces fever).", Stock = 20, CategoryId = 3, Price = 8.35, Productnumber = "6546BDRB", Image = "https://www.pixelpharma.be/files/products/3734886/3734886_71b27e961230c566364a302978ea01f8_nl.jpg", IsDeleted = false },
              new Product() { Id = 13, Name = "Powderd blend", Dscription = "This metal-powder blend consists of a steel powder formed by atomizing a steel melt and mixed with 0.3-0.7 % by wt.", Stock = 10, CategoryId = 3, Price = 14.85, Productnumber = "151645VIT", Image = "https://m.media-amazon.com/images/I/61NrauwGIRL._AC_SX425_.jpg", IsDeleted = false },
              new Product() { Id = 14, Name = "Muco Rhinatol", Dscription = "Rhinathiol Syrup is used for Bronchiectasis, Chronic obstructive pulmonary disease, Respiratory tract infections and other conditions.", Stock = 33, CategoryId = 3, Price = 15.99, Productnumber = "MUC63165", Image = "https://img.newpharma.net/images/products/nl/500/muco-rhinathiol-2-siroop-kinderen-diepzittende-slijmhoest-fles-200ml.2003.jpg", IsDeleted = false },
              new Product() { Id = 15, Name = "Plantil", Dscription = "sugar-free and sweetened with stevia, Plantil drinkable solution is a real treat! PLANTS. Plantain leaf fluid extract (Plantago lanceolata)", Stock = 50, CategoryId = 3, Price = 11.99, Productnumber = "PL216C", Image = "https://files.apotheeksollie.be/cache/products/images/cache_400x400/8d4dfe8ceab63d55c4992b8965da4796cdd20d38.jpeg", IsDeleted = false },

              new Product() { Id = 16, Name = "Nexcare Bandages", Dscription = "hand with bandage on it. BANDAGES ; tapes and wraps on hand · TAPES & WRAPS ; Nexcare bandage on someone's shoulder.", Stock = 76, CategoryId = 4, Price = 2.99, Productnumber = "56165ZV", Image = "https://www.farmavazquez.com/80250/590494.jpg", IsDeleted = false },
              new Product() { Id = 17, Name = "Water resistant platsers", Dscription = "aterproofs the surface and in-depth skin, protects against water spots and humidity, maintains the breathability ", Stock = 20, CategoryId = 4, Price = 8.35, Productnumber = "564645BG", Image = "https://assets.sainsburys-groceries.co.uk/gol/3288603/1/640x640.jpg" },
              new Product() { Id = 18, Name = "Fabric Plasters", Dscription = "Ultralight * Improved grip * Improved elasticity * Top performance under compression * Abrasion resistant * Improved compression set (from +100° to -40°) ", Stock = 10, CategoryId = 4, Price = 3.45, Productnumber = "35BB65C", Image = "https://digitalcontent.api.tesco.com/v2/media/ghs/952dcead-b078-4cec-9727-3cb161434316/9b17af9e-f14f-4f9a-854d-100f778351fa_1148989823.jpeg?h=540&w=540", IsDeleted = false },
              new Product() { Id = 19, Name = "Medicare", Dscription = "These drugs... these are covered by insurance companies and medicare.", Stock = 33, CategoryId = 4, Price = 6.99, Productnumber = "MEDI32516", Image = "https://www.flemingmedical.co.uk/product/image/large/md02-3%3D1_0.jpg", IsDeleted = false },
              new Product() { Id = 20, Name = "Salvequick", Dscription = "Salvequick Aqua Block is a thin and flexible plaster that allows the skin to breathe and is 100% waterproof at the same time.", Stock = 50, CategoryId = 4, Price = 2.99, Productnumber = "SAL21651", Image = "https://wwwcederrothcom.cdn.triggerfish.cloud/uploads/2020/11/6444-salvequick-textile-plaster-r.png", IsDeleted = false },

              new Product() { Id = 21, Name = "Night cream", Dscription = "Cosmetic cream that is applied to the face at night.", Stock = 90, CategoryId = 5, Price = 9.99, Productnumber = "NCHT3562", Image = "https://cdn2.shopify.com/s/files/1/0012/9669/5349/products/058469_A.png", IsDeleted = false },
              new Product() { Id = 22, Name = "Nivea sun cream", Dscription = "ivea Sun provides immediate protection against sunburn, long-term skin damage and helps reduce the risk of sun allergies. ", Stock = 20, CategoryId = 5, Price = 29.99, Productnumber = "NIV2654", Image = "https://images-us.nivea.com/-/media/media-center-items/7/a/1/f7b2b73e509f4ec7a56cb87a8dd2f5e0-web_1010x1180_transparent_png.png", IsDeleted = false },
              new Product() { Id = 23, Name = "Ila pack cosmetic", Dscription = "his is only a cosmetic issue and does not affect the functionality of the security update. How to obtain and install the update.", Stock = 10, CategoryId = 5, Price = 59.99, Productnumber = "5165SVSDV5", Image = "https://media.cnn.com/api/v1/images/stellar/prod/210415112813-sustainable-beauty-brands-lead.jpg?q=w_2500,h_1406,x_0,y_0,c_fill", IsDeleted = false },
              new Product() { Id = 24, Name = "IMPERIAL GLOW FACIAL POLISH", Dscription = "This balm to milk creamy facial polish is gentle yet powerful thanks to finely milled rice powder and nourishing almond oil. ", Stock = 33, CategoryId = 5, Price = 25.99, Productnumber = "26GZE65C", Image = "https://media.s-bol.com/92v6yP526n44/1095x1200.jpg", IsDeleted = false },
              new Product() { Id = 25, Name = "Humanity Cosmetics", Dscription = "Performance skincare for MEN - Combining high performance natural ingredients such as Marine Collagen, Hyaluronic Acid, Peptides...", Stock = 50, CategoryId = 5, Price = 39.99, Productnumber = "464A554vV", Image = "https://www.luxuryformen.com/media/catalog/product/cache/fc49963b087eb4c20dab947be5959514/f/a/face_polish_1100_x_1100.jpg", IsDeleted = false }
              );


        }

        public DbSet<Appointment> Appointments{ get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }

        public DbSet<ApplicationUser> Users { get; set; }

    }
}
