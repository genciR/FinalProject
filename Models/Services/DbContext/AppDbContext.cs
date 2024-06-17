using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Smartphone_Shop.Models.Entities;
using System;
using System.Collections.Generic;

namespace Smartphone_Shop.Models
{
    public class AppDbContext : IdentityDbContext<CustomUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        //_dbContext.Phone.Where(x => x.Brand == "Samsung").SortBy(x => x.name).ToList();
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Cpu> Cpu { get; set; }
        public DbSet<Color> Color { get; set; }
        public DbSet<DisplayType> DisplayType { get; set; }
        public DbSet<SimType> SimType { get; set; }
        public DbSet<UsbType> UsbType { get; set; }
        public DbSet<OpSystem> OpSystem { get; set; }
        public DbSet<Phone> Phone { get; set; } 
        public DbSet<CustomUser> CustomUsers { get; set; }  
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }  


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Creating brands
            modelBuilder.Entity<Brand>().HasData(new Brand { Id = 1, Name = "Apple" });
            modelBuilder.Entity<Brand>().HasData(new Brand { Id = 2, Name = "Samsung" });
            modelBuilder.Entity<Brand>().HasData(new Brand { Id = 3, Name = "Xiaomi" });
            modelBuilder.Entity<Brand>().HasData(new Brand { Id = 4, Name = "Poco" });
            modelBuilder.Entity<Brand>().HasData(new Brand { Id = 5, Name = "Nokia" });
            modelBuilder.Entity<Brand>().HasData(new Brand { Id = 6, Name = "Alcatel" });

            //Creating colors
            modelBuilder.Entity<Color>().HasData(new Color { Id = 1, Name = "White" });
            modelBuilder.Entity<Color>().HasData(new Color { Id = 2, Name = "Gray" });
            modelBuilder.Entity<Color>().HasData(new Color { Id = 3, Name = "Black" });
            modelBuilder.Entity<Color>().HasData(new Color { Id = 4, Name = "Blue" });
            modelBuilder.Entity<Color>().HasData(new Color { Id = 5, Name = "Red" });
            modelBuilder.Entity<Color>().HasData(new Color { Id = 6, Name = "Purple" });

            //Creating CPUs
            modelBuilder.Entity<Cpu>().HasData(new Cpu
            { 
                Id = 1, 
                ModelName = "Snapdragon 8 Gen 1", 
                NumOfCores = 8, 
                Frequency = 3, 
                GraphicsChip = "Adreno 730", 
                ManProcess = 4
            });
            modelBuilder.Entity<Cpu>().HasData(new Cpu
            {
                Id = 2,
                ModelName = "Snapdragon 888",
                NumOfCores = 8,
                Frequency = 2.8,
                GraphicsChip = "Adreno 660",
                ManProcess = 5
            });
            modelBuilder.Entity<Cpu>().HasData(new Cpu
            {
                Id = 3,
                ModelName = "Snapdragon 695 5G",
                NumOfCores = 8,
                Frequency = 2.2,
                GraphicsChip = "Adreno 619",
                ManProcess = 6
            });
            modelBuilder.Entity<Cpu>().HasData(new Cpu
            {
                Id = 4,
                ModelName = "Snapdragon 860",
                NumOfCores = 8,
                Frequency = 2.9,
                GraphicsChip = "Adreno 640",
                ManProcess = 7
            });
            modelBuilder.Entity<Cpu>().HasData(new Cpu
            {
                Id = 5,
                ModelName = "Apple A14 Bionic",
                NumOfCores = 6,
                Frequency = 3.1,
                GraphicsChip = "4-core Apple A14 GPU",
                ManProcess = 5
            });
            modelBuilder.Entity<Cpu>().HasData(new Cpu
            {
                Id = 6,
                ModelName = "Apple A15 Bionic",
                NumOfCores = 4,
                Frequency = 3.2,
                GraphicsChip = "5-core Apple A15 GPU",
                ManProcess = 5
            });
            modelBuilder.Entity<Cpu>().HasData(new Cpu
            {
                Id = 7,
                ModelName = "Snapdragon 439",
                NumOfCores = 8,
                Frequency = 1.95,
                GraphicsChip = "Adreno 505",
                ManProcess = 12
            });
            modelBuilder.Entity<Cpu>().HasData(new Cpu
            {
                Id = 8,
                ModelName = "Helio G25",
                NumOfCores = 8,
                Frequency = 2.0,
                GraphicsChip = "PowerVR GE8320",
                ManProcess = 12
            });
            modelBuilder.Entity<Cpu>().HasData(new Cpu
            {
                Id = 9,
                ModelName = "Snapdragon 678",
                NumOfCores = 8,
                Frequency = 2.2,
                GraphicsChip = "Qualcomm Adreno 615",
                ManProcess = 11
            });
            modelBuilder.Entity<Cpu>().HasData(new Cpu
            {
                Id = 10,
                ModelName = "Snapdragon 778 5G",
                NumOfCores = 8,
                Frequency = 2.4,
                GraphicsChip = "Adreno 642L",
                ManProcess = 6
            });


            //Creating display types
            modelBuilder.Entity<DisplayType>().HasData(new DisplayType { Id = 1, Name = "Amoled" });
            modelBuilder.Entity<DisplayType>().HasData(new DisplayType { Id = 2, Name = "LCD" });
            modelBuilder.Entity<DisplayType>().HasData(new DisplayType { Id = 3, Name = "Super Retina XDR" });
            modelBuilder.Entity<DisplayType>().HasData(new DisplayType { Id = 4, Name = "Super Retina" });

            //Creating SIM types
            modelBuilder.Entity<SimType>().HasData(new SimType { Id = 1, Name = "Standard" });
            modelBuilder.Entity<SimType>().HasData(new SimType { Id = 2, Name = "Micro SIM" });
            modelBuilder.Entity<SimType>().HasData(new SimType { Id = 3, Name = "Nano SIM" });

            //Creating USB types
            modelBuilder.Entity<UsbType>().HasData(new UsbType { Id = 1, Name = "USB Type A" });
            modelBuilder.Entity<UsbType>().HasData(new UsbType { Id = 2, Name = "USB Type B" });
            modelBuilder.Entity<UsbType>().HasData(new UsbType { Id = 3, Name = "USB Type C" });
            modelBuilder.Entity<UsbType>().HasData(new UsbType { Id = 4, Name = "Lightning" });

            //Creating operating systems
            modelBuilder.Entity<OpSystem>().HasData(new OpSystem { Id = 1, Name = "Android" });
            modelBuilder.Entity<OpSystem>().HasData(new OpSystem { Id = 2, Name = "iOS" });

            //Creating phones
            modelBuilder.Entity<Phone>().HasData(new Phone
            {
                Id = 1,
                BrandId = 2,
                ModelName = "Galaxy S22",
                Description = "he Samsung Galaxy S22 specs are top-notch including a Snapdragon 8 Gen 1 chipset, 8GB RAM coupled with 128/256GB storage, and a 3700mAh battery with 25W charging speed. The phone sports a 6.1-inch Dynamic AMOLED display with an adaptive 120Hz refresh rate.",
                ImageUrl = "https://fscl01.fonpit.de/devices/23/2223.png",
                DisplayRes = "2160 X 1440",
                DisplayRatio = "19.5:9",
                CpuId = 4,
                Ram = 8,
                Battery = 5500,
                Storage = 256,
                ColorId = 3,
                DisplayTypeId = 1,
                DisplaySize = 6.1,
                OpSystemId = 1,
                SimTypeId = 3,
                UsbTypeId = 3,
                Camera = "Back: Quad 108mpx 20mpx 20mpx 16mpx, Selfie: Dual 40mpx 16mpx",
                Weight =  280,
                ReleaseDate = DateTime.Parse("2021-10-21"),
                Price = 800,
                HotOffer = true
            });
            modelBuilder.Entity<Phone>().HasData(new Phone
            {
                Id = 2,
                BrandId = 4,
                ModelName = "X3 Pro",
                Description = "The POCO X3 Pro specs offer powerful and versatile smartphone that is perfect for any gadget enthusiast.",
                ImageUrl = "https://cdn.homeshopping.pk/product_images/g/626/Product-Images---600x600---x3-pro-01_da6f3438-a2ce-4839-93aa-40ebed377067_grande__46137_zoom.png",
                DisplayRes = "2400 X 1800",
                DisplayRatio = "20:9",
                CpuId = 3,
                Ram = 8,
                Battery = 5160,
                Storage = 128,
                ColorId = 2,
                DisplayTypeId = 1,
                DisplaySize = 6.7,
                OpSystemId = 1,
                SimTypeId = 3,
                UsbTypeId = 3,
                Camera = "Back: Quad 48mpx 8mpx 2mpx 2mpx, Selfie: Single 20mpx",
                Weight = 280,
                ReleaseDate = DateTime.Parse("2021-3-24"),
                Price = 250,
                HotOffer = false
            });
            modelBuilder.Entity<Phone>().HasData(new Phone
            {
                Id = 3,
                BrandId = 6,
                ModelName = "3 (2019)",
                Description = "Alcatel 3(2019) powerful core, Snapdragon chipset, long-lasting battery and radiant design, Alcatel 3 has both style and substance.",
                ImageUrl = "https://www.alcatelmobile.com/eu/wp-content/uploads/2019/06/alcatel_product-details_alcatel3_black.png",
                DisplayRes = "1560 X 720",
                DisplayRatio = "19.5:9",
                CpuId = 7,
                Ram = 3,
                Battery = 3500,
                Storage = 32,
                ColorId = 4,
                DisplayTypeId = 2,
                DisplaySize = 5.94,
                OpSystemId = 1,
                SimTypeId = 3,
                UsbTypeId = 2,
                Camera = "Back: Dual 13mpx 5mpx, Selfie: Single 8mpx",
                Weight = 145,
                ReleaseDate = DateTime.Parse("2019-6-12"),
                Price = 160,
                HotOffer = false
            });
            modelBuilder.Entity<Phone>().HasData(new Phone
            {
                Id = 4,
                BrandId = 5,
                ModelName = "G10",
                Description = "Nokia G10 Android smartphone. Announced Apr 2021. Features 6.52″ display, MediaTek MT6762G Helio G25 chipset, 5050 mAh battery, 64 GB storage, 4 GB RAM.",
                ImageUrl = "https://media.croma.com/image/upload/v1657894463/Croma%20Assets/Communication/Mobiles/Images/258404_9_l5jfzl.png",
                DisplayRes = "1600 X 720",
                DisplayRatio = "20:9",
                CpuId = 8,
                Ram = 3,
                Battery = 5050,
                Storage = 32,
                ColorId = 6,
                DisplayTypeId = 2,
                DisplaySize = 6.52,
                OpSystemId = 1,
                SimTypeId = 3,
                UsbTypeId = 3,
                Camera = "Back: Triple 13mpx 2mpx 2mpx, Selfie: Single 8mpx",
                Weight = 194,
                ReleaseDate = DateTime.Parse("2021-4-26"),
                Price = 130,
                HotOffer = false
            });
            modelBuilder.Entity<Phone>().HasData(new Phone
            {
                Id = 5,
                BrandId = 4,
                ModelName = "X4 Pro 5g",
                Description = "POCO X4 Pro 5G features a 6.67-inch 120Hz FHD+ AMOLED Display, 108MP triple camera, 67W turbocharging, and High-performance Snapdragon® 5G processor.",
                ImageUrl = "https://i01.appmifile.com/webfile/globalimg/Iris/poco-x4-pro-5g-blue!800x800!85.png",
                DisplayRes = "2400 X 1080",
                DisplayRatio = "20:9",
                CpuId = 3,
                Ram = 6,
                Battery = 5000,
                Storage = 64,
                ColorId = 4,
                DisplayTypeId = 1,
                DisplaySize = 6.67,
                OpSystemId = 1,
                SimTypeId = 3,
                UsbTypeId = 3,
                Camera = "Back: Quad 108mpx 64mpx 8mpx 2mpx, Selfie: Single 16mpx",
                Weight = 205,
                ReleaseDate = DateTime.Parse("2022-3-23"),
                Price = 280,
                HotOffer = false
            });
            modelBuilder.Entity<Phone>().HasData(new Phone
            {
                Id = 6,
                BrandId = 3,
                ModelName = "Redmi Note 10",
                Description = "Redmi Note 10 is equipped with a new 6.43 AMOLED display,Qualcomm® Snapdragon™ 678 processor,5000mAh (typ) battery,33W fast charger.",
                ImageUrl = "https://static.ananas.rs/assets/Product_Images/Smartphones/xiaomi_redmi_note_10_16_3_cm_6_43_dve_sim_kartice_android_11_4g_usb_tipa_c_4_gb_128_gb_5000_mah_sivo/3506c52e36560108.png",
                DisplayRes = "2400 X 1080",
                DisplayRatio = "20:9",
                CpuId = 8,
                Ram = 4,
                Battery = 5000,
                Storage = 64,
                ColorId = 4,
                DisplayTypeId = 1,
                DisplaySize = 6.43,
                OpSystemId = 1,
                SimTypeId = 3,
                UsbTypeId = 3,
                Camera = "Back: Quad 48mpx 8mpx 2mpx 2mpx, Selfie: Single 13mpx",
                Weight = 178,
                ReleaseDate = DateTime.Parse("2021-3-16"),
                Price = 210,
                HotOffer = false
            });
            modelBuilder.Entity<Phone>().HasData(new Phone
            {
                Id = 7,
                BrandId = 1,
                ModelName = "iPhone 12",
                Description = "The iPhone 12 features a 6.1-inch (15 cm) display with Super Retina XDR OLED technology at a resolution of 2532 × 1170 pixels and a pixel density of about 460 ppi.",
                ImageUrl = "https://www.futuretelecoms.co.za/wp-content/uploads/2020/11/iPhone-12-Blue.png",
                DisplayRes = "2532 X 1170",
                DisplayRatio = "19.5:9",
                CpuId = 7,
                Ram = 4,
                Battery = 2815,
                Storage = 64,
                ColorId = 4,
                DisplayTypeId = 3,
                DisplaySize = 6.1,
                OpSystemId = 2,
                SimTypeId = 3,
                UsbTypeId = 3,
                Camera = "Back: Dual 12mpx 12mpx, Selfie: Single 12mpx",
                Weight = 164,
                ReleaseDate = DateTime.Parse("2020-10-23"),
                Price = 700,
                HotOffer = true
            });
            modelBuilder.Entity<Phone>().HasData(new Phone
            {
                Id = 8,
                BrandId = 2,
                ModelName = "Galaxy A52s 5G",
                Description = "Meet the Samsung Galaxy A52s 5G with its 6.5 inch AMOLED display, multiple cameras and long - lasting battery. Plus, it's IP67 rated water & dust resistant.",
                ImageUrl = "https://img.genial.ly/604b4ccbe40c2b0f76cf0feb/280fd528-970a-40ac-bba4-64b7941d1649.png",
                DisplayRes = "2400 X 1080",
                DisplayRatio = "20:9",
                CpuId = 6,
                Ram = 6,
                Battery = 4500,
                Storage = 128,
                ColorId = 3,
                DisplayTypeId = 1,
                DisplaySize = 6.5,
                OpSystemId = 1,
                SimTypeId = 3,
                UsbTypeId = 3,
                Camera = "Back: Quad 64mpx 12mpx 5mpx 5mp, Selfie: Single 32 mpx",
                Weight = 189,
                ReleaseDate = DateTime.Parse("2021-1-9"),
                Price = 300,
                HotOffer = false
            });
            modelBuilder.Entity<Phone>().HasData(new Phone
            {
                Id = 9,
                BrandId = 2,
                ModelName = "Galaxy S21 FE",
                Description = "The Samsung Galaxy S22 specs are top-notch including a Snapdragon 8 Gen 1 chipset, 8GB RAM coupled with 128/256GB storage, and a 3700mAh battery with 25W charging speed. The phone sports a 6.1-inch Dynamic AMOLED display with an adaptive 120Hz refresh rate.",
                ImageUrl = "https://img.global.news.samsung.com/in/wp-content/uploads/2022/01/SM-G990_S21FE_BackFront_ZW.png",
                DisplayRes = "2160 X 1440",
                DisplayRatio = "19.5:9",
                CpuId = 4,
                Ram = 8,
                Battery = 5500,
                Storage = 256,
                ColorId = 3,
                DisplayTypeId = 1,
                DisplaySize = 6.1,
                OpSystemId = 1,
                SimTypeId = 3,
                UsbTypeId = 3,
                Camera = "Back: Quad 108mpx 20mpx 20mpx 16mpx, Selfie: Dual 40mpx 16mpx",
                Weight = 280,
                ReleaseDate = DateTime.Parse("2021-10-21"),
                Price = 600,
                HotOffer = true
            });





            var hasher = new PasswordHasher<CustomUser>();
            var password = "SmartShop22!";

            var users = new List<CustomUser>()
            {
                new CustomUser()
                {
                    Id = "44a56b6a-75da-468e-96ab-69b87f29d825",
                    FirstName = "Marko",
                    LastName = "Obradovic",
                    UserName = "markoAdmin@gmail.com",
                    NormalizedUserName = "MARKOADMIN@GMAIL.COM",
                    Email = "markoAdmin@gmail.com",
                    NormalizedEmail = "MARKOADMIN@GMAIL.COM",
                    EmailConfirmed = false,
                    PasswordHash = hasher.HashPassword(null, password),
                },

                new CustomUser()
                {
                    Id = "239ae39d-cd95-4b0e-a245-799df01f3519",
                    FirstName = "Petar",
                    LastName = "Petrovic",
                    UserName = "peraUser@gmail.com",
                    NormalizedUserName = "PERAUSER@GMAIL.COM",
                    Email = "peraUser@gmail.com",
                    NormalizedEmail = "PERAUSER@GMAIL.COM",
                    EmailConfirmed = false,
                    PasswordHash = hasher.HashPassword(null, password),
                }
            };

            var roles = new List<IdentityRole>()
            {
                new IdentityRole
                {
                    Id = "8ffe0bc0-1a2d-411f-8ad3-a5ba3fa5942c",
                    Name = "Admin",
                    NormalizedName = "ADMIN",
                    ConcurrencyStamp = "9c4cb918-9be8-41fd-bb7a-40b75aebc037"
                },

                new IdentityRole
                {
                    Id = "a6a0a663-c119-48cf-b4f6-6fb24b9d5035",
                    Name = "Customer",
                    NormalizedName = "CUSTOMER",
                    ConcurrencyStamp = "89891c77-9ac3-4e52-bf51-a15e012463f1"
                }
            };

            var userRoles = new List<IdentityUserRole<string>>()
            {
                new IdentityUserRole<string>
                {
                    RoleId = "8ffe0bc0-1a2d-411f-8ad3-a5ba3fa5942c",
                    UserId = "44a56b6a-75da-468e-96ab-69b87f29d825"
                },

                new IdentityUserRole<string>
                {
                    RoleId = "a6a0a663-c119-48cf-b4f6-6fb24b9d5035",
                    UserId = "239ae39d-cd95-4b0e-a245-799df01f3519"
                }
            };

           
            modelBuilder.Entity<CustomUser>().HasData(users);
            modelBuilder.Entity<IdentityRole>().HasData(roles);
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(userRoles);
        }
    }
}
