namespace MiniSupermarket.WinForms
{
    partial class FormCategoryManagement
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtKeyword = new TextBox();
            btnSearch = new Button();
            dgvCategories = new DataGridView();
            btnLoad = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            txtDescription = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtCategoryName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtId = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // txtKeyword
            // 
            txtKeyword.Location = new Point(50, 113);
            txtKeyword.Margin = new Padding(3, 4, 3, 4);
            txtKeyword.Name = "txtKeyword";
            txtKeyword.Size = new Size(401, 27);
            txtKeyword.TabIndex = 0;
            txtKeyword.Text = "Nhập từ khóa";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(430, 25);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(86, 31);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvCategories
            // 
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategories.Location = new Point(7, 29);
            dgvCategories.Margin = new Padding(3, 4, 3, 4);
            dgvCategories.Name = "dgvCategories";
            dgvCategories.RowHeadersWidth = 51;
            dgvCategories.Size = new Size(601, 377);
            dgvCategories.TabIndex = 2;
            dgvCategories.CellClick += dgvCategories_CellClick;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(522, 25);
            btnLoad.Margin = new Padding(3, 4, 3, 4);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(86, 31);
            btnLoad.TabIndex = 3;
            btnLoad.Text = "Tải lại";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLoad);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Location = new Point(29, 88);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(621, 73);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvCategories);
            groupBox2.Location = new Point(29, 169);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(621, 415);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách Nhóm hàng";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnAdd);
            groupBox3.Controls.Add(btnUpdate);
            groupBox3.Controls.Add(btnDelete);
            groupBox3.Controls.Add(txtDescription);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(txtCategoryName);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(txtId);
            groupBox3.Controls.Add(label1);
            groupBox3.Location = new Point(656, 169);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(308, 415);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin Nhóm hàng";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(7, 260);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(96, 31);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Thêm mới";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(109, 260);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(108, 31);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(223, 260);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(74, 31);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(7, 200);
            txtDescription.Margin = new Padding(3, 4, 3, 4);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(290, 27);
            txtDescription.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.AppWorkspace;
            label5.Location = new Point(57, 176);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 6;
            label5.Text = "Mô tả chi tiết";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 176);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 5;
            label4.Text = "Mô tả";
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(7, 127);
            txtCategoryName.Margin = new Padding(3, 4, 3, 4);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(290, 27);
            txtCategoryName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.AppWorkspace;
            label3.Location = new Point(119, 103);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 3;
            label3.Text = "Ví dụ: Bánh kẹo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 103);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên Nhóm hàng";
            // 
            // txtId
            // 
            txtId.Location = new Point(7, 53);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(290, 27);
            txtId.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 29);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã ID";
            // 
            // FormCategoryManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1001, 600);
            Controls.Add(groupBox3);
            Controls.Add(txtKeyword);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormCategoryManagement";
            Text = "FormCategoryManagement";
            Load += FormCategoryManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtKeyword;
        private Button btnSearch;
        private DataGridView dgvCategories;
        private Button btnLoad;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Label label1;
        private TextBox txtId;
        private Label label2;
        private Label label3;
        private TextBox txtCategoryName;
        private Label label4;
        private TextBox txtDescription;
        private Label label5;
    }
}