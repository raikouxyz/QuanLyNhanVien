namespace QuanLyNhanVien.Views
{
    partial class FormSaoLuu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            pnlHeader = new System.Windows.Forms.Panel();
            lblSubtitle = new System.Windows.Forms.Label();
            lblTitle = new System.Windows.Forms.Label();
            pnlContent = new System.Windows.Forms.Panel();
            grpSaoLuu = new System.Windows.Forms.GroupBox();
            pnlButtons = new System.Windows.Forms.Panel();
            btnSaoLuu = new System.Windows.Forms.Button();
            pnlInput = new System.Windows.Forms.Panel();
            btnChonViTriSaoLuu = new System.Windows.Forms.Button();
            txtDuongDanSaoLuu = new System.Windows.Forms.TextBox();
            lblDuongDanSaoLuu = new System.Windows.Forms.Label();
            pnlProgress = new System.Windows.Forms.Panel();
            lblTrangThai = new System.Windows.Forms.Label();
            progressBar = new System.Windows.Forms.ProgressBar();
            pnlHeader.SuspendLayout();
            pnlContent.SuspendLayout();
            grpSaoLuu.SuspendLayout();
            pnlButtons.SuspendLayout();
            pnlInput.SuspendLayout();
            pnlProgress.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            pnlHeader.Location = new System.Drawing.Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            pnlHeader.Size = new System.Drawing.Size(1200, 120);
            pnlHeader.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            lblSubtitle.Location = new System.Drawing.Point(33, 65);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new System.Drawing.Size(282, 20);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Xuất dữ liệu toàn hệ thống thành file SQL";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Location = new System.Drawing.Point(30, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(290, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "📤 XUẤT DỮ LIỆU SQL";
            // 
            // pnlContent
            // 
            pnlContent.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            pnlContent.Controls.Add(grpSaoLuu);
            pnlContent.Controls.Add(pnlProgress);
            pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlContent.Location = new System.Drawing.Point(0, 120);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new System.Windows.Forms.Padding(30);
            pnlContent.Size = new System.Drawing.Size(1200, 680);
            pnlContent.TabIndex = 1;
            // 
            // grpSaoLuu
            // 
            grpSaoLuu.BackColor = System.Drawing.Color.White;
            grpSaoLuu.Controls.Add(pnlButtons);
            grpSaoLuu.Controls.Add(pnlInput);
            grpSaoLuu.Dock = System.Windows.Forms.DockStyle.Top;
            grpSaoLuu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            grpSaoLuu.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            grpSaoLuu.Location = new System.Drawing.Point(30, 30);
            grpSaoLuu.Name = "grpSaoLuu";
            grpSaoLuu.Padding = new System.Windows.Forms.Padding(25, 20, 25, 25);
            grpSaoLuu.Size = new System.Drawing.Size(1140, 280);
            grpSaoLuu.TabIndex = 0;
            grpSaoLuu.TabStop = false;
            grpSaoLuu.Text = "🗃️ Xuất dữ liệu hệ thống";
            // 
            // pnlButtons
            // 
            pnlButtons.Controls.Add(btnSaoLuu);
            pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnlButtons.Location = new System.Drawing.Point(25, 200);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new System.Drawing.Size(1090, 55);
            pnlButtons.TabIndex = 1;
            // 
            // btnSaoLuu
            // 
            btnSaoLuu.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            btnSaoLuu.FlatAppearance.BorderSize = 0;
            btnSaoLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSaoLuu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            btnSaoLuu.ForeColor = System.Drawing.Color.White;
            btnSaoLuu.Location = new System.Drawing.Point(10, 3);
            btnSaoLuu.Name = "btnSaoLuu";
            btnSaoLuu.Size = new System.Drawing.Size(200, 45);
            btnSaoLuu.TabIndex = 0;
            btnSaoLuu.Text = "📤 Xuất dữ liệu ngay";
            btnSaoLuu.UseVisualStyleBackColor = false;
            btnSaoLuu.Click += btnSaoLuu_Click;
            // 
            // pnlInput
            // 
            pnlInput.Controls.Add(btnChonViTriSaoLuu);
            pnlInput.Controls.Add(txtDuongDanSaoLuu);
            pnlInput.Controls.Add(lblDuongDanSaoLuu);
            pnlInput.Dock = System.Windows.Forms.DockStyle.Top;
            pnlInput.Location = new System.Drawing.Point(25, 42);
            pnlInput.Name = "pnlInput";
            pnlInput.Size = new System.Drawing.Size(1090, 120);
            pnlInput.TabIndex = 0;
            // 
            // btnChonViTriSaoLuu
            // 
            btnChonViTriSaoLuu.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            btnChonViTriSaoLuu.FlatAppearance.BorderSize = 0;
            btnChonViTriSaoLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnChonViTriSaoLuu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnChonViTriSaoLuu.ForeColor = System.Drawing.Color.White;
            btnChonViTriSaoLuu.Location = new System.Drawing.Point(611, 50);
            btnChonViTriSaoLuu.Name = "btnChonViTriSaoLuu";
            btnChonViTriSaoLuu.Size = new System.Drawing.Size(134, 35);
            btnChonViTriSaoLuu.TabIndex = 2;
            btnChonViTriSaoLuu.Text = "📂 Chọn thư mục";
            btnChonViTriSaoLuu.UseVisualStyleBackColor = false;
            btnChonViTriSaoLuu.Click += btnChonViTriSaoLuu_Click;
            // 
            // txtDuongDanSaoLuu
            // 
            txtDuongDanSaoLuu.BackColor = System.Drawing.Color.White;
            txtDuongDanSaoLuu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtDuongDanSaoLuu.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtDuongDanSaoLuu.ForeColor = System.Drawing.Color.FromArgb(70, 70, 70);
            txtDuongDanSaoLuu.Location = new System.Drawing.Point(10, 50);
            txtDuongDanSaoLuu.Multiline = true;
            txtDuongDanSaoLuu.Name = "txtDuongDanSaoLuu";
            txtDuongDanSaoLuu.ReadOnly = true;
            txtDuongDanSaoLuu.Size = new System.Drawing.Size(580, 35);
            txtDuongDanSaoLuu.TabIndex = 1;
            // 
            // lblDuongDanSaoLuu
            // 
            lblDuongDanSaoLuu.AutoSize = true;
            lblDuongDanSaoLuu.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblDuongDanSaoLuu.ForeColor = System.Drawing.Color.FromArgb(70, 70, 70);
            lblDuongDanSaoLuu.Location = new System.Drawing.Point(10, 20);
            lblDuongDanSaoLuu.Name = "lblDuongDanSaoLuu";
            lblDuongDanSaoLuu.Size = new System.Drawing.Size(148, 20);
            lblDuongDanSaoLuu.TabIndex = 0;
            lblDuongDanSaoLuu.Text = "📁 Vị trí lưu file SQL:";
            // 
            // pnlProgress
            // 
            pnlProgress.BackColor = System.Drawing.Color.White;
            pnlProgress.Controls.Add(lblTrangThai);
            pnlProgress.Controls.Add(progressBar);
            pnlProgress.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnlProgress.Location = new System.Drawing.Point(30, 550);
            pnlProgress.Name = "pnlProgress";
            pnlProgress.Padding = new System.Windows.Forms.Padding(25);
            pnlProgress.Size = new System.Drawing.Size(1140, 100);
            pnlProgress.TabIndex = 1;
            // 
            // lblTrangThai
            // 
            lblTrangThai.Dock = System.Windows.Forms.DockStyle.Top;
            lblTrangThai.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblTrangThai.ForeColor = System.Drawing.Color.FromArgb(70, 70, 70);
            lblTrangThai.Location = new System.Drawing.Point(25, 25);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new System.Drawing.Size(1090, 25);
            lblTrangThai.TabIndex = 0;
            lblTrangThai.Text = "✅ Sẵn sàng xuất dữ liệu hệ thống";
            lblTrangThai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar
            // 
            progressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            progressBar.Location = new System.Drawing.Point(25, 60);
            progressBar.Name = "progressBar";
            progressBar.Size = new System.Drawing.Size(1090, 15);
            progressBar.TabIndex = 1;
            progressBar.Visible = false;
            // 
            // FormSaoLuu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            ClientSize = new System.Drawing.Size(1200, 800);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            Font = new System.Drawing.Font("Segoe UI", 9F);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormSaoLuu";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Xuất dữ liệu SQL - HRM Professional";
            Load += FormSaoLuu_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlContent.ResumeLayout(false);
            grpSaoLuu.ResumeLayout(false);
            pnlButtons.ResumeLayout(false);
            pnlInput.ResumeLayout(false);
            pnlInput.PerformLayout();
            pnlProgress.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.GroupBox grpSaoLuu;
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.Button btnChonViTriSaoLuu;
        private System.Windows.Forms.TextBox txtDuongDanSaoLuu;
        private System.Windows.Forms.Label lblDuongDanSaoLuu;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnSaoLuu;
        private System.Windows.Forms.Panel pnlProgress;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblTrangThai;
    }
}