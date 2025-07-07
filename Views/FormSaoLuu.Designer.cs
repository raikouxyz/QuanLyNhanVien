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
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpSaoLuu = new System.Windows.Forms.GroupBox();
            this.btnChonViTriSaoLuu = new System.Windows.Forms.Button();
            this.txtDuongDanSaoLuu = new System.Windows.Forms.TextBox();
            this.lblDuongDanSaoLuu = new System.Windows.Forms.Label();
            this.btnSaoLuu = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.grpSaoLuu.SuspendLayout();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(320, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "XUẤT DỮ LIỆU TOÀN HỆ THỐNG";

            // grpSaoLuu
            this.grpSaoLuu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSaoLuu.Controls.Add(this.btnChonViTriSaoLuu);
            this.grpSaoLuu.Controls.Add(this.txtDuongDanSaoLuu);
            this.grpSaoLuu.Controls.Add(this.lblDuongDanSaoLuu);
            this.grpSaoLuu.Controls.Add(this.btnSaoLuu);
            this.grpSaoLuu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpSaoLuu.Location = new System.Drawing.Point(12, 52);
            this.grpSaoLuu.Name = "grpSaoLuu";
            this.grpSaoLuu.Size = new System.Drawing.Size(560, 120);
            this.grpSaoLuu.TabIndex = 1;
            this.grpSaoLuu.TabStop = false;
            this.grpSaoLuu.Text = "Xuất tất cả dữ liệu thành file SQL (6 bảng)";

            // lblDuongDanSaoLuu
            this.lblDuongDanSaoLuu.AutoSize = true;
            this.lblDuongDanSaoLuu.Location = new System.Drawing.Point(15, 30);
            this.lblDuongDanSaoLuu.Name = "lblDuongDanSaoLuu";
            this.lblDuongDanSaoLuu.Size = new System.Drawing.Size(120, 19);
            this.lblDuongDanSaoLuu.TabIndex = 0;
            this.lblDuongDanSaoLuu.Text = "Vị trí lưu file SQL:";

            // txtDuongDanSaoLuu
            this.txtDuongDanSaoLuu.Location = new System.Drawing.Point(15, 55);
            this.txtDuongDanSaoLuu.Name = "txtDuongDanSaoLuu";
            this.txtDuongDanSaoLuu.ReadOnly = true;
            this.txtDuongDanSaoLuu.Size = new System.Drawing.Size(400, 25);
            this.txtDuongDanSaoLuu.TabIndex = 1;

            // btnChonViTriSaoLuu
            this.btnChonViTriSaoLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
            this.btnChonViTriSaoLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonViTriSaoLuu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnChonViTriSaoLuu.ForeColor = System.Drawing.Color.White;
            this.btnChonViTriSaoLuu.Location = new System.Drawing.Point(425, 55);
            this.btnChonViTriSaoLuu.Name = "btnChonViTriSaoLuu";
            this.btnChonViTriSaoLuu.Size = new System.Drawing.Size(80, 25);
            this.btnChonViTriSaoLuu.TabIndex = 2;
            this.btnChonViTriSaoLuu.Text = "Chọn";
            this.btnChonViTriSaoLuu.UseVisualStyleBackColor = false;
            this.btnChonViTriSaoLuu.Click += new System.EventHandler(this.btnChonViTriSaoLuu_Click);

            // btnSaoLuu
            this.btnSaoLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnSaoLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaoLuu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSaoLuu.ForeColor = System.Drawing.Color.White;
            this.btnSaoLuu.Location = new System.Drawing.Point(425, 85);
            this.btnSaoLuu.Name = "btnSaoLuu";
            this.btnSaoLuu.Size = new System.Drawing.Size(120, 30);
            this.btnSaoLuu.TabIndex = 3;
            this.btnSaoLuu.Text = "Xuất SQL ngay";
            this.btnSaoLuu.UseVisualStyleBackColor = false;
            this.btnSaoLuu.Click += new System.EventHandler(this.btnSaoLuu_Click);

            // progressBar
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(12, 220);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(560, 23);
            this.progressBar.TabIndex = 3;
            this.progressBar.Visible = false;

            // lblTrangThai
            this.lblTrangThai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTrangThai.Location = new System.Drawing.Point(12, 190);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(560, 20);
            this.lblTrangThai.TabIndex = 4;
            this.lblTrangThai.Text = "Sẵn sàng xuất dữ liệu thành file SQL";
            this.lblTrangThai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // FormSaoLuu
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.lblTrangThai);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.grpSaoLuu);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormSaoLuu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sao lưu và phục hồi dữ liệu";
            this.Load += new System.EventHandler(this.FormSaoLuu_Load);
            this.grpSaoLuu.ResumeLayout(false);
            this.grpSaoLuu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpSaoLuu;
        private System.Windows.Forms.Button btnChonViTriSaoLuu;
        private System.Windows.Forms.TextBox txtDuongDanSaoLuu;
        private System.Windows.Forms.Label lblDuongDanSaoLuu;
        private System.Windows.Forms.Button btnSaoLuu;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblTrangThai;
    }
} 