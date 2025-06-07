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
            lblTitle = new System.Windows.Forms.Label();
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
            grpDangKy.SuspendLayout();
            grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(35, 57, 93);
            lblTitle.Location = new System.Drawing.Point(262, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(285, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "QUẢN LÝ NGƯỜI DÙNG";
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpDangKy
            // 
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
            grpDangKy.Font = new System.Drawing.Font("Segoe UI", 10F);
            grpDangKy.Location = new System.Drawing.Point(26, 66);
            grpDangKy.Name = "grpDangKy";
            grpDangKy.Size = new System.Drawing.Size(350, 422);
            grpDangKy.TabIndex = 1;
            grpDangKy.TabStop = false;
            grpDangKy.Text = "Thông tin người dùng";
            // 
            // btnHuy
            // 
            btnHuy.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            btnHuy.FlatAppearance.BorderSize = 0;
            btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnHuy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnHuy.ForeColor = System.Drawing.Color.White;
            btnHuy.Location = new System.Drawing.Point(228, 309);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new System.Drawing.Size(88, 33);
            btnHuy.TabIndex = 15;
            btnHuy.Text = "Làm mới";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnThemMoi
            // 
            btnThemMoi.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            btnThemMoi.FlatAppearance.BorderSize = 0;
            btnThemMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnThemMoi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnThemMoi.ForeColor = System.Drawing.Color.White;
            btnThemMoi.Location = new System.Drawing.Point(122, 309);
            btnThemMoi.Name = "btnThemMoi";
            btnThemMoi.Size = new System.Drawing.Size(88, 33);
            btnThemMoi.TabIndex = 14;
            btnThemMoi.Text = "Thêm mới";
            btnThemMoi.UseVisualStyleBackColor = false;
            btnThemMoi.Click += btnThemMoi_Click;
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Checked = true;
            chkIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            chkIsActive.Location = new System.Drawing.Point(122, 262);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new System.Drawing.Size(153, 23);
            chkIsActive.TabIndex = 12;
            chkIsActive.Text = "Tài khoản hoạt động";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // cmbRole
            // 
            cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbRole.Location = new System.Drawing.Point(154, 222);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new System.Drawing.Size(178, 25);
            cmbRole.TabIndex = 11;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new System.Drawing.Point(18, 225);
            lblRole.Name = "lblRole";
            lblRole.Size = new System.Drawing.Size(52, 19);
            lblRole.TabIndex = 10;
            lblRole.Text = "Vai trò:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(154, 185);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(178, 25);
            txtEmail.TabIndex = 9;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new System.Drawing.Point(18, 188);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(44, 19);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email:";
            // 
            // txtFullName
            // 
            txtFullName.Location = new System.Drawing.Point(154, 147);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new System.Drawing.Size(178, 25);
            txtFullName.TabIndex = 7;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new System.Drawing.Point(18, 150);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new System.Drawing.Size(54, 19);
            lblFullName.TabIndex = 6;
            lblFullName.Text = "Họ tên:";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new System.Drawing.Point(154, 110);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new System.Drawing.Size(178, 25);
            txtConfirmPassword.TabIndex = 5;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Location = new System.Drawing.Point(18, 116);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new System.Drawing.Size(130, 19);
            lblConfirmPassword.TabIndex = 4;
            lblConfirmPassword.Text = "Xác nhận mật khẩu:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(154, 72);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new System.Drawing.Size(178, 25);
            txtPassword.TabIndex = 3;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new System.Drawing.Point(18, 75);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new System.Drawing.Size(71, 19);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Mật khẩu:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new System.Drawing.Point(154, 35);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new System.Drawing.Size(178, 25);
            txtUsername.TabIndex = 1;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new System.Drawing.Point(18, 38);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new System.Drawing.Size(103, 19);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Tên đăng nhập:";
            // 
            // grpDanhSach
            // 
            grpDanhSach.Controls.Add(btnXoa);
            grpDanhSach.Controls.Add(btnSua);
            grpDanhSach.Controls.Add(dgvUsers);
            grpDanhSach.Font = new System.Drawing.Font("Segoe UI", 10F);
            grpDanhSach.Location = new System.Drawing.Point(394, 66);
            grpDanhSach.Name = "grpDanhSach";
            grpDanhSach.Size = new System.Drawing.Size(438, 422);
            grpDanhSach.TabIndex = 2;
            grpDanhSach.TabStop = false;
            grpDanhSach.Text = "Danh sách người dùng";
            // 
            // btnXoa
            // 
            btnXoa.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnXoa.ForeColor = System.Drawing.Color.White;
            btnXoa.Location = new System.Drawing.Point(258, 375);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new System.Drawing.Size(88, 33);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = System.Drawing.Color.FromArgb(241, 196, 15);
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnSua.ForeColor = System.Drawing.Color.White;
            btnSua.Location = new System.Drawing.Point(95, 375);
            btnSua.Name = "btnSua";
            btnSua.Size = new System.Drawing.Size(88, 33);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.BackgroundColor = System.Drawing.SystemColors.Window;
            dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new System.Drawing.Point(13, 28);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new System.Drawing.Size(411, 328);
            dgvUsers.TabIndex = 0;
            dgvUsers.SelectionChanged += dgvUsers_SelectionChanged;
            // 
            // FormDangKy
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            ClientSize = new System.Drawing.Size(858, 516);
            Controls.Add(grpDanhSach);
            Controls.Add(grpDangKy);
            Controls.Add(lblTitle);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormDangKy";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Quản lý người dùng";
            Load += FormDangKy_Load;
            grpDangKy.ResumeLayout(false);
            grpDangKy.PerformLayout();
            grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
} 