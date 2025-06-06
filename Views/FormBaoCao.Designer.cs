namespace QuanLyNhanVien.Views
{
    partial class FormBaoCao
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
            this.grpThongKePhongBan = new System.Windows.Forms.GroupBox();
            this.dgvThongKePhongBan = new System.Windows.Forms.DataGridView();
            this.grpDanhSachNhanVien = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachNhanVien = new System.Windows.Forms.DataGridView();
            this.grpThongKeGioiTinh = new System.Windows.Forms.GroupBox();
            this.dgvThongKeGioiTinh = new System.Windows.Forms.DataGridView();
            this.grpThongKeDoTuoi = new System.Windows.Forms.GroupBox();
            this.dgvThongKeDoTuoi = new System.Windows.Forms.DataGridView();
            this.lblTongQuan = new System.Windows.Forms.Label();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblTitle.Location = new System.Drawing.Point(400, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "BÁO CÁO NHÂN SỰ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // grpThongKePhongBan
            this.grpThongKePhongBan.Controls.Add(this.dgvThongKePhongBan);
            this.grpThongKePhongBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grpThongKePhongBan.Location = new System.Drawing.Point(12, 70);
            this.grpThongKePhongBan.Name = "grpThongKePhongBan";
            this.grpThongKePhongBan.Size = new System.Drawing.Size(380, 200);
            this.grpThongKePhongBan.TabIndex = 1;
            this.grpThongKePhongBan.Text = "Thống kê theo phòng ban";

            // dgvThongKePhongBan
            this.dgvThongKePhongBan.AllowUserToAddRows = false;
            this.dgvThongKePhongBan.AllowUserToDeleteRows = false;
            this.dgvThongKePhongBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongKePhongBan.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvThongKePhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKePhongBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThongKePhongBan.Location = new System.Drawing.Point(3, 22);
            this.dgvThongKePhongBan.Name = "dgvThongKePhongBan";
            this.dgvThongKePhongBan.ReadOnly = true;
            this.dgvThongKePhongBan.RowHeadersWidth = 51;
            this.dgvThongKePhongBan.Size = new System.Drawing.Size(374, 175);
            this.dgvThongKePhongBan.TabIndex = 0;

            // grpDanhSachNhanVien
            this.grpDanhSachNhanVien.Controls.Add(this.dgvDanhSachNhanVien);
            this.grpDanhSachNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grpDanhSachNhanVien.Location = new System.Drawing.Point(408, 70);
            this.grpDanhSachNhanVien.Name = "grpDanhSachNhanVien";
            this.grpDanhSachNhanVien.Size = new System.Drawing.Size(780, 250);
            this.grpDanhSachNhanVien.TabIndex = 2;
            this.grpDanhSachNhanVien.Text = "Danh sách nhân viên";

            // dgvDanhSachNhanVien
            this.dgvDanhSachNhanVien.AllowUserToAddRows = false;
            this.dgvDanhSachNhanVien.AllowUserToDeleteRows = false;
            this.dgvDanhSachNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachNhanVien.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvDanhSachNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachNhanVien.Location = new System.Drawing.Point(3, 22);
            this.dgvDanhSachNhanVien.Name = "dgvDanhSachNhanVien";
            this.dgvDanhSachNhanVien.ReadOnly = true;
            this.dgvDanhSachNhanVien.RowHeadersWidth = 51;
            this.dgvDanhSachNhanVien.Size = new System.Drawing.Size(774, 225);
            this.dgvDanhSachNhanVien.TabIndex = 0;

            // grpThongKeGioiTinh
            this.grpThongKeGioiTinh.Controls.Add(this.dgvThongKeGioiTinh);
            this.grpThongKeGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grpThongKeGioiTinh.Location = new System.Drawing.Point(12, 280);
            this.grpThongKeGioiTinh.Name = "grpThongKeGioiTinh";
            this.grpThongKeGioiTinh.Size = new System.Drawing.Size(380, 200);
            this.grpThongKeGioiTinh.TabIndex = 3;
            this.grpThongKeGioiTinh.Text = "Thống kê theo giới tính";

            // dgvThongKeGioiTinh
            this.dgvThongKeGioiTinh.AllowUserToAddRows = false;
            this.dgvThongKeGioiTinh.AllowUserToDeleteRows = false;
            this.dgvThongKeGioiTinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongKeGioiTinh.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvThongKeGioiTinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKeGioiTinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThongKeGioiTinh.Location = new System.Drawing.Point(3, 22);
            this.dgvThongKeGioiTinh.Name = "dgvThongKeGioiTinh";
            this.dgvThongKeGioiTinh.ReadOnly = true;
            this.dgvThongKeGioiTinh.RowHeadersWidth = 51;
            this.dgvThongKeGioiTinh.Size = new System.Drawing.Size(374, 175);
            this.dgvThongKeGioiTinh.TabIndex = 0;

            // grpThongKeDoTuoi
            this.grpThongKeDoTuoi.Controls.Add(this.dgvThongKeDoTuoi);
            this.grpThongKeDoTuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grpThongKeDoTuoi.Location = new System.Drawing.Point(12, 490);
            this.grpThongKeDoTuoi.Name = "grpThongKeDoTuoi";
            this.grpThongKeDoTuoi.Size = new System.Drawing.Size(380, 200);
            this.grpThongKeDoTuoi.TabIndex = 4;
            this.grpThongKeDoTuoi.Text = "Thống kê độ tuổi";

            // dgvThongKeDoTuoi
            this.dgvThongKeDoTuoi.AllowUserToAddRows = false;
            this.dgvThongKeDoTuoi.AllowUserToDeleteRows = false;
            this.dgvThongKeDoTuoi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongKeDoTuoi.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvThongKeDoTuoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKeDoTuoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThongKeDoTuoi.Location = new System.Drawing.Point(3, 22);
            this.dgvThongKeDoTuoi.Name = "dgvThongKeDoTuoi";
            this.dgvThongKeDoTuoi.ReadOnly = true;
            this.dgvThongKeDoTuoi.RowHeadersWidth = 51;
            this.dgvThongKeDoTuoi.Size = new System.Drawing.Size(374, 175);
            this.dgvThongKeDoTuoi.TabIndex = 0;

            // lblTongQuan
            this.lblTongQuan.AutoSize = true;
            this.lblTongQuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTongQuan.Location = new System.Drawing.Point(408, 340);
            this.lblTongQuan.Name = "lblTongQuan";
            this.lblTongQuan.Size = new System.Drawing.Size(780, 100);
            this.lblTongQuan.TabIndex = 5;
            this.lblTongQuan.Text = "Thông tin tổng quan:";

            // btnXuatExcel
            this.btnXuatExcel.BackColor = System.Drawing.Color.LightGreen;
            this.btnXuatExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnXuatExcel.Location = new System.Drawing.Point(408, 550);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(150, 40);
            this.btnXuatExcel.TabIndex = 6;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = false;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);

            // btnLamMoi
            this.btnLamMoi.BackColor = System.Drawing.Color.LightGray;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLamMoi.Location = new System.Drawing.Point(578, 550);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(150, 40);
            this.btnLamMoi.TabIndex = 7;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);

            // FormBaoCao
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXuatExcel);
            this.Controls.Add(this.lblTongQuan);
            this.Controls.Add(this.grpThongKeDoTuoi);
            this.Controls.Add(this.grpThongKeGioiTinh);
            this.Controls.Add(this.grpDanhSachNhanVien);
            this.Controls.Add(this.grpThongKePhongBan);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo nhân sự";
            this.grpThongKePhongBan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKePhongBan)).EndInit();
            this.grpDanhSachNhanVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNhanVien)).EndInit();
            this.grpThongKeGioiTinh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeGioiTinh)).EndInit();
            this.grpThongKeDoTuoi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeDoTuoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpThongKePhongBan;
        private System.Windows.Forms.DataGridView dgvThongKePhongBan;
        private System.Windows.Forms.GroupBox grpDanhSachNhanVien;
        private System.Windows.Forms.DataGridView dgvDanhSachNhanVien;
        private System.Windows.Forms.GroupBox grpThongKeGioiTinh;
        private System.Windows.Forms.DataGridView dgvThongKeGioiTinh;
        private System.Windows.Forms.GroupBox grpThongKeDoTuoi;
        private System.Windows.Forms.DataGridView dgvThongKeDoTuoi;
        private System.Windows.Forms.Label lblTongQuan;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Button btnLamMoi;
    }
} 