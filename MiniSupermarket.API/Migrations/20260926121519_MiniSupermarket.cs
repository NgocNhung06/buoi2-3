using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MiniSupermarket.API.Migrations
{
    /// <inheritdoc />
    public partial class MiniSupermarket : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Barcode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StockQuantity = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[,]
                {
                    { 1, "Bánh kẹo & Đồ ăn vặt", "Snack, bánh quy, kẹo dẻo, hạt khô" },
                    { 2, "Nước giải khát & Trà", "Nước ngọt, nước khoáng, trà đóng chai" },
                    { 3, "Sữa & Sản phẩm từ sữa", "Sữa tươi, sữa chua, phô mai, bơ" },
                    { 4, "Mì gói & Thực phẩm ăn liền", "Mì ăn liền, phở khô, cháo gói, hủ tiếu" },
                    { 5, "Gia vị & Dầu ăn", "Nước mắm, hạt nêm, dầu thực vật, nước tương" },
                    { 6, "Đồ đóng hộp & Chế biến sẵn", "Cá hộp, thịt hộp, xúc xích, pate" },
                    { 7, "Gạo & Các loại ngũ cốc", "Gạo tẻ, gạo nếp, đậu xanh, yến mạch" },
                    { 8, "Thực phẩm tươi sống", "Thịt heo, thịt bò, gia cầm, hải sản, trứng" },
                    { 9, "Rau củ & Trái cây tươi", "Rau xanh, củ quả, trái cây theo mùa" },
                    { 10, "Thực phẩm đông lạnh", "Cá viên, bò viên, chả giò, bánh bao đông lạnh" },
                    { 11, "Kem & Đồ lạnh", "Kem cây, kem hộp, đá viên đóng túi" },
                    { 12, "Cà phê & Nước tăng lực", "Cà phê hòa tan, cà phê lon, nước tăng lực" },
                    { 13, "Bia & Đồ uống có cồn", "Bia lon, rượu vang, nước trái cây lên men" },
                    { 14, "Chăm sóc cá nhân", "Sữa tắm, dầu gội, kem đánh răng, xà phòng" },
                    { 15, "Mỹ phẩm & Dưỡng da", "Sữa rửa mặt, kem chống nắng, tẩy trang, mặt nạ" },
                    { 16, "Chăm sóc nhà cửa", "Nước rửa chén, nước lau nhà, nước giặt, xả vải" },
                    { 17, "Giấy & Màng bọc", "Giấy vệ sinh, khăn giấy ăn, màng bọc thực phẩm, túi zip" },
                    { 18, "Dụng cụ vệ sinh & Rác", "Bàn chải, khăn lau, túi đựng rác, miếng rửa bát" },
                    { 19, "Đồ dùng gia đình & Bếp", "Nồi chảo, hộp đựng thực phẩm, ly nhựa, đũa muỗng" },
                    { 20, "Văn phòng phẩm", "Bút viết, tập học sinh, băng keo, kéo, kẹp giấy" },
                    { 21, "Mẹ & Bé", "Tã bỉm, sữa bột, ăn dầm, khăn ướt em bé" },
                    { 22, "Chăm sóc thú cưng", "Thức ăn cho chó mèo, cát vệ sinh, phụ kiện" },
                    { 23, "Đồ dùng cá nhân & Phụ kiện", "Khẩu trang, áo mưa, ô dù, pin gia dụng" },
                    { 24, "Bánh mì & Bánh tươi", "Bánh mì sandwich, bánh ngọt tươi, bánh bao nóng" },
                    { 25, "Sản phẩm y tế cơ bản", "Băng cá nhân, nước muối sinh lý, dán hạ sốt, cồn y tế" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
