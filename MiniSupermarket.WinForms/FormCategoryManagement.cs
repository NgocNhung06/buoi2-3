using System.Net.Http.Headers; // <-- Thêm thư viện này để dùng AuthenticationHeaderValue
using System.Net.Http.Json;
using System.Windows.Forms;

namespace MiniSupermarket.WinForms
{
    public partial class FormCategoryManagement : Form
    {
        private static readonly HttpClient _client = new HttpClient
        {
            BaseAddress = new Uri("http://localhost:7049/api/")
        };

        public FormCategoryManagement()
        {
            InitializeComponent();
        }

        // Sự kiện Form vừa bật lên: Gắn Token và tải dữ liệu từ API lên bảng
        private async void FormCategoryManagement_Load(object sender, EventArgs e)
        {
            // === QUAN TRỌNG: Gắn Token đã lưu từ bước đăng nhập vào Header ===
            if (!string.IsNullOrEmpty(SessionManager.JwtToken))
            {
                _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", SessionManager.JwtToken);
            }

            await LoadDataAsync();
        }

        // Hàm dùng chung: Gọi API GET lấy danh sách và đổ lên DataGridView
        private async Task LoadDataAsync()
        {
            try
            {
                // Gửi request GET tới endpoint "categories" kèm theo Token trong Header
                var categories = await _client.GetFromJsonAsync<List<CategoryDto>>("categories");
                dgvCategories.DataSource = categories; // Gán nguồn dữ liệu cho bảng hiển thị
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối Server: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Nút Tải lại dữ liệu (Refresh)
        private async void btnLoad_Click(object sender, EventArgs e)
        {
            await LoadDataAsync();
        }

        // Sự kiện khi click vào một dòng trên DataGridView: Đưa dữ liệu lên các ô nhập (TextBox) để chuẩn bị Sửa/Xóa
        private void dgvCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCategories.Rows[e.RowIndex];
                txtId.Text = row.Cells["CategoryId"].Value.ToString();
                txtCategoryName.Text = row.Cells["CategoryName"].Value.ToString();
                txtDescription.Text = row.Cells["Description"]?.Value?.ToString() ?? string.Empty;
            }
        }

        // Nút THÊM MỚI (CREATE): Gửi dữ liệu POST lên Web API
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            var newCat = new
            {
                CategoryName = txtCategoryName.Text,
                Description = txtDescription.Text
            };

            var response = await _client.PostAsJsonAsync("categories", newCat);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadDataAsync();
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Thêm mới thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Nút CẬP NHẬT (UPDATE): Gửi dữ liệu PUT lên Web API theo ID
        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Vui lòng chọn nhóm hàng cần sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = int.Parse(txtId.Text);
            var updateCat = new
            {
                CategoryId = id,
                CategoryName = txtCategoryName.Text,
                Description = txtDescription.Text
            };

            var response = await _client.PutAsJsonAsync($"categories/{id}", updateCat);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadDataAsync();
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Nút XÓA (DELETE): Gửi request DELETE lên Web API theo ID
        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Vui lòng chọn nhóm hàng cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = int.Parse(txtId.Text);
            var confirm = MessageBox.Show($"Bạn có chắc muốn xóa nhóm hàng ID = {id}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                var response = await _client.DeleteAsync($"categories/{id}");
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadDataAsync();
                    ClearInputs();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        // Nút TÌM KIẾM (SEARCH): Gọi API lọc danh mục theo từ khóa Query String
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtKeyword.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                await LoadDataAsync();
                return;
            }

            try
            {
                var result = await _client.GetFromJsonAsync<List<CategoryDto>>($"categories/search?keyword={keyword}");
                dgvCategories.DataSource = result;
            }
            catch (Exception)
            {
                MessageBox.Show("Không tìm thấy kết quả phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ClearInputs()
        {
            txtId.Text = "";
            txtCategoryName.Text = "";
            txtDescription.Text = "";
        }
    }

    public class CategoryDto
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public string? Description { get; set; }
    }
}