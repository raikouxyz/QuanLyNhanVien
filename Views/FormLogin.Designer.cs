namespace QuanLyNhanVien.Views
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Khai báo các control
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlLoginCard;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblThongTin;
        private System.Windows.Forms.Label lblWelcome;

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
            pnlLoginCard = new System.Windows.Forms.Panel();
            lblTitle = new System.Windows.Forms.Label();
            lblSubtitle = new System.Windows.Forms.Label();
            lblWelcome = new System.Windows.Forms.Label();
            lblUsername = new System.Windows.Forms.Label();
            txtUsername = new System.Windows.Forms.TextBox();
            lblPassword = new System.Windows.Forms.Label();
            txtPassword = new System.Windows.Forms.TextBox();
            btnLogin = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            lblThongTin = new System.Windows.Forms.Label();

            pnlHeader.SuspendLayout();
            pnlContent.SuspendLayout();
            pnlLoginCard.SuspendLayout();
            SuspendLayout();

            // pnlHeader - Header chuyên nghiệp với navy blue
            pnlHeader.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            pnlHeader.Location = new System.Drawing.Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new System.Drawing.Size(800, 120);
            pnlHeader.TabIndex = 0;

            // lblTitle - Tiêu đề chính
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Location = new System.Drawing.Point(200, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(400, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "🏢 HRM SYSTEM";
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblSubtitle - Phụ đề
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(220, 221, 225);
            lblSubtitle.Location = new System.Drawing.Point(250, 80);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new System.Drawing.Size(300, 21);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Hệ thống quản lý nhân sự hiện đại";
            lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // pnlContent - Panel chính với background gradient nhẹ
            pnlContent.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            pnlContent.Controls.Add(pnlLoginCard);
            pnlContent.Controls.Add(lblThongTin);
            pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlContent.Location = new System.Drawing.Point(0, 120);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new System.Windows.Forms.Padding(50);
            pnlContent.Size = new System.Drawing.Size(800, 480);
            pnlContent.TabIndex = 1;

            // pnlLoginCard - Card đăng nhập với shadow effect
            pnlLoginCard.BackColor = System.Drawing.Color.White;
            pnlLoginCard.Controls.Add(lblWelcome);
            pnlLoginCard.Controls.Add(lblUsername);
            pnlLoginCard.Controls.Add(txtUsername);
            pnlLoginCard.Controls.Add(lblPassword);
            pnlLoginCard.Controls.Add(txtPassword);
            pnlLoginCard.Controls.Add(btnLogin);
            pnlLoginCard.Controls.Add(btnExit);
            pnlLoginCard.Location = new System.Drawing.Point(200, 30);
            pnlLoginCard.Name = "pnlLoginCard";
            pnlLoginCard.Padding = new System.Windows.Forms.Padding(40);
            pnlLoginCard.Size = new System.Drawing.Size(400, 350);
            pnlLoginCard.TabIndex = 0;

            // lblWelcome - Lời chào chuyên nghiệp
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblWelcome.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            lblWelcome.Location = new System.Drawing.Point(40, 30);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new System.Drawing.Size(320, 30);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "🔐 Chào mừng đến với HRM";
            lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblUsername - Label tên đăng nhập với icon
            lblUsername.AutoSize = true;
            lblUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblUsername.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            lblUsername.Location = new System.Drawing.Point(40, 90);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new System.Drawing.Size(150, 21);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "👤 Tên đăng nhập";

            // txtUsername - TextBox tên đăng nhập
            txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtUsername.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtUsername.Location = new System.Drawing.Point(40, 115);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Nhập tên đăng nhập...";
            txtUsername.Size = new System.Drawing.Size(320, 32);
            txtUsername.TabIndex = 2;

            // lblPassword - Label mật khẩu với icon
            lblPassword.AutoSize = true;
            lblPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblPassword.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            lblPassword.Location = new System.Drawing.Point(40, 165);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new System.Drawing.Size(110, 21);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "🔒 Mật khẩu";

            // txtPassword - TextBox mật khẩu
            txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtPassword.Location = new System.Drawing.Point(40, 190);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.PlaceholderText = "Nhập mật khẩu...";
            txtPassword.Size = new System.Drawing.Size(320, 32);
            txtPassword.TabIndex = 4;
            txtPassword.KeyPress += txtPassword_KeyPress;

            // btnLogin - Button đăng nhập chuyên nghiệp
            btnLogin.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            btnLogin.ForeColor = System.Drawing.Color.White;
            btnLogin.Location = new System.Drawing.Point(40, 250);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(150, 45);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "🚀 Đăng nhập";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;

            // btnExit - Button thoát với màu xám
            btnExit.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            btnExit.ForeColor = System.Drawing.Color.White;
            btnExit.Location = new System.Drawing.Point(210, 250);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(150, 45);
            btnExit.TabIndex = 6;
            btnExit.Text = "❌ Thoát";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;

            // lblThongTin - Thông tin hướng dẫn
            lblThongTin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            lblThongTin.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
            lblThongTin.Location = new System.Drawing.Point(50, 400);
            lblThongTin.Name = "lblThongTin";
            lblThongTin.Size = new System.Drawing.Size(700, 60);
            lblThongTin.TabIndex = 7;
            lblThongTin.Text = "💡 Liên hệ quản trị viên nếu bạn quên mật khẩu hoặc gặp sự cố đăng nhập.\n📧 Email hỗ trợ: admin@hrm.com | ☎️ Hotline: 1900-1234";
            lblThongTin.TextAlign = System.Drawing.ContentAlignment.TopCenter;

            // FormLogin - Thiết lập form chính
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            ClientSize = new System.Drawing.Size(800, 600);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Đăng nhập hệ thống - HRM Professional";
            Load += FormLogin_Load;

            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlContent.ResumeLayout(false);
            pnlLoginCard.ResumeLayout(false);
            pnlLoginCard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}