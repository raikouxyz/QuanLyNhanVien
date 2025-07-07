namespace QuanLyNhanVien.Views
{
    partial class FormDangKy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Khai báo các control
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.GroupBox grpDangKy;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlContent;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            // Khởi tạo components
            pnlHeader = new System.Windows.Forms.Panel();
            pnlContent = new System.Windows.Forms.Panel();
            lblTitle = new System.Windows.Forms.Label();
            lblSubtitle = new System.Windows.Forms.Label();
            grpDangKy = new System.Windows.Forms.GroupBox();
            btnHuy = new System.Windows.Forms.Button();
            btnThemMoi = new System.Windows.Forms.Button();
            chkIsActive = new System.Windows.Forms.CheckBox();
            cmbRole = new System.Windows.Forms.ComboBox();
            lblRole = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            lblEmail = new System.Windows.Forms.Label();
            txtFullName = new System.Windows.Forms.TextBox();
            lblFullName = new System.Windows.Forms.Label();
            txtConfirmPassword = new System.Windows.Forms.TextBox();
            lblConfirmPassword = new System.Windows.Forms.Label();
            txtPassword = new System.Windows.Forms.TextBox();
            lblPassword = new System.Windows.Forms.Label();
            txtUsername = new System.Windows.Forms.TextBox();
            lblUsername = new System.Windows.Forms.Label();
            grpDanhSach = new System.Windows.Forms.GroupBox();
            btnXoa = new System.Windows.Forms.Button();
            btnSua = new System.Windows.Forms.Button();
            dgvUsers = new System.Windows.Forms.DataGridView();

            pnlHeader.SuspendLayout();
            pnlContent.SuspendLayout();
            grpDangKy.SuspendLayout();
            grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();

            // pnlHeader - Panel header với gradient
            pnlHeader.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            pnlHeader.Location = new System.Drawing.Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new System.Drawing.Size(1200, 100);
            pnlHeader.TabIndex = 0;

            // lblTitle - Tiêu đề chính
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Location = new System.Drawing.Point(450, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(300, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "👥 QUẢN LÝ TÀI KHOẢN";
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblSubtitle - Phụ đề
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(236, 240, 241);
            lblSubtitle.Location = new System.Drawing.Point(480, 65);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new System.Drawing.Size(240, 21);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Quản lý người dùng và phân quyền hệ thống";
            lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // pnlContent - Panel chính
            pnlContent.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            pnlContent.Controls.Add(grpDangKy);
            pnlContent.Controls.Add(grpDanhSach);
            pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlContent.Location = new System.Drawing.Point(0, 100);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new System.Windows.Forms.Padding(30);
            pnlContent.Size = new System.Drawing.Size(1200, 700);
            pnlContent.TabIndex = 1;

            // grpDangKy - Card style với shadow
            grpDangKy.BackColor = System.Drawing.Color.White;
            grpDangKy.Controls.Add(btnHuy);
            grpDangKy.Controls.Add(btnThemMoi);
            grpDangKy.Controls.Add(chkIsActive);
            grpDangKy.Controls.Add(cmbRole);
            grpDangKy.Controls.Add(lblRole);
            grpDangKy.Controls.Add(txtEmail);
            grpDangKy.Controls.Add(lblEmail);
            grpDangKy.Controls.Add(txtFullName);
            grpDangKy.Controls.Add(lblFullName);
            grpDangKy.Controls.Add(txtConfirmPassword);
            grpDangKy.Controls.Add(lblConfirmPassword);
            grpDangKy.Controls.Add(txtPassword);
            grpDangKy.Controls.Add(lblPassword);
            grpDangKy.Controls.Add(txtUsername);
            grpDangKy.Controls.Add(lblUsername);
            grpDangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            grpDangKy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            grpDangKy.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            grpDangKy.Location = new System.Drawing.Point(40, 20);
            grpDangKy.Name = "grpDangKy";
            grpDangKy.Padding = new System.Windows.Forms.Padding(20);
            grpDangKy.Size = new System.Drawing.Size(450, 550);
            grpDangKy.TabIndex = 1;
            grpDangKy.Text = "📝 Thông tin tài khoản";

            // Styling cho các Label
            lblUsername.AutoSize = true;
            lblUsername.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblUsername.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            lblUsername.Location = new System.Drawing.Point(30, 50);
            lblUsername.Size = new System.Drawing.Size(120, 20);
            lblUsername.Text = "👤 Tên đăng nhập:";

            // txtUsername với style mới
            txtUsername.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtUsername.Location = new System.Drawing.Point(30, 75);
            txtUsername.Size = new System.Drawing.Size(390, 30);
            txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            lblPassword.AutoSize = true;
            lblPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblPassword.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            lblPassword.Location = new System.Drawing.Point(30, 115);
            lblPassword.Size = new System.Drawing.Size(120, 20);
            lblPassword.Text = "🔒 Mật khẩu:";

            txtPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtPassword.Location = new System.Drawing.Point(30, 140);
            txtPassword.Size = new System.Drawing.Size(390, 30);
            txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtPassword.PasswordChar = '●';

            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            lblConfirmPassword.Location = new System.Drawing.Point(30, 180);
            lblConfirmPassword.Size = new System.Drawing.Size(120, 20);
            lblConfirmPassword.Text = "🔒 Xác nhận mật khẩu:";

            txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtConfirmPassword.Location = new System.Drawing.Point(30, 205);
            txtConfirmPassword.Size = new System.Drawing.Size(390, 30);
            txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtConfirmPassword.PasswordChar = '●';

            lblFullName.AutoSize = true;
            lblFullName.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblFullName.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            lblFullName.Location = new System.Drawing.Point(30, 245);
            lblFullName.Size = new System.Drawing.Size(120, 20);
            lblFullName.Text = "📋 Họ và tên:";

            txtFullName.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtFullName.Location = new System.Drawing.Point(30, 270);
            txtFullName.Size = new System.Drawing.Size(390, 30);
            txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            lblEmail.AutoSize = true;
            lblEmail.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblEmail.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            lblEmail.Location = new System.Drawing.Point(30, 310);
            lblEmail.Size = new System.Drawing.Size(120, 20);
            lblEmail.Text = "📧 Email:";

            txtEmail.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtEmail.Location = new System.Drawing.Point(30, 335);
            txtEmail.Size = new System.Drawing.Size(390, 30);
            txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            lblRole.AutoSize = true;
            lblRole.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblRole.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            lblRole.Location = new System.Drawing.Point(30, 375);
            lblRole.Size = new System.Drawing.Size(120, 20);
            lblRole.Text = "👑 Vai trò:";

            cmbRole.Font = new System.Drawing.Font("Segoe UI", 11F);
            cmbRole.Location = new System.Drawing.Point(30, 400);
            cmbRole.Size = new System.Drawing.Size(390, 30);
            cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            chkIsActive.AutoSize = true;
            chkIsActive.Checked = true;
            chkIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            chkIsActive.Font = new System.Drawing.Font("Segoe UI", 11F);
            chkIsActive.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            chkIsActive.Location = new System.Drawing.Point(30, 445);
            chkIsActive.Size = new System.Drawing.Size(200, 25);
            chkIsActive.Text = "✅ Kích hoạt tài khoản";

            // Buttons với gradient và icon
            btnThemMoi.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            btnThemMoi.FlatAppearance.BorderSize = 0;
            btnThemMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnThemMoi.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnThemMoi.ForeColor = System.Drawing.Color.White;
            btnThemMoi.Location = new System.Drawing.Point(30, 485);
            btnThemMoi.Size = new System.Drawing.Size(180, 40);
            btnThemMoi.Text = "➕ Thêm mới";
            btnThemMoi.UseVisualStyleBackColor = false;

            btnHuy.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            btnHuy.FlatAppearance.BorderSize = 0;
            btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnHuy.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnHuy.ForeColor = System.Drawing.Color.White;
            btnHuy.Location = new System.Drawing.Point(240, 485);
            btnHuy.Size = new System.Drawing.Size(180, 40);
            btnHuy.Text = "🔄 Làm mới";
            btnHuy.UseVisualStyleBackColor = false;

            // grpDanhSach - Card style với shadow
            grpDanhSach.BackColor = System.Drawing.Color.White;
            grpDanhSach.Controls.Add(btnXoa);
            grpDanhSach.Controls.Add(btnSua);
            grpDanhSach.Controls.Add(dgvUsers);
            grpDanhSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            grpDanhSach.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            grpDanhSach.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            grpDanhSach.Location = new System.Drawing.Point(510, 20);
            grpDanhSach.Padding = new System.Windows.Forms.Padding(20);
            grpDanhSach.Size = new System.Drawing.Size(650, 550);
            grpDanhSach.Text = "📋 Danh sách tài khoản";

            // DataGridView với style hiện đại
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.BackgroundColor = System.Drawing.Color.White;
            dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dgvUsers.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            dgvUsers.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dgvUsers.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgvUsers.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            dgvUsers.ColumnHeadersHeight = 40;
            dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvUsers.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            dgvUsers.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            dgvUsers.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            dgvUsers.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            dgvUsers.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            dgvUsers.EnableHeadersVisualStyles = false;
            dgvUsers.GridColor = System.Drawing.Color.FromArgb(230, 230, 230);
            dgvUsers.Location = new System.Drawing.Point(20, 40);
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.RowTemplate.Height = 35;
            dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new System.Drawing.Size(610, 440);

            btnSua.BackColor = System.Drawing.Color.FromArgb(243, 156, 18);
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSua.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnSua.ForeColor = System.Drawing.Color.White;
            btnSua.Location = new System.Drawing.Point(240, 485);
            btnSua.Size = new System.Drawing.Size(180, 40);
            btnSua.Text = "✏️ Chỉnh sửa";
            btnSua.UseVisualStyleBackColor = false;

            btnXoa.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnXoa.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnXoa.ForeColor = System.Drawing.Color.White;
            btnXoa.Location = new System.Drawing.Point(450, 485);
            btnXoa.Size = new System.Drawing.Size(180, 40);
            btnXoa.Text = "🗑️ Xóa";
            btnXoa.UseVisualStyleBackColor = false;

            // FormDangKy
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            ClientSize = new System.Drawing.Size(1200, 800);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormDangKy";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Quản lý tài khoản - HRM System";
            Load += FormDangKy_Load;

            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlContent.ResumeLayout(false);
            grpDangKy.ResumeLayout(false);
            grpDangKy.PerformLayout();
            grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
} 