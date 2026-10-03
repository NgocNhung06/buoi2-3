using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MiniSupermarket.API.Migrations
{
    /// <inheritdoc />
    public partial class f : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
