using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace MiniSupermarket.WinForms
{
    public partial class FormCustomerManagement : Form
    {
        private static readonly HttpClient _client = new HttpClient
        {
            BaseAddress = new Uri("http://localhost:7049/api/")
        };

        public FormCustomerManagement()
        {
            InitializeComponent();
        }

        private async void FormCustomerManagement_Load(object sender, EventArgs e)
        {
            // Dùng lại token đăng nhập, giống FormCategoryManagement
            _client.DefaultRequestHeaders.Authorization =
new AuthenticationHeaderValue("Bearer", SessionManager.JwtToken); await LoadDataAsync();
        }

        private async Task LoadDataAsync(string? keyword = null)
        {
            try
            {
                string url = string.IsNullOrWhiteSpace(keyword)
                    ? "Customers"
                    : $"Customers/search?keyword={Uri.EscapeDataString(keyword)}";

                var list = await _client.GetFromJsonAsync<List<CustomerDto>>(url);
                dgvCustomers.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tải được dữ liệu: " + ex.Message);
            }
        }

        private void ClearInputs()
        {
            txtCustomerId.Clear();
            txtCustomerName.Clear();
            txtPhoneNumber.Clear();
            txtAddress.Clear();
            txtRewardPoints.Text = "0";
            txtMembershipRank.Text = "Chuẩn";
        }

        private bool TryReadInputs(out CustomerDto dto)
        {
            dto = new CustomerDto();

            if (string.IsNullOrWhiteSpace(txtCustomerName.Text) || string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên và số điện thoại.");
                return false;
            }
            if (!int.TryParse(txtRewardPoints.Text, out int points) || points < 0)
            {
                MessageBox.Show("Điểm tích lũy phải là số nguyên không âm.");
                return false;
            }

            dto.CustomerName = txtCustomerName.Text.Trim();
            dto.PhoneNumber = txtPhoneNumber.Text.Trim();
            dto.Address = string.IsNullOrWhiteSpace(txtAddress.Text) ? null : txtAddress.Text.Trim();
            dto.RewardPoints = points;
            dto.MembershipRank = string.IsNullOrWhiteSpace(txtMembershipRank.Text) ? "Chuẩn" : txtMembershipRank.Text.Trim();
            return true;
        }

        private async void btnLoad_Click(object sender, EventArgs e)
        {
            txtKeyword.Clear();
            await LoadDataAsync();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            await LoadDataAsync(txtKeyword.Text);
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvCustomers.Rows[e.RowIndex].DataBoundItem is CustomerDto c)
            {
                txtCustomerId.Text = c.CustomerId.ToString();
                txtCustomerName.Text = c.CustomerName;
                txtPhoneNumber.Text = c.PhoneNumber;
                txtAddress.Text = c.Address ?? "";
                txtRewardPoints.Text = c.RewardPoints.ToString();
                txtMembershipRank.Text = c.MembershipRank;
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (!TryReadInputs(out var dto)) return;

            var response = await _client.PostAsJsonAsync("Customers", dto);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Thêm khách hàng thành công!");
                ClearInputs();
                await LoadDataAsync();
            }
            else
            {
                MessageBox.Show("Thêm thất bại: " + response.StatusCode);
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCustomerId.Text, out int id))
            {
                MessageBox.Show("Hãy chọn một khách hàng trong danh sách trước.");
                return;
            }
            if (!TryReadInputs(out var dto)) return;
            dto.CustomerId = id;

            var response = await _client.PutAsJsonAsync($"Customers/{id}", dto);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Cập nhật thành công!");
                ClearInputs();
                await LoadDataAsync();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại: " + response.StatusCode);
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCustomerId.Text, out int id))
            {
                MessageBox.Show("Hãy chọn một khách hàng trong danh sách trước.");
                return;
            }
            if (MessageBox.Show("Bạn có chắc muốn xóa khách hàng này?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            var response = await _client.DeleteAsync($"Customers/{id}");
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Đã xóa khách hàng.");
                ClearInputs();
                await LoadDataAsync();
            }
            else if (response.StatusCode == HttpStatusCode.Forbidden)
            {
                MessageBox.Show("Chỉ tài khoản Admin mới được xóa khách hàng.");
            }
            else
            {
                MessageBox.Show("Xóa thất bại: " + response.StatusCode);
            }
        }
    }

    public class CustomerDto
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string? Address { get; set; }
        public int RewardPoints { get; set; }
        public string MembershipRank { get; set; } = "Chuẩn";
    }
}