namespace MiniSupermarket.WinForms
{
    partial class FormCustomerManagement
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblKeyword = new Label();
            txtKeyword = new TextBox();
            btnSearch = new Button();
            btnLoad = new Button();
            dgvCustomers = new DataGridView();
            lblCustomerId = new Label();
            txtCustomerId = new TextBox();
            lblCustomerName = new Label();
            txtCustomerName = new TextBox();
            lblPhoneNumber = new Label();
            txtPhoneNumber = new TextBox();
            lblAddress = new Label();
            txtAddress = new TextBox();
            lblRewardPoints = new Label();
            txtRewardPoints = new TextBox();
            lblMembershipRank = new Label();
            txtMembershipRank = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();

            lblKeyword.AutoSize = true;
            lblKeyword.Location = new Point(20, 23);
            lblKeyword.Text = "Từ khóa (tên/SĐT):";

            txtKeyword.Location = new Point(150, 20);
            txtKeyword.Size = new Size(250, 27);

            btnSearch.Location = new Point(410, 19);
            btnSearch.Size = new Size(90, 30);
            btnSearch.Text = "Tìm kiếm";
            btnSearch.Click += btnSearch_Click;

            btnLoad.Location = new Point(510, 19);
            btnLoad.Size = new Size(90, 30);
            btnLoad.Text = "Tải lại";
            btnLoad.Click += btnLoad_Click;

            dgvCustomers.Location = new Point(20, 60);
            dgvCustomers.Size = new Size(840, 260);
            dgvCustomers.ReadOnly = true;
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomers.CellClick += dgvCustomers_CellClick;

            lblCustomerId.AutoSize = true;
            lblCustomerId.Location = new Point(20, 343);
            lblCustomerId.Text = "Mã KH:";
            txtCustomerId.Location = new Point(140, 340);
            txtCustomerId.Size = new Size(250, 27);
            txtCustomerId.ReadOnly = true;

            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(430, 343);
            lblCustomerName.Text = "Họ tên:";
            txtCustomerName.Location = new Point(550, 340);
            txtCustomerName.Size = new Size(250, 27);

            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(20, 383);
            lblPhoneNumber.Text = "Số điện thoại:";
            txtPhoneNumber.Location = new Point(140, 380);
            txtPhoneNumber.Size = new Size(250, 27);

            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(430, 383);
            lblAddress.Text = "Địa chỉ:";
            txtAddress.Location = new Point(550, 380);
            txtAddress.Size = new Size(250, 27);

            lblRewardPoints.AutoSize = true;
            lblRewardPoints.Location = new Point(20, 423);
            lblRewardPoints.Text = "Điểm tích lũy:";
            txtRewardPoints.Location = new Point(140, 420);
            txtRewardPoints.Size = new Size(250, 27);
            txtRewardPoints.Text = "0";

            lblMembershipRank.AutoSize = true;
            lblMembershipRank.Location = new Point(430, 423);
            lblMembershipRank.Text = "Hạng thành viên:";
            txtMembershipRank.Location = new Point(550, 420);
            txtMembershipRank.Size = new Size(250, 27);
            txtMembershipRank.Text = "Chuẩn";

            btnAdd.Location = new Point(140, 470);
            btnAdd.Size = new Size(100, 35);
            btnAdd.Text = "Thêm";
            btnAdd.Click += btnAdd_Click;

            btnUpdate.Location = new Point(250, 470);
            btnUpdate.Size = new Size(100, 35);
            btnUpdate.Text = "Sửa";
            btnUpdate.Click += btnUpdate_Click;

            btnDelete.Location = new Point(360, 470);
            btnDelete.Size = new Size(100, 35);
            btnDelete.Text = "Xóa";
            btnDelete.Click += btnDelete_Click;

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 530);
            Controls.Add(lblKeyword);
            Controls.Add(txtKeyword);
            Controls.Add(btnSearch);
            Controls.Add(btnLoad);
            Controls.Add(dgvCustomers);
            Controls.Add(lblCustomerId);
            Controls.Add(txtCustomerId);
            Controls.Add(lblCustomerName);
            Controls.Add(txtCustomerName);
            Controls.Add(lblPhoneNumber);
            Controls.Add(txtPhoneNumber);
            Controls.Add(lblAddress);
            Controls.Add(txtAddress);
            Controls.Add(lblRewardPoints);
            Controls.Add(txtRewardPoints);
            Controls.Add(lblMembershipRank);
            Controls.Add(txtMembershipRank);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Name = "FormCustomerManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý khách hàng thân thiết";
            Load += FormCustomerManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblKeyword;
        private TextBox txtKeyword;
        private Button btnSearch;
        private Button btnLoad;
        private DataGridView dgvCustomers;
        private Label lblCustomerId;
        private TextBox txtCustomerId;
        private Label lblCustomerName;
        private TextBox txtCustomerName;
        private Label lblPhoneNumber;
        private TextBox txtPhoneNumber;
        private Label lblAddress;
        private TextBox txtAddress;
        private Label lblRewardPoints;
        private TextBox txtRewardPoints;
        private Label lblMembershipRank;
        private TextBox txtMembershipRank;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
    }
}