﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PharmaWeb.Data;

#nullable disable

namespace PharmaWeb.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220612164709_delete")]
    partial class delete
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("PharmaWeb.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("PharmaWeb.Data.Appointment", b =>
                {
                    b.Property<int>("AfspraakID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AfspraakID"), 1L, 1);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DaysSession")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("NotARobot")
                        .HasColumnType("bit");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Reasontest")
                        .HasColumnType("int");

                    b.Property<int?>("WeekDays")
                        .HasColumnType("int");

                    b.HasKey("AfspraakID");

                    b.ToTable("Appointments");

                    b.HasData(
                        new
                        {
                            AfspraakID = 1,
                            BirthDate = new DateTime(2002, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DaysSession = 1,
                            FirstName = "Mohamed",
                            IsDeleted = false,
                            LastName = "Ben",
                            NotARobot = false,
                            PhoneNumber = "0484881725",
                            Reasontest = 1,
                            WeekDays = 0
                        },
                        new
                        {
                            AfspraakID = 2,
                            BirthDate = new DateTime(2000, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DaysSession = 0,
                            FirstName = "Jan",
                            IsDeleted = false,
                            LastName = "Jansens",
                            NotARobot = false,
                            PhoneNumber = "04845831725",
                            Reasontest = 1,
                            WeekDays = 1
                        },
                        new
                        {
                            AfspraakID = 3,
                            BirthDate = new DateTime(1998, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DaysSession = 2,
                            FirstName = "Piet",
                            IsDeleted = false,
                            LastName = "Pinter",
                            NotARobot = false,
                            PhoneNumber = "0484811318",
                            Reasontest = 0,
                            WeekDays = 4
                        });
                });

            modelBuilder.Entity("PharmaWeb.Data.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Medicines"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Nutrition & Vitamins"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Children"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Plasters"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Cosmetics"
                        });
                });

            modelBuilder.Entity("PharmaWeb.Data.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Zip")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("PharmaWeb.Data.OrderLine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderLines");
                });

            modelBuilder.Entity("PharmaWeb.Data.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Dscription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Productnumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Dscription = "Fluoxetine, sold under the brand names Prozac and Sarafem among others, is an antidepressant of the selective serotonin reuptake inhibitor (SSRI) class.",
                            Image = "https://www.buy-pharma.md/img/uploads/10193-Paroxetine-20-Mg-Box.jpg",
                            Name = "Fluoxentine",
                            Price = 25.989999999999998,
                            Productnumber = "33A5vs65V",
                            Stock = 100
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Dscription = "Sensodyne Complete Protection toothpastes provide all the oral care benefits you need in 1 complete sensitivity toothpaste. They protect against plaque, maintain healthy gums, help restore your teeth's natural whiteness, and provide lasting sensitivity protection with twice daily brushing.",
                            Image = "https://www.pngkey.com/png/full/866-8669390_sensodyne-rapid.png",
                            Name = "Sensodyne",
                            Price = 15.99,
                            Productnumber = "999SENS",
                            Stock = 20
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Dscription = "A drug, also medicine and drug, is a chemical substance or complex of chemical substances with an intended pharmacological, immunological or metabolic effect on the body.",
                            Image = "https://www.onlinemedicineshop.com/wp-content/uploads/2020/11/Eromycin-DS-500-mg-Tablet-1200x1012.jpg",
                            Name = "SQUARE",
                            Price = 4.9900000000000002,
                            Productnumber = "33A5vs65V",
                            Stock = 10
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Dscription = "This lens solution is suitable for soft lenses. Cleans the lenses very thoroughly",
                            Image = "https://lion-corp.s3.amazonaws.com/uploads/grn/product/normal_image/436/SucrateG.png",
                            Name = "Daxolerin",
                            Price = 5.9900000000000002,
                            Productnumber = "ZBE545VZ",
                            Stock = 33
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            Dscription = "Fissure Control was developed from natural and USDA organic therapeutic ingredients to relieve rectal pain and fissures.",
                            Image = "https://m.media-amazon.com/images/I/51lLxmOJL0L._SL500_.jpg",
                            Name = "Fissure",
                            Price = 10.99,
                            Productnumber = "864ZZEB452",
                            Stock = 50
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            Dscription = "Supradyn Complex Energy is a daily supplement of vitamins and minerals your body and gives support to keep your energy levels up.",
                            Image = "https://d3gr7hv60ouvr1.cloudfront.net/CACHE/images/products/56643b63a65e49ee88778be94af3a4c3/f9f541367200a9faa097c8b660641b4f.jpg",
                            Name = "Supradyn Energy",
                            Price = 32.990000000000002,
                            Productnumber = "00SPR02",
                            Stock = 230
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 2,
                            Dscription = "Gold Standard 100% Whey is a combination of whey isolate, concentrated whey and hydrolysed whey. Achieve Your Goals! ",
                            Image = "https://5.imimg.com/data5/SELLER/Default/2021/11/IU/WP/KW/83231331/optimum-nutrition-on-gold-standard-100-whey-protein-powder-4-kg-500x500.jpg",
                            Name = "Nutrition gold",
                            Price = 21.989999999999998,
                            Productnumber = "GZZEB55",
                            Stock = 20
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 2,
                            Dscription = "β-Alanine (or beta-alanine) is a naturally occurring beta amino acid, which is an amino acid in which the amino group is attached to the β-carbon",
                            Image = "https://6dsportsnutrition.com/media/catalog/product/cache/51ac8a5d408dc9e4d755285704d58e61/6/d/6dsportsnutrition.com-shop_images_2022-6d_beta-alanine_-_sr_carnosyn_-_1080x1080.png",
                            Name = "BETA alanine",
                            Price = 23.550000000000001,
                            Productnumber = "BBZ6565vZ",
                            Stock = 10
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 2,
                            Dscription = "Starlabs WP8 Myobolic 2.0 contains a precise combination of fast-release whey (concentrates, hydrolysates and isolates)",
                            Image = "https://sport-nutrition.be/web/image/product.template/6762/image_512?unique=f43c6c6",
                            Name = "WP8",
                            Price = 30.359999999999999,
                            Productnumber = "BBBZ56",
                            Stock = 33
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 2,
                            Dscription = "relieves pain and reduces inflammation and temperature as well as relieving headaches and other types of pain. It also relieves cold and flu symptoms.",
                            Image = "https://lion-corp.s3.amazonaws.com/uploads/grn/product/normal_image/436/SucrateG.png",
                            Name = "JapanCZ",
                            Price = 5.9900000000000002,
                            Productnumber = "BHEBE6",
                            Stock = 50
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 3,
                            Dscription = "Nurofen provides effective pain relief for headaches, migraines, muscular pain, joint pain, period pain and more.",
                            Image = "https://www.pharmacy.biz/wp-content/uploads/sites/1/2020/02/RB_Nurofen_STRAWBERRY_100ml_RBL1800496_0000000_FOP.jpg",
                            Name = "Neurofen for kids",
                            Price = 18.359999999999999,
                            Productnumber = "NEU4653B",
                            Stock = 55
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 3,
                            Dscription = "This medicine is an analgesic (painkiller) and an antipyretic (it reduces fever).",
                            Image = "https://www.pixelpharma.be/files/products/3734886/3734886_71b27e961230c566364a302978ea01f8_nl.jpg",
                            Name = "Dafalgan Pediaterie",
                            Price = 8.3499999999999996,
                            Productnumber = "6546BDRB",
                            Stock = 20
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 3,
                            Dscription = "This metal-powder blend consists of a steel powder formed by atomizing a steel melt and mixed with 0.3-0.7 % by wt.",
                            Image = "https://m.media-amazon.com/images/I/61NrauwGIRL._AC_SX425_.jpg",
                            Name = "Powderd blend",
                            Price = 14.85,
                            Productnumber = "151645VIT",
                            Stock = 10
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 3,
                            Dscription = "Rhinathiol Syrup is used for Bronchiectasis, Chronic obstructive pulmonary disease, Respiratory tract infections and other conditions.",
                            Image = "https://img.newpharma.net/images/products/nl/500/muco-rhinathiol-2-siroop-kinderen-diepzittende-slijmhoest-fles-200ml.2003.jpg",
                            Name = "Muco Rhinatol",
                            Price = 15.99,
                            Productnumber = "MUC63165",
                            Stock = 33
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 3,
                            Dscription = "sugar-free and sweetened with stevia, Plantil drinkable solution is a real treat! PLANTS. Plantain leaf fluid extract (Plantago lanceolata)",
                            Image = "https://files.apotheeksollie.be/cache/products/images/cache_400x400/8d4dfe8ceab63d55c4992b8965da4796cdd20d38.jpeg",
                            Name = "Plantil",
                            Price = 11.99,
                            Productnumber = "PL216C",
                            Stock = 50
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = 4,
                            Dscription = "hand with bandage on it. BANDAGES ; tapes and wraps on hand · TAPES & WRAPS ; Nexcare bandage on someone's shoulder.",
                            Image = "https://www.farmavazquez.com/80250/590494.jpg",
                            Name = "Nexcare Bandages",
                            Price = 2.9900000000000002,
                            Productnumber = "56165ZV",
                            Stock = 76
                        },
                        new
                        {
                            Id = 17,
                            CategoryId = 4,
                            Dscription = "",
                            Image = "https://assets.sainsburys-groceries.co.uk/gol/3288603/1/640x640.jpg",
                            Name = "Water resitant platsers",
                            Price = 8.3499999999999996,
                            Productnumber = "564645BG",
                            Stock = 20
                        },
                        new
                        {
                            Id = 18,
                            CategoryId = 4,
                            Dscription = "Ultralight * Improved grip * Improved elasticity * Top performance under compression * Abrasion resistant * Improved compression set (from +100° to -40°) ",
                            Image = "https://digitalcontent.api.tesco.com/v2/media/ghs/952dcead-b078-4cec-9727-3cb161434316/9b17af9e-f14f-4f9a-854d-100f778351fa_1148989823.jpeg?h=540&w=540",
                            Name = "Fabric Plasters",
                            Price = 3.4500000000000002,
                            Productnumber = "35BB65C",
                            Stock = 10
                        },
                        new
                        {
                            Id = 19,
                            CategoryId = 4,
                            Dscription = "These drugs... these are covered by insurance companies and medicare.",
                            Image = "https://www.flemingmedical.co.uk/product/image/large/md02-3%3D1_0.jpg",
                            Name = "Medicare",
                            Price = 6.9900000000000002,
                            Productnumber = "MEDI32516",
                            Stock = 33
                        },
                        new
                        {
                            Id = 20,
                            CategoryId = 4,
                            Dscription = "Salvequick Aqua Block is a thin and flexible plaster that allows the skin to breathe and is 100% waterproof at the same time.",
                            Image = "https://wwwcederrothcom.cdn.triggerfish.cloud/uploads/2020/11/6444-salvequick-textile-plaster-r.png",
                            Name = "Salvequick",
                            Price = 2.9900000000000002,
                            Productnumber = "SAL21651",
                            Stock = 50
                        },
                        new
                        {
                            Id = 21,
                            CategoryId = 5,
                            Dscription = "Cosmetic cream that is applied to the face at night.",
                            Image = "https://cdn2.shopify.com/s/files/1/0012/9669/5349/products/058469_A.png",
                            Name = "Night cream",
                            Price = 9.9900000000000002,
                            Productnumber = "NCHT3562",
                            Stock = 90
                        },
                        new
                        {
                            Id = 22,
                            CategoryId = 5,
                            Dscription = "ivea Sun provides immediate protection against sunburn, long-term skin damage and helps reduce the risk of sun allergies. ",
                            Image = "https://images-us.nivea.com/-/media/media-center-items/7/a/1/f7b2b73e509f4ec7a56cb87a8dd2f5e0-web_1010x1180_transparent_png.png",
                            Name = "Nivea sun cream",
                            Price = 29.989999999999998,
                            Productnumber = "NIV2654",
                            Stock = 20
                        },
                        new
                        {
                            Id = 23,
                            CategoryId = 5,
                            Dscription = "his is only a cosmetic issue and does not affect the functionality of the security update. How to obtain and install the update.",
                            Image = "https://media.cnn.com/api/v1/images/stellar/prod/210415112813-sustainable-beauty-brands-lead.jpg?q=w_2500,h_1406,x_0,y_0,c_fill",
                            Name = "Ila pack cosmetic",
                            Price = 59.990000000000002,
                            Productnumber = "5165SVSDV5",
                            Stock = 10
                        },
                        new
                        {
                            Id = 24,
                            CategoryId = 5,
                            Dscription = "This balm to milk creamy facial polish is gentle yet powerful thanks to finely milled rice powder and nourishing almond oil. ",
                            Image = "https://media.s-bol.com/92v6yP526n44/1095x1200.jpg",
                            Name = "IMPERIAL GLOW FACIAL POLISH",
                            Price = 25.989999999999998,
                            Productnumber = "26GZE65C",
                            Stock = 33
                        },
                        new
                        {
                            Id = 25,
                            CategoryId = 5,
                            Dscription = "Performance skincare for MEN - Combining high performance natural ingredients such as Marine Collagen, Hyaluronic Acid, Peptides...",
                            Image = "https://www.luxuryformen.com/media/catalog/product/cache/fc49963b087eb4c20dab947be5959514/f/a/face_polish_1100_x_1100.jpg",
                            Name = "Humanity Cosmetics",
                            Price = 39.990000000000002,
                            Productnumber = "464A554vV",
                            Stock = 50
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("PharmaWeb.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("PharmaWeb.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PharmaWeb.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("PharmaWeb.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PharmaWeb.Data.OrderLine", b =>
                {
                    b.HasOne("PharmaWeb.Data.Order", "Order")
                        .WithMany("OrderLines")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PharmaWeb.Data.Product", "Products")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("PharmaWeb.Data.Product", b =>
                {
                    b.HasOne("PharmaWeb.Data.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("PharmaWeb.Data.Order", b =>
                {
                    b.Navigation("OrderLines");
                });
#pragma warning restore 612, 618
        }
    }
}
