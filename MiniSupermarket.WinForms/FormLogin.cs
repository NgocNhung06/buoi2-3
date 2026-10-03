using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MiniSupermarket.WinForms
{
    // Tạo class Model hứng kết quả trả về từ API (có thể để ở đây hoặc tách ra thư mục Models)
    public class LoginResponseDto
    {
        [JsonPropertyName("token")]
        public string Token { get; set; }

        [JsonPropertyName("role")]
        public string Role { get; set; }
    }

    public partial class FormLogin : Form
    {
        // Khởi tạo HttpClient trỏ đến địa chỉ của Web API Backend
        private static readonly HttpClient _client = new HttpClient
        {
            BaseAddress = new Uri("http://localhost:7049/api/")
        };

        public FormLogin()
        {
            InitializeComponent();
        }

        // Sự kiện khi người dùng bấm nút Đăng nhập
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text.Trim();
            string password = txtPass.Text.Trim();

            // Kiểm tra ràng buộc cơ bản phía Client
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tài khoản và mật khẩu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Đóng gói dữ liệu gửi lên endpoint POST /api/auth/login
                var loginData = new { Username = username, Password = password };
                var response = await _client.PostAsJsonAsync("auth/login", loginData);

                if (response.IsSuccessStatusCode)
                {
                    // Đọc trực tiếp JSON vào object LoginResponseDto (hỗ trợ tốt cả camelCase lẫn PascalCase)
                    var result = await response.Content.ReadFromJsonAsync<LoginResponseDto>();

                    if (result != null)
                    {
                        // Trích xuất Token và Role lưu vào lớp tĩnh SessionManager dùng chung toàn ứng dụng
                        SessionManager.JwtToken = result.Token ?? string.Empty;
                        SessionManager.CurrentRole = result.Role ?? string.Empty;

                        MessageBox.Show($"Đăng nhập thành công với quyền: {SessionManager.CurrentRole}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Mở Form quản lý chính (FormCategoryManagement) và ẩn Form đăng nhập đi
                        FormCategoryManagement mainForm = new FormCategoryManagement();
                        this.Hide();
                        mainForm.ShowDialog();
                        this.Close(); // Đóng hẳn ứng dụng khi form chính tắt
                    }
                    else
                    {
                        MessageBox.Show("Phản hồi từ server không hợp lệ!", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối đến Server: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }
    }
}