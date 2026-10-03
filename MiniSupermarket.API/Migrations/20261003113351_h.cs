using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MiniSupermarket.API.Migrations
{
    /// <inheritdoc />
    public partial class h : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Barcode", "CategoryId", "Price", "ProductName", "StockQuantity" },
                values: new object[,]
                {
                    { 1, "893100100001", 1, 18000m, "Bánh Oreo vị socola 133g", 50 },
                    { 2, "893100100002", 1, 15000m, "Snack khoai tây Lays 68g", 80 },
                    { 3, "893100100003", 2, 10000m, "Coca Cola lon 330ml", 100 },
                    { 4, "893100100004", 2, 6000m, "Nước suối Aquafina 500ml", 150 },
                    { 5, "893100100005", 3, 36000m, "Sữa tươi Vinamilk 1L", 60 },
                    { 6, "893100100006", 3, 7000m, "Sữa chua Vinamilk có đường", 100 },
                    { 7, "893100100007", 4, 5000m, "Mì Hảo Hảo tôm chua cay", 200 },
                    { 8, "893100100008", 4, 10000m, "Mì Omachi sườn hầm ngũ quả", 100 },
                    { 9, "893100100009", 5, 28000m, "Nước mắm Nam Ngư 500ml", 70 },
                    { 10, "893100100010", 5, 45000m, "Dầu ăn Simply 1L", 50 },
                    { 11, "893100100011", 6, 28000m, "Cá hộp ba cô gái 155g", 60 },
                    { 12, "893100100012", 6, 32000m, "Xúc xích tiệt trùng Vissan", 70 },
                    { 13, "893100100013", 7, 150000m, "Gạo ST25 túi 5kg", 40 },
                    { 14, "893100100014", 7, 65000m, "Yến mạch Quaker 500g", 45 },
                    { 15, "893100100015", 8, 75000m, "Thịt heo ba chỉ 500g", 30 },
                    { 16, "893100100016", 8, 140000m, "Thịt bò thăn 500g", 25 },
                    { 17, "893100100017", 9, 75000m, "Táo Gala Mỹ 1kg", 30 },
                    { 18, "893100100018", 9, 25000m, "Cà rốt Đà Lạt 1kg", 40 },
                    { 19, "893100100019", 10, 45000m, "Cá viên chiên 500g", 50 },
                    { 20, "893100100020", 10, 65000m, "Chả giò tôm thịt 500g", 40 },
                    { 21, "893100100021", 11, 12000m, "Kem Merino socola", 80 },
                    { 22, "893100100022", 11, 85000m, "Kem hộp Celano 450ml", 30 },
                    { 23, "893100100023", 12, 45000m, "Cà phê hòa tan G7 3in1", 70 },
                    { 24, "893100100024", 12, 12000m, "Nước tăng lực Red Bull 250ml", 100 },
                    { 25, "893100100025", 13, 18000m, "Bia Tiger lon 330ml", 100 },
                    { 26, "893100100026", 13, 22000m, "Bia Heineken lon 330ml", 80 },
                    { 27, "893100100027", 14, 125000m, "Dầu gội Clear 650ml", 40 },
                    { 28, "893100100028", 14, 35000m, "Kem đánh răng P/S 180g", 60 },
                    { 29, "893100100029", 15, 95000m, "Sữa rửa mặt Senka 100g", 35 },
                    { 30, "893100100030", 15, 420000m, "Kem chống nắng Anessa 60ml", 20 },
                    { 31, "893100100031", 16, 28000m, "Nước rửa chén Sunlight 750ml", 70 },
                    { 32, "893100100032", 16, 145000m, "Nước giặt Omo 3.6kg", 40 },
                    { 33, "893100100033", 17, 72000m, "Giấy vệ sinh Pulppy 10 cuộn", 50 },
                    { 34, "893100100034", 17, 25000m, "Màng bọc thực phẩm 30m", 60 },
                    { 35, "893100100035", 18, 18000m, "Miếng rửa chén Scotch-Brite", 80 },
                    { 36, "893100100036", 18, 30000m, "Túi rác tự hủy 45x55cm", 50 },
                    { 37, "893100100037", 19, 85000m, "Hộp đựng thực phẩm Lock&Lock 1L", 35 },
                    { 38, "893100100038", 19, 45000m, "Bộ đũa inox 5 đôi", 40 },
                    { 39, "893100100039", 20, 5000m, "Bút bi Thiên Long TL-027", 100 },
                    { 40, "893100100040", 20, 18000m, "Tập học sinh 200 trang", 80 },
                    { 41, "893100100041", 21, 35000m, "Khăn ướt em bé Bobby", 50 },
                    { 42, "893100100042", 21, 145000m, "Tã dán Bobby size M", 30 },
                    { 43, "893100100043", 22, 95000m, "Thức ăn cho chó Pedigree 1.5kg", 30 },
                    { 44, "893100100044", 22, 110000m, "Thức ăn cho mèo Whiskas 1.2kg", 30 },
                    { 45, "893100100045", 23, 45000m, "Khẩu trang y tế 4 lớp 50 cái", 100 },
                    { 46, "893100100046", 23, 35000m, "Pin AA Panasonic 4 viên", 60 },
                    { 47, "893100100047", 24, 28000m, "Bánh mì sandwich 400g", 40 },
                    { 48, "893100100048", 24, 45000m, "Bánh bông lan kem 300g", 35 },
                    { 49, "893100100049", 25, 15000m, "Băng cá nhân 20 miếng", 80 },
                    { 50, "893100100050", 25, 12000m, "Nước muối sinh lý 500ml", 70 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 50);
        }
    }
}
