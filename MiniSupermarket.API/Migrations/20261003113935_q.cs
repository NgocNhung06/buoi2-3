using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MiniSupermarket.API.Migrations
{
    /// <inheritdoc />
    public partial class q : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 23);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Bánh quy tuổi thơ", "Các loại bánh quy quen thuộc gắn liền với tuổi thơ" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Snack", "Snack khoai tây, snack bắp và các loại snack giòn" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Kẹo", "Kẹo dẻo, kẹo cứng và các loại kẹo tuổi thơ" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Bánh xốp", "Bánh xốp phủ kem và bánh xốp nhiều hương vị" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Bánh que", "Các loại bánh que và bánh que phủ socola" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Bánh gạo", "Bánh gạo giòn và các sản phẩm từ gạo" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Bắp rang", "Bắp rang bơ và bắp rang nhiều hương vị" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Khô & Đồ sấy", "Cá khô, bò khô, trái cây sấy và đồ ăn khô" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 9,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Rong biển", "Rong biển ăn liền và snack rong biển" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 10,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Đậu phộng & Hạt", "Đậu phộng, hạt hướng dương và các loại hạt" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 11,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Mì ăn liền", "Mì gói và mì ly ăn liền" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 12,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Xúc xích", "Xúc xích ăn liền và xúc xích tiệt trùng" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 13,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Cá viên & Đồ chiên", "Các món ăn vặt chế biến sẵn" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 14,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Bánh mì", "Bánh mì sandwich và bánh mì ăn sáng" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 15,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Bánh ngọt", "Bánh bông lan, bánh kem và bánh ngọt" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 16,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Socola", "Socola thanh, socola viên và kẹo socola" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 17,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Kem", "Kem cây và kem hộp" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 18,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Nước ngọt", "Coca Cola, Pepsi, 7Up và các loại nước ngọt" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 19,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Trà đóng chai", "Trà xanh, trà đào và trà trái cây" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 20,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Nước trái cây", "Nước cam, nước táo và các loại nước trái cây" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 21,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Sữa", "Sữa hộp và các sản phẩm từ sữa" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 22,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Nước tăng lực", "Các loại nước tăng lực" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 23,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Combo Snack Box", "Combo nhiều món ăn vặt dành cho khách hàng" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 24,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Đồ ăn vặt tuổi thơ", "Các món ăn vặt quen thuộc của thế hệ 8x, 9x" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 25,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Sản phẩm đặc biệt", "Các sản phẩm mới và sản phẩm bán theo mùa" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 35000m, "Bánh quy Cosy Marie 300g", 40 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 15000m, "Snack khoai tây Lays 68g", 80 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 12000m, "Snack Oishi tôm cay 75g", 100 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 10000m, "Kẹo dẻo Chupa Chups", 70 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 8000m, "Kẹo Dynamite vị bạc hà", 90 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 12000m, "Bánh xốp kem socola", 60 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 12000m, "Bánh xốp kem dâu", 60 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 15000m, "Bánh que socola" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 15000m, "Bánh que phô mai", 60 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 18000m, "Bánh gạo One One vị ngọt", 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 20000m, "Bánh gạo cay", 45 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 25000m, "Bắp rang bơ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 28000m, "Bắp rang caramel", 40 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 45000m, "Khô bò sợi 50g", 35 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 35000m, "Xoài sấy dẻo 100g", 40 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 25000m, "Rong biển ăn liền Tao Kae Noi", 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 18000m, "Snack rong biển vị truyền thống", 60 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 20000m, "Đậu phộng da cá 100g" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 15000m, "Hạt hướng dương vị truyền thống", 60 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 5000m, "Mì Hảo Hảo tôm chua cay", 200 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 10000m, "Mì Omachi sườn hầm ngũ quả", 100 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 23,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 32000m, "Xúc xích tiệt trùng Vissan" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 24,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 35000m, "Xúc xích phô mai", 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 25,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 45000m, "Cá viên chiên 500g", 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 26,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 55000m, "Bò viên 500g", 40 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 27,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 28000m, "Bánh mì sandwich 400g" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 28,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 15000m, "Bánh mì ngọt nhân kem", 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 29,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 45000m, "Bánh bông lan kem 300g" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 30,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 30000m, "Bánh bông lan cuộn", 40 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 31,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 25000m, "Socola thanh KitKat", 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 32,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 35000m, "Socola thanh Hershey's" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 33,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 12000m, "Kem Merino socola", 80 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 34,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 15000m, "Kem Celano vani", 70 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 35,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 10000m, "Coca Cola lon 330ml", 100 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 36,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 10000m, "Pepsi lon 330ml", 100 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 37,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 10000m, "Trà xanh C2 455ml", 90 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 38,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 12000m, "Trà đào Tea+ 455ml", 80 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 39,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 12000m, "Nước cam Twister 455ml", 80 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 40,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 12000m, "Nước táo 455ml", 70 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 41,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 8000m, "Sữa tươi Vinamilk 180ml", 100 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 42,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 9000m, "Sữa chocolate hộp 180ml", 90 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 43,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 12000m, "Red Bull 250ml", 100 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 44,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 10000m, "Sting dâu 330ml", 100 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 45,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 50000m, "Combo Snack Box Mini", 30 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 46,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 100000m, "Combo Snack Box Tuổi Thơ", 25 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 47,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 5000m, "Kẹo kéo tuổi thơ", 100 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 48,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 10000m, "Bánh đồng tiền tuổi thơ", 80 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 49,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 150000m, "Hộp quà Snack Box đặc biệt", 20 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 50,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 200000m, "Combo Party Snack Box", 15 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Bánh kẹo & Đồ ăn vặt", "Snack, bánh quy, kẹo dẻo, hạt khô" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Nước giải khát & Trà", "Nước ngọt, nước khoáng, trà đóng chai" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Sữa & Sản phẩm từ sữa", "Sữa tươi, sữa chua, phô mai, bơ" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Mì gói & Thực phẩm ăn liền", "Mì ăn liền, phở khô, cháo gói, hủ tiếu" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Gia vị & Dầu ăn", "Nước mắm, hạt nêm, dầu thực vật, nước tương" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Đồ đóng hộp & Chế biến sẵn", "Cá hộp, thịt hộp, xúc xích, pate" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Gạo & Các loại ngũ cốc", "Gạo tẻ, gạo nếp, đậu xanh, yến mạch" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Thực phẩm tươi sống", "Thịt heo, thịt bò, gia cầm, hải sản, trứng" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 9,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Rau củ & Trái cây tươi", "Rau xanh, củ quả, trái cây theo mùa" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 10,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Thực phẩm đông lạnh", "Cá viên, bò viên, chả giò, bánh bao đông lạnh" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 11,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Kem & Đồ lạnh", "Kem cây, kem hộp, đá viên đóng túi" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 12,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Cà phê & Nước tăng lực", "Cà phê hòa tan, cà phê lon, nước tăng lực" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 13,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Bia & Đồ uống có cồn", "Bia lon, rượu vang, nước trái cây lên men" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 14,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Chăm sóc cá nhân", "Sữa tắm, dầu gội, kem đánh răng, xà phòng" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 15,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Mỹ phẩm & Dưỡng da", "Sữa rửa mặt, kem chống nắng, tẩy trang, mặt nạ" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 16,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Chăm sóc nhà cửa", "Nước rửa chén, nước lau nhà, nước giặt, xả vải" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 17,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Giấy & Màng bọc", "Giấy vệ sinh, khăn giấy ăn, màng bọc thực phẩm, túi zip" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 18,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Dụng cụ vệ sinh & Rác", "Bàn chải, khăn lau, túi đựng rác, miếng rửa bát" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 19,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Đồ dùng gia đình & Bếp", "Nồi chảo, hộp đựng thực phẩm, ly nhựa, đũa muỗng" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 20,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Văn phòng phẩm", "Bút viết, tập học sinh, băng keo, kéo, kẹp giấy" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 21,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Mẹ & Bé", "Tã bỉm, sữa bột, ăn dầm, khăn ướt em bé" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 22,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Chăm sóc thú cưng", "Thức ăn cho chó mèo, cát vệ sinh, phụ kiện" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 23,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Đồ dùng cá nhân & Phụ kiện", "Khẩu trang, áo mưa, ô dù, pin gia dụng" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 24,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Bánh mì & Bánh tươi", "Bánh mì sandwich, bánh ngọt tươi, bánh bao nóng" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 25,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Sản phẩm y tế cơ bản", "Băng cá nhân, nước muối sinh lý, dán hạ sốt, cồn y tế" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Address", "CustomerName", "MembershipRank", "PhoneNumber", "RewardPoints" },
                values: new object[,]
                {
                    { 1, "12 Lê Lợi, Q.1, TP.HCM", "Nguyễn Văn An", "Vàng", "0901234567", 150 },
                    { 2, "45 Nguyễn Trãi, Q.5, TP.HCM", "Trần Thị Bình", "Bạc", "0912345678", 40 }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Address", "CustomerName", "MembershipRank", "PhoneNumber" },
                values: new object[] { 3, "78 CMT8, Q.3, TP.HCM", "Lê Hoàng Cường", "Chuẩn", "0987654321" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Address", "CustomerName", "MembershipRank", "PhoneNumber", "RewardPoints" },
                values: new object[,]
                {
                    { 4, "23 Hai Bà Trưng, Q.1, TP.HCM", "Phạm Minh Đức", "Bạc", "0901122334", 85 },
                    { 5, "56 Phan Văn Trị, Q.5, TP.HCM", "Võ Thị Hạnh", "Vàng", "0912233445", 210 },
                    { 6, "89 Điện Biên Phủ, Q. Bình Thạnh, TP.HCM", "Đặng Quốc Huy", "Chuẩn", "0983344556", 25 },
                    { 7, "34 Võ Văn Tần, Q.3, TP.HCM", "Bùi Ngọc Lan", "Vàng", "0904455667", 120 },
                    { 8, "67 Lý Thường Kiệt, Q.10, TP.HCM", "Huỳnh Thanh Nam", "Bạc", "0915566778", 60 },
                    { 9, "91 Nguyễn Văn Cừ, Q.5, TP.HCM", "Ngô Thị Mai", "Chuẩn", "0986677889", 15 },
                    { 10, "15 Trường Chinh, Q. Tân Bình, TP.HCM", "Đỗ Minh Quân", "Vàng", "0907788990", 175 },
                    { 11, "42 Nguyễn Đình Chiểu, Q.3, TP.HCM", "Phan Thị Thảo", "Bạc", "0918899001", 95 },
                    { 12, "76 Cộng Hòa, Q. Tân Bình, TP.HCM", "Trương Hoàng Long", "Chuẩn", "0989900112", 5 },
                    { 13, "28 Nam Kỳ Khởi Nghĩa, Q.1, TP.HCM", "Lý Mỹ Linh", "Vàng", "0901011223", 250 },
                    { 14, "53 Hoàng Văn Thụ, Q. Phú Nhuận, TP.HCM", "Mai Văn Khoa", "Bạc", "0912122334", 70 },
                    { 15, "84 Nguyễn Kiệm, Q. Gò Vấp, TP.HCM", "Nguyễn Thị Yến", "Chuẩn", "0983233445", 35 },
                    { 16, "19 Xô Viết Nghệ Tĩnh, Q. Bình Thạnh, TP.HCM", "Phạm Tuấn Anh", "Vàng", "0904344556", 135 },
                    { 17, "62 Nguyễn Oanh, Q. Gò Vấp, TP.HCM", "Trần Ngọc Diệp", "Bạc", "0915455667", 55 },
                    { 18, "37 Lạc Long Quân, Q.11, TP.HCM", "Lê Minh Tâm", "Chuẩn", "0986566778", 10 },
                    { 19, "48 Nguyễn Thị Minh Khai, Q.1, TP.HCM", "Võ Quốc Thắng", "Vàng", "0907677889", 190 },
                    { 20, "72 Tô Hiến Thành, Q.10, TP.HCM", "Đặng Thị Kim", "Bạc", "0918788990", 80 },
                    { 21, "16 Quang Trung, Q. Gò Vấp, TP.HCM", "Bùi Thanh Tùng", "Chuẩn", "0989899001", 20 },
                    { 22, "39 Pasteur, Q.1, TP.HCM", "Huỳnh Ngọc Anh", "Vàng", "0900900112", 160 },
                    { 23, "55 Lê Văn Sỹ, Q.3, TP.HCM", "Ngô Minh Châu", "Bạc", "0911011223", 45 }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 15000m, "Snack khoai tây Lays 68g", 80 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 10000m, "Coca Cola lon 330ml", 100 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 6000m, "Nước suối Aquafina 500ml", 150 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 36000m, "Sữa tươi Vinamilk 1L", 60 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 7000m, "Sữa chua Vinamilk có đường", 100 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 5000m, "Mì Hảo Hảo tôm chua cay", 200 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 10000m, "Mì Omachi sườn hầm ngũ quả", 100 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 28000m, "Nước mắm Nam Ngư 500ml" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 45000m, "Dầu ăn Simply 1L", 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 28000m, "Cá hộp ba cô gái 155g", 60 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 32000m, "Xúc xích tiệt trùng Vissan", 70 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 150000m, "Gạo ST25 túi 5kg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 65000m, "Yến mạch Quaker 500g", 45 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 75000m, "Thịt heo ba chỉ 500g", 30 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 140000m, "Thịt bò thăn 500g", 25 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 75000m, "Táo Gala Mỹ 1kg", 30 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 25000m, "Cà rốt Đà Lạt 1kg", 40 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 45000m, "Cá viên chiên 500g" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 65000m, "Chả giò tôm thịt 500g", 40 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 12000m, "Kem Merino socola", 80 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 85000m, "Kem hộp Celano 450ml", 30 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 23,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 45000m, "Cà phê hòa tan G7 3in1" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 24,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 12000m, "Nước tăng lực Red Bull 250ml", 100 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 25,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 18000m, "Bia Tiger lon 330ml", 100 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 26,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 22000m, "Bia Heineken lon 330ml", 80 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 27,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 125000m, "Dầu gội Clear 650ml" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 28,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 35000m, "Kem đánh răng P/S 180g", 60 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 29,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 95000m, "Sữa rửa mặt Senka 100g" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 30,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 420000m, "Kem chống nắng Anessa 60ml", 20 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 31,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 28000m, "Nước rửa chén Sunlight 750ml", 70 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 32,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 145000m, "Nước giặt Omo 3.6kg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 33,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 72000m, "Giấy vệ sinh Pulppy 10 cuộn", 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 34,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 25000m, "Màng bọc thực phẩm 30m", 60 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 35,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 18000m, "Miếng rửa chén Scotch-Brite", 80 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 36,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 30000m, "Túi rác tự hủy 45x55cm", 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 37,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 85000m, "Hộp đựng thực phẩm Lock&Lock 1L", 35 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 38,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 45000m, "Bộ đũa inox 5 đôi", 40 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 39,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 5000m, "Bút bi Thiên Long TL-027", 100 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 40,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 18000m, "Tập học sinh 200 trang", 80 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 41,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 35000m, "Khăn ướt em bé Bobby", 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 42,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 145000m, "Tã dán Bobby size M", 30 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 43,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 95000m, "Thức ăn cho chó Pedigree 1.5kg", 30 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 44,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 110000m, "Thức ăn cho mèo Whiskas 1.2kg", 30 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 45,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 45000m, "Khẩu trang y tế 4 lớp 50 cái", 100 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 46,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 35000m, "Pin AA Panasonic 4 viên", 60 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 47,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 28000m, "Bánh mì sandwich 400g", 40 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 48,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 45000m, "Bánh bông lan kem 300g", 35 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 49,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 15000m, "Băng cá nhân 20 miếng", 80 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 50,
                columns: new[] { "Price", "ProductName", "StockQuantity" },
                values: new object[] { 12000m, "Nước muối sinh lý 500ml", 70 });
        }
    }
}
