using Microsoft.EntityFrameworkCore;
using MiniSupermarket.API.Models;

namespace MiniSupermarket.API.Data
{
    // DbContext quản lý kết nối và thao tác với cơ sở dữ liệu Snack Box
    public class SupermarketDbContext : DbContext
    {
        public SupermarketDbContext(
            DbContextOptions<SupermarketDbContext> options)
            : base(options)
        {
        }

        // =========================================================
        // CÁC BẢNG DỮ LIỆU
        // =========================================================

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Customer> Customers { get; set; }


        // =========================================================
        // CẤU HÌNH DATABASE + DATA SEEDING
        // =========================================================

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //=========================================================
            // DỮ LIỆU CUSTOMER
            // =========================================================
            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    CustomerId = 1,
                    CustomerName = "Nguyễn Văn An",
                    PhoneNumber = "0901234567",
                    Address = "12 Lê Lợi, Q.1, TP.HCM",
                    RewardPoints = 150,
                    MembershipRank = "Vàng"
                },
                new Customer
                {
                    CustomerId = 2,
                    CustomerName = "Trần Thị Bình",
                    PhoneNumber = "0912345678",
                    Address = "45 Nguyễn Trãi, Q.5, TP.HCM",
                    RewardPoints = 40,
                    MembershipRank = "Bạc"
                },
                new Customer
                {
                    CustomerId = 3,
                    CustomerName = "Lê Hoàng Cường",
                    PhoneNumber = "0987654321",
                    Address = "78 CMT8, Q.3, TP.HCM",
                    RewardPoints = 0,
                    MembershipRank = "Chuẩn"
                },
                new Customer
                {
                    CustomerId = 4,
                    CustomerName = "Phạm Minh Đức",
                    PhoneNumber = "0901122334",
                    Address = "23 Hai Bà Trưng, Q.1, TP.HCM",
                    RewardPoints = 85,
                    MembershipRank = "Bạc"
                },
                new Customer
                {
                    CustomerId = 5,
                    CustomerName = "Võ Thị Hạnh",
                    PhoneNumber = "0912233445",
                    Address = "56 Phan Văn Trị, Q.5, TP.HCM",
                    RewardPoints = 210,
                    MembershipRank = "Vàng"
                },
                new Customer
                {
                    CustomerId = 6,
                    CustomerName = "Đặng Quốc Huy",
                    PhoneNumber = "0983344556",
                    Address = "89 Điện Biên Phủ, Q. Bình Thạnh, TP.HCM",
                    RewardPoints = 25,
                    MembershipRank = "Chuẩn"
                },
                new Customer
                {
                    CustomerId = 7,
                    CustomerName = "Bùi Ngọc Lan",
                    PhoneNumber = "0904455667",
                    Address = "34 Võ Văn Tần, Q.3, TP.HCM",
                    RewardPoints = 120,
                    MembershipRank = "Vàng"
                },
                new Customer
                {
                    CustomerId = 8,
                    CustomerName = "Huỳnh Thanh Nam",
                    PhoneNumber = "0915566778",
                    Address = "67 Lý Thường Kiệt, Q.10, TP.HCM",
                    RewardPoints = 60,
                    MembershipRank = "Bạc"
                },
                new Customer
                {
                    CustomerId = 9,
                    CustomerName = "Ngô Thị Mai",
                    PhoneNumber = "0986677889",
                    Address = "91 Nguyễn Văn Cừ, Q.5, TP.HCM",
                    RewardPoints = 15,
                    MembershipRank = "Chuẩn"
                },
                new Customer
                {
                    CustomerId = 10,
                    CustomerName = "Đỗ Minh Quân",
                    PhoneNumber = "0907788990",
                    Address = "15 Trường Chinh, Q. Tân Bình, TP.HCM",
                    RewardPoints = 175,
                    MembershipRank = "Vàng"
                },
                new Customer
                {
                    CustomerId = 11,
                    CustomerName = "Phan Thị Thảo",
                    PhoneNumber = "0918899001",
                    Address = "42 Nguyễn Đình Chiểu, Q.3, TP.HCM",
                    RewardPoints = 95,
                    MembershipRank = "Bạc"
                },
                new Customer
                {
                    CustomerId = 12,
                    CustomerName = "Trương Hoàng Long",
                    PhoneNumber = "0989900112",
                    Address = "76 Cộng Hòa, Q. Tân Bình, TP.HCM",
                    RewardPoints = 5,
                    MembershipRank = "Chuẩn"
                },
                new Customer
                {
                    CustomerId = 13,
                    CustomerName = "Lý Mỹ Linh",
                    PhoneNumber = "0901011223",
                    Address = "28 Nam Kỳ Khởi Nghĩa, Q.1, TP.HCM",
                    RewardPoints = 250,
                    MembershipRank = "Vàng"
                },
                new Customer
                {
                    CustomerId = 14,
                    CustomerName = "Mai Văn Khoa",
                    PhoneNumber = "0912122334",
                    Address = "53 Hoàng Văn Thụ, Q. Phú Nhuận, TP.HCM",
                    RewardPoints = 70,
                    MembershipRank = "Bạc"
                },
                new Customer
                {
                    CustomerId = 15,
                    CustomerName = "Nguyễn Thị Yến",
                    PhoneNumber = "0983233445",
                    Address = "84 Nguyễn Kiệm, Q. Gò Vấp, TP.HCM",
                    RewardPoints = 35,
                    MembershipRank = "Chuẩn"
                },
                new Customer
                {
                    CustomerId = 16,
                    CustomerName = "Phạm Tuấn Anh",
                    PhoneNumber = "0904344556",
                    Address = "19 Xô Viết Nghệ Tĩnh, Q. Bình Thạnh, TP.HCM",
                    RewardPoints = 135,
                    MembershipRank = "Vàng"
                },
                new Customer
                {
                    CustomerId = 17,
                    CustomerName = "Trần Ngọc Diệp",
                    PhoneNumber = "0915455667",
                    Address = "62 Nguyễn Oanh, Q. Gò Vấp, TP.HCM",
                    RewardPoints = 55,
                    MembershipRank = "Bạc"
                },
                new Customer
                {
                    CustomerId = 18,
                    CustomerName = "Lê Minh Tâm",
                    PhoneNumber = "0986566778",
                    Address = "37 Lạc Long Quân, Q.11, TP.HCM",
                    RewardPoints = 10,
                    MembershipRank = "Chuẩn"
                },
                new Customer
                {
                    CustomerId = 19,
                    CustomerName = "Võ Quốc Thắng",
                    PhoneNumber = "0907677889",
                    Address = "48 Nguyễn Thị Minh Khai, Q.1, TP.HCM",
                    RewardPoints = 190,
                    MembershipRank = "Vàng"
                },
                new Customer
                {
                    CustomerId = 20,
                    CustomerName = "Đặng Thị Kim",
                    PhoneNumber = "0918788990",
                    Address = "72 Tô Hiến Thành, Q.10, TP.HCM",
                    RewardPoints = 80,
                    MembershipRank = "Bạc"
                },
                new Customer
                {
                    CustomerId = 21,
                    CustomerName = "Bùi Thanh Tùng",
                    PhoneNumber = "0989899001",
                    Address = "16 Quang Trung, Q. Gò Vấp, TP.HCM",
                    RewardPoints = 20,
                    MembershipRank = "Chuẩn"
                },
                new Customer
                {
                    CustomerId = 22,
                    CustomerName = "Huỳnh Ngọc Anh",
                    PhoneNumber = "0900900112",
                    Address = "39 Pasteur, Q.1, TP.HCM",
                    RewardPoints = 160,
                    MembershipRank = "Vàng"
                },
                new Customer
                {
                    CustomerId = 23,
                    CustomerName = "Ngô Minh Châu",
                    PhoneNumber = "0911011223",
                    Address = "55 Lê Văn Sỹ, Q.3, TP.HCM",
                    RewardPoints = 45,
                    MembershipRank = "Bạc"
                }
            );

            // 

            // =====================================================
            // CATEGORY - NHÓM SẢN PHẨM SNACK BOX
            // =====================================================

            modelBuilder.Entity<Category>().HasData(

                new Category
                {
                    CategoryId = 1,
                    CategoryName = "Bánh quy tuổi thơ",
                    Description = "Các loại bánh quy quen thuộc gắn liền với tuổi thơ"
                },

                new Category
                {
                    CategoryId = 2,
                    CategoryName = "Snack",
                    Description = "Snack khoai tây, snack bắp và các loại snack giòn"
                },

                new Category
                {
                    CategoryId = 3,
                    CategoryName = "Kẹo",
                    Description = "Kẹo dẻo, kẹo cứng và các loại kẹo tuổi thơ"
                },

                new Category
                {
                    CategoryId = 4,
                    CategoryName = "Bánh xốp",
                    Description = "Bánh xốp phủ kem và bánh xốp nhiều hương vị"
                },

                new Category
                {
                    CategoryId = 5,
                    CategoryName = "Bánh que",
                    Description = "Các loại bánh que và bánh que phủ socola"
                },

                new Category
                {
                    CategoryId = 6,
                    CategoryName = "Bánh gạo",
                    Description = "Bánh gạo giòn và các sản phẩm từ gạo"
                },

                new Category
                {
                    CategoryId = 7,
                    CategoryName = "Bắp rang",
                    Description = "Bắp rang bơ và bắp rang nhiều hương vị"
                },

                new Category
                {
                    CategoryId = 8,
                    CategoryName = "Khô & Đồ sấy",
                    Description = "Cá khô, bò khô, trái cây sấy và đồ ăn khô"
                },

                new Category
                {
                    CategoryId = 9,
                    CategoryName = "Rong biển",
                    Description = "Rong biển ăn liền và snack rong biển"
                },

                new Category
                {
                    CategoryId = 10,
                    CategoryName = "Đậu phộng & Hạt",
                    Description = "Đậu phộng, hạt hướng dương và các loại hạt"
                },

                new Category
                {
                    CategoryId = 11,
                    CategoryName = "Mì ăn liền",
                    Description = "Mì gói và mì ly ăn liền"
                },

                new Category
                {
                    CategoryId = 12,
                    CategoryName = "Xúc xích",
                    Description = "Xúc xích ăn liền và xúc xích tiệt trùng"
                },

                new Category
                {
                    CategoryId = 13,
                    CategoryName = "Cá viên & Đồ chiên",
                    Description = "Các món ăn vặt chế biến sẵn"
                },

                new Category
                {
                    CategoryId = 14,
                    CategoryName = "Bánh mì",
                    Description = "Bánh mì sandwich và bánh mì ăn sáng"
                },

                new Category
                {
                    CategoryId = 15,
                    CategoryName = "Bánh ngọt",
                    Description = "Bánh bông lan, bánh kem và bánh ngọt"
                },

                new Category
                {
                    CategoryId = 16,
                    CategoryName = "Socola",
                    Description = "Socola thanh, socola viên và kẹo socola"
                },

                new Category
                {
                    CategoryId = 17,
                    CategoryName = "Kem",
                    Description = "Kem cây và kem hộp"
                },

                new Category
                {
                    CategoryId = 18,
                    CategoryName = "Nước ngọt",
                    Description = "Coca Cola, Pepsi, 7Up và các loại nước ngọt"
                },

                new Category
                {
                    CategoryId = 19,
                    CategoryName = "Trà đóng chai",
                    Description = "Trà xanh, trà đào và trà trái cây"
                },

                new Category
                {
                    CategoryId = 20,
                    CategoryName = "Nước trái cây",
                    Description = "Nước cam, nước táo và các loại nước trái cây"
                },

                new Category
                {
                    CategoryId = 21,
                    CategoryName = "Sữa",
                    Description = "Sữa hộp và các sản phẩm từ sữa"
                },

                new Category
                {
                    CategoryId = 22,
                    CategoryName = "Nước tăng lực",
                    Description = "Các loại nước tăng lực"
                },

                new Category
                {
                    CategoryId = 23,
                    CategoryName = "Combo Snack Box",
                    Description = "Combo nhiều món ăn vặt dành cho khách hàng"
                },

                new Category
                {
                    CategoryId = 24,
                    CategoryName = "Đồ ăn vặt tuổi thơ",
                    Description = "Các món ăn vặt quen thuộc của thế hệ 8x, 9x"
                },

                new Category
                {
                    CategoryId = 25,
                    CategoryName = "Sản phẩm đặc biệt",
                    Description = "Các sản phẩm mới và sản phẩm bán theo mùa"
                }
            );


            // =====================================================
            // CUSTOMER - GIÁ TRỊ MẶC ĐỊNH
            // =====================================================

            modelBuilder.Entity<Customer>()
                .Property(c => c.RewardPoints)
                .HasDefaultValue(0);

            modelBuilder.Entity<Customer>()
                .Property(c => c.MembershipRank)
                .HasDefaultValue("Chuẩn");


            // =====================================================
            // PRODUCT - DỮ LIỆU MẪU
            // LƯU Ý:
            // Dùng StockQuantity, KHÔNG dùng Quantity
            // =====================================================

            modelBuilder.Entity<Product>().HasData(

                // =================================================
                // CATEGORY 1 - BÁNH QUY
                // =================================================

                new Product
                {
                    ProductId = 1,
                    Barcode = "893100100001",
                    ProductName = "Bánh Oreo vị socola 133g",
                    Price = 18000,
                    StockQuantity = 50,
                    CategoryId = 1
                },

                new Product
                {
                    ProductId = 2,
                    Barcode = "893100100002",
                    ProductName = "Bánh quy Cosy Marie 300g",
                    Price = 35000,
                    StockQuantity = 40,
                    CategoryId = 1
                },


                // =================================================
                // CATEGORY 2 - SNACK
                // =================================================

                new Product
                {
                    ProductId = 3,
                    Barcode = "893100100003",
                    ProductName = "Snack khoai tây Lays 68g",
                    Price = 15000,
                    StockQuantity = 80,
                    CategoryId = 2
                },

                new Product
                {
                    ProductId = 4,
                    Barcode = "893100100004",
                    ProductName = "Snack Oishi tôm cay 75g",
                    Price = 12000,
                    StockQuantity = 100,
                    CategoryId = 2
                },


                // =================================================
                // CATEGORY 3 - KẸO
                // =================================================

                new Product
                {
                    ProductId = 5,
                    Barcode = "893100100005",
                    ProductName = "Kẹo dẻo Chupa Chups",
                    Price = 10000,
                    StockQuantity = 70,
                    CategoryId = 3
                },

                new Product
                {
                    ProductId = 6,
                    Barcode = "893100100006",
                    ProductName = "Kẹo Dynamite vị bạc hà",
                    Price = 8000,
                    StockQuantity = 90,
                    CategoryId = 3
                },


                // =================================================
                // CATEGORY 4 - BÁNH XỐP
                // =================================================

                new Product
                {
                    ProductId = 7,
                    Barcode = "893100100007",
                    ProductName = "Bánh xốp kem socola",
                    Price = 12000,
                    StockQuantity = 60,
                    CategoryId = 4
                },

                new Product
                {
                    ProductId = 8,
                    Barcode = "893100100008",
                    ProductName = "Bánh xốp kem dâu",
                    Price = 12000,
                    StockQuantity = 60,
                    CategoryId = 4
                },


                // =================================================
                // CATEGORY 5 - BÁNH QUE
                // =================================================

                new Product
                {
                    ProductId = 9,
                    Barcode = "893100100009",
                    ProductName = "Bánh que socola",
                    Price = 15000,
                    StockQuantity = 70,
                    CategoryId = 5
                },

                new Product
                {
                    ProductId = 10,
                    Barcode = "893100100010",
                    ProductName = "Bánh que phô mai",
                    Price = 15000,
                    StockQuantity = 60,
                    CategoryId = 5
                },


                // =================================================
                // CATEGORY 6 - BÁNH GẠO
                // =================================================

                new Product
                {
                    ProductId = 11,
                    Barcode = "893100100011",
                    ProductName = "Bánh gạo One One vị ngọt",
                    Price = 18000,
                    StockQuantity = 50,
                    CategoryId = 6
                },

                new Product
                {
                    ProductId = 12,
                    Barcode = "893100100012",
                    ProductName = "Bánh gạo cay",
                    Price = 20000,
                    StockQuantity = 45,
                    CategoryId = 6
                },


                // =================================================
                // CATEGORY 7 - BẮP RANG
                // =================================================

                new Product
                {
                    ProductId = 13,
                    Barcode = "893100100013",
                    ProductName = "Bắp rang bơ",
                    Price = 25000,
                    StockQuantity = 40,
                    CategoryId = 7
                },

                new Product
                {
                    ProductId = 14,
                    Barcode = "893100100014",
                    ProductName = "Bắp rang caramel",
                    Price = 28000,
                    StockQuantity = 40,
                    CategoryId = 7
                },


                // =================================================
                // CATEGORY 8 - KHÔ & ĐỒ SẤY
                // =================================================

                new Product
                {
                    ProductId = 15,
                    Barcode = "893100100015",
                    ProductName = "Khô bò sợi 50g",
                    Price = 45000,
                    StockQuantity = 35,
                    CategoryId = 8
                },

                new Product
                {
                    ProductId = 16,
                    Barcode = "893100100016",
                    ProductName = "Xoài sấy dẻo 100g",
                    Price = 35000,
                    StockQuantity = 40,
                    CategoryId = 8
                },


                // =================================================
                // CATEGORY 9 - RONG BIỂN
                // =================================================

                new Product
                {
                    ProductId = 17,
                    Barcode = "893100100017",
                    ProductName = "Rong biển ăn liền Tao Kae Noi",
                    Price = 25000,
                    StockQuantity = 50,
                    CategoryId = 9
                },

                new Product
                {
                    ProductId = 18,
                    Barcode = "893100100018",
                    ProductName = "Snack rong biển vị truyền thống",
                    Price = 18000,
                    StockQuantity = 60,
                    CategoryId = 9
                },


                // =================================================
                // CATEGORY 10 - ĐẬU PHỘNG & HẠT
                // =================================================

                new Product
                {
                    ProductId = 19,
                    Barcode = "893100100019",
                    ProductName = "Đậu phộng da cá 100g",
                    Price = 20000,
                    StockQuantity = 50,
                    CategoryId = 10
                },

                new Product
                {
                    ProductId = 20,
                    Barcode = "893100100020",
                    ProductName = "Hạt hướng dương vị truyền thống",
                    Price = 15000,
                    StockQuantity = 60,
                    CategoryId = 10
                },


                // =================================================
                // CATEGORY 11 - MÌ ĂN LIỀN
                // =================================================

                new Product
                {
                    ProductId = 21,
                    Barcode = "893100100021",
                    ProductName = "Mì Hảo Hảo tôm chua cay",
                    Price = 5000,
                    StockQuantity = 200,
                    CategoryId = 11
                },

                new Product
                {
                    ProductId = 22,
                    Barcode = "893100100022",
                    ProductName = "Mì Omachi sườn hầm ngũ quả",
                    Price = 10000,
                    StockQuantity = 100,
                    CategoryId = 11
                },


                // =================================================
                // CATEGORY 12 - XÚC XÍCH
                // =================================================

                new Product
                {
                    ProductId = 23,
                    Barcode = "893100100023",
                    ProductName = "Xúc xích tiệt trùng Vissan",
                    Price = 32000,
                    StockQuantity = 70,
                    CategoryId = 12
                },

                new Product
                {
                    ProductId = 24,
                    Barcode = "893100100024",
                    ProductName = "Xúc xích phô mai",
                    Price = 35000,
                    StockQuantity = 50,
                    CategoryId = 12
                },


                // =================================================
                // CATEGORY 13 - CÁ VIÊN & ĐỒ CHIÊN
                // =================================================

                new Product
                {
                    ProductId = 25,
                    Barcode = "893100100025",
                    ProductName = "Cá viên chiên 500g",
                    Price = 45000,
                    StockQuantity = 50,
                    CategoryId = 13
                },

                new Product
                {
                    ProductId = 26,
                    Barcode = "893100100026",
                    ProductName = "Bò viên 500g",
                    Price = 55000,
                    StockQuantity = 40,
                    CategoryId = 13
                },


                // =================================================
                // CATEGORY 14 - BÁNH MÌ
                // =================================================

                new Product
                {
                    ProductId = 27,
                    Barcode = "893100100027",
                    ProductName = "Bánh mì sandwich 400g",
                    Price = 28000,
                    StockQuantity = 40,
                    CategoryId = 14
                },

                new Product
                {
                    ProductId = 28,
                    Barcode = "893100100028",
                    ProductName = "Bánh mì ngọt nhân kem",
                    Price = 15000,
                    StockQuantity = 50,
                    CategoryId = 14
                },


                // =================================================
                // CATEGORY 15 - BÁNH NGỌT
                // =================================================

                new Product
                {
                    ProductId = 29,
                    Barcode = "893100100029",
                    ProductName = "Bánh bông lan kem 300g",
                    Price = 45000,
                    StockQuantity = 35,
                    CategoryId = 15
                },

                new Product
                {
                    ProductId = 30,
                    Barcode = "893100100030",
                    ProductName = "Bánh bông lan cuộn",
                    Price = 30000,
                    StockQuantity = 40,
                    CategoryId = 15
                },


                // =================================================
                // CATEGORY 16 - SOCOLA
                // =================================================

                new Product
                {
                    ProductId = 31,
                    Barcode = "893100100031",
                    ProductName = "Socola thanh KitKat",
                    Price = 25000,
                    StockQuantity = 50,
                    CategoryId = 16
                },

                new Product
                {
                    ProductId = 32,
                    Barcode = "893100100032",
                    ProductName = "Socola thanh Hershey's",
                    Price = 35000,
                    StockQuantity = 40,
                    CategoryId = 16
                },


                // =================================================
                // CATEGORY 17 - KEM
                // =================================================

                new Product
                {
                    ProductId = 33,
                    Barcode = "893100100033",
                    ProductName = "Kem Merino socola",
                    Price = 12000,
                    StockQuantity = 80,
                    CategoryId = 17
                },

                new Product
                {
                    ProductId = 34,
                    Barcode = "893100100034",
                    ProductName = "Kem Celano vani",
                    Price = 15000,
                    StockQuantity = 70,
                    CategoryId = 17
                },


                // =================================================
                // CATEGORY 18 - NƯỚC NGỌT
                // =================================================

                new Product
                {
                    ProductId = 35,
                    Barcode = "893100100035",
                    ProductName = "Coca Cola lon 330ml",
                    Price = 10000,
                    StockQuantity = 100,
                    CategoryId = 18
                },

                new Product
                {
                    ProductId = 36,
                    Barcode = "893100100036",
                    ProductName = "Pepsi lon 330ml",
                    Price = 10000,
                    StockQuantity = 100,
                    CategoryId = 18
                },


                // =================================================
                // CATEGORY 19 - TRÀ ĐÓNG CHAI
                // =================================================

                new Product
                {
                    ProductId = 37,
                    Barcode = "893100100037",
                    ProductName = "Trà xanh C2 455ml",
                    Price = 10000,
                    StockQuantity = 90,
                    CategoryId = 19
                },

                new Product
                {
                    ProductId = 38,
                    Barcode = "893100100038",
                    ProductName = "Trà đào Tea+ 455ml",
                    Price = 12000,
                    StockQuantity = 80,
                    CategoryId = 19
                },


                // =================================================
                // CATEGORY 20 - NƯỚC TRÁI CÂY
                // =================================================

                new Product
                {
                    ProductId = 39,
                    Barcode = "893100100039",
                    ProductName = "Nước cam Twister 455ml",
                    Price = 12000,
                    StockQuantity = 80,
                    CategoryId = 20
                },

                new Product
                {
                    ProductId = 40,
                    Barcode = "893100100040",
                    ProductName = "Nước táo 455ml",
                    Price = 12000,
                    StockQuantity = 70,
                    CategoryId = 20
                },


                // =================================================
                // CATEGORY 21 - SỮA
                // =================================================

                new Product
                {
                    ProductId = 41,
                    Barcode = "893100100041",
                    ProductName = "Sữa tươi Vinamilk 180ml",
                    Price = 8000,
                    StockQuantity = 100,
                    CategoryId = 21
                },

                new Product
                {
                    ProductId = 42,
                    Barcode = "893100100042",
                    ProductName = "Sữa chocolate hộp 180ml",
                    Price = 9000,
                    StockQuantity = 90,
                    CategoryId = 21
                },


                // =================================================
                // CATEGORY 22 - NƯỚC TĂNG LỰC
                // =================================================

                new Product
                {
                    ProductId = 43,
                    Barcode = "893100100043",
                    ProductName = "Red Bull 250ml",
                    Price = 12000,
                    StockQuantity = 100,
                    CategoryId = 22
                },

                new Product
                {
                    ProductId = 44,
                    Barcode = "893100100044",
                    ProductName = "Sting dâu 330ml",
                    Price = 10000,
                    StockQuantity = 100,
                    CategoryId = 22
                },


                // =================================================
                // CATEGORY 23 - COMBO SNACK BOX
                // =================================================

                new Product
                {
                    ProductId = 45,
                    Barcode = "893100100045",
                    ProductName = "Combo Snack Box Mini",
                    Price = 50000,
                    StockQuantity = 30,
                    CategoryId = 23
                },

                new Product
                {
                    ProductId = 46,
                    Barcode = "893100100046",
                    ProductName = "Combo Snack Box Tuổi Thơ",
                    Price = 100000,
                    StockQuantity = 25,
                    CategoryId = 23
                },


                // =================================================
                // CATEGORY 24 - ĐỒ ĂN VẶT TUỔI THƠ
                // =================================================

                new Product
                {
                    ProductId = 47,
                    Barcode = "893100100047",
                    ProductName = "Kẹo kéo tuổi thơ",
                    Price = 5000,
                    StockQuantity = 100,
                    CategoryId = 24
                },

                new Product
                {
                    ProductId = 48,
                    Barcode = "893100100048",
                    ProductName = "Bánh đồng tiền tuổi thơ",
                    Price = 10000,
                    StockQuantity = 80,
                    CategoryId = 24
                },


                // =================================================
                // CATEGORY 25 - SẢN PHẨM ĐẶC BIỆT
                // =================================================

                new Product
                {
                    ProductId = 49,
                    Barcode = "893100100049",
                    ProductName = "Hộp quà Snack Box đặc biệt",
                    Price = 150000,
                    StockQuantity = 20,
                    CategoryId = 25
                },

                new Product
                {
                    ProductId = 50,
                    Barcode = "893100100050",
                    ProductName = "Combo Party Snack Box",
                    Price = 200000,
                    StockQuantity = 15,
                    CategoryId = 25
                }
            );
        }
    }
}
