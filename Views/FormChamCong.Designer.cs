namespace QuanLyNhanVien.Views
{
    partial class FormChamCong
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
            lblTitle = new System.Windows.Forms.Label();
            grpThongTin = new System.Windows.Forms.GroupBox();
            dtpGioRa = new System.Windows.Forms.DateTimePicker();
            lblGioRa = new System.Windows.Forms.Label();
            dtpGioVao = new System.Windows.Forms.DateTimePicker();
            lblGioVao = new System.Windows.Forms.Label();
            cboNgay = new System.Windows.Forms.ComboBox();
            lblNgay = new System.Windows.Forms.Label();
            cboNhanVien = new System.Windows.Forms.ComboBox();
            lblNhanVien = new System.Windows.Forms.Label();
            txtGhiChu = new System.Windows.Forms.TextBox();
            lblGhiChu = new System.Windows.Forms.Label();
            dtpThang = new System.Windows.Forms.DateTimePicker();
            lblThang = new System.Windows.Forms.Label();
            txtTimKiem = new System.Windows.Forms.TextBox();
            lblTimKiem = new System.Windows.Forms.Label();
            btnTimKiem = new System.Windows.Forms.Button();
            grpChucNang = new System.Windows.Forms.GroupBox();
            btnLamMoi = new System.Windows.Forms.Button();
            btnXoa = new System.Windows.Forms.Button();
            btnSua = new System.Windows.Forms.Button();
            btnThem = new System.Windows.Forms.Button();
            btnXoaHet = new System.Windows.Forms.Button();
            dgvChamCong = new System.Windows.Forms.DataGridView();
            grpThongTin.SuspendLayout();
            grpChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChamCong).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblTitle.ForeColor = System.Drawing.Color.Blue;
            lblTitle.Location = new System.Drawing.Point(262, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(270, 26);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "QUẢN LÝ CHẤM CÔNG";
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpThongTin
            // 
            grpThongTin.Controls.Add(dtpGioRa);
            grpThongTin.Controls.Add(lblGioRa);
            grpThongTin.Controls.Add(dtpGioVao);
            grpThongTin.Controls.Add(lblGioVao);
            grpThongTin.Controls.Add(cboNgay);
            grpThongTin.Controls.Add(lblNgay);
            grpThongTin.Controls.Add(cboNhanVien);
            grpThongTin.Controls.Add(lblNhanVien);
            grpThongTin.Controls.Add(txtGhiChu);
            grpThongTin.Controls.Add(lblGhiChu);
            grpThongTin.Controls.Add(dtpThang);
            grpThongTin.Controls.Add(lblThang);
            grpThongTin.Controls.Add(txtTimKiem);
            grpThongTin.Controls.Add(lblTimKiem);
            grpThongTin.Controls.Add(btnTimKiem);
            grpThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            grpThongTin.Location = new System.Drawing.Point(10, 66);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Size = new System.Drawing.Size(854, 188);
            grpThongTin.TabIndex = 1;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin chấm công";
            // 
            // dtpGioRa
            // 
            dtpGioRa.CustomFormat = "HH:mm";
            dtpGioRa.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpGioRa.Location = new System.Drawing.Point(534, 35);
            dtpGioRa.Name = "dtpGioRa";
            dtpGioRa.ShowUpDown = true;
            dtpGioRa.Size = new System.Drawing.Size(263, 23);
            dtpGioRa.TabIndex = 9;
            // 
            // lblGioRa
            // 
            lblGioRa.AutoSize = true;
            lblGioRa.Location = new System.Drawing.Point(438, 38);
            lblGioRa.Name = "lblGioRa";
            lblGioRa.Size = new System.Drawing.Size(51, 17);
            lblGioRa.TabIndex = 8;
            lblGioRa.Text = "Giờ ra:";
            // 
            // dtpGioVao
            // 
            dtpGioVao.CustomFormat = "HH:mm";
            dtpGioVao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpGioVao.Location = new System.Drawing.Point(114, 110);
            dtpGioVao.Name = "dtpGioVao";
            dtpGioVao.ShowUpDown = true;
            dtpGioVao.Size = new System.Drawing.Size(263, 23);
            dtpGioVao.TabIndex = 7;
            // 
            // lblGioVao
            // 
            lblGioVao.AutoSize = true;
            lblGioVao.Location = new System.Drawing.Point(18, 112);
            lblGioVao.Name = "lblGioVao";
            lblGioVao.Size = new System.Drawing.Size(61, 17);
            lblGioVao.TabIndex = 6;
            lblGioVao.Text = "Giờ vào:";
            // 
            // cboNgay
            // 
            cboNgay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboNgay.FormattingEnabled = true;
            cboNgay.Location = new System.Drawing.Point(114, 110);
            cboNgay.Name = "cboNgay";
            cboNgay.Size = new System.Drawing.Size(263, 24);
            cboNgay.TabIndex = 5;
            // 
            // lblNgay
            // 
            lblNgay.AutoSize = true;
            lblNgay.Location = new System.Drawing.Point(18, 112);
            lblNgay.Name = "lblNgay";
            lblNgay.Size = new System.Drawing.Size(45, 17);
            lblNgay.TabIndex = 4;
            lblNgay.Text = "Ngày:";
            // 
            // cboNhanVien
            // 
            cboNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new System.Drawing.Point(114, 72);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new System.Drawing.Size(263, 24);
            cboNhanVien.TabIndex = 1;
            // 
            // lblNhanVien
            // 
            lblNhanVien.AutoSize = true;
            lblNhanVien.Location = new System.Drawing.Point(18, 75);
            lblNhanVien.Name = "lblNhanVien";
            lblNhanVien.Size = new System.Drawing.Size(76, 17);
            lblNhanVien.TabIndex = 2;
            lblNhanVien.Text = "Nhân viên:";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new System.Drawing.Point(534, 110);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new System.Drawing.Size(263, 56);
            txtGhiChu.TabIndex = 13;
            // 
            // lblGhiChu
            // 
            lblGhiChu.AutoSize = true;
            lblGhiChu.Location = new System.Drawing.Point(438, 112);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new System.Drawing.Size(61, 17);
            lblGhiChu.TabIndex = 12;
            lblGhiChu.Text = "Ghi chú:";
            // 
            // dtpThang
            // 
            dtpThang.CustomFormat = "MM/yyyy";
            dtpThang.Enabled = false;
            dtpThang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpThang.Location = new System.Drawing.Point(114, 35);
            dtpThang.Name = "dtpThang";
            dtpThang.Size = new System.Drawing.Size(176, 23);
            dtpThang.TabIndex = 1;
            // 
            // lblThang
            // 
            lblThang.AutoSize = true;
            lblThang.Location = new System.Drawing.Point(18, 38);
            lblThang.Name = "lblThang";
            lblThang.Size = new System.Drawing.Size(86, 17);
            lblThang.TabIndex = 0;
            lblThang.Text = "Tháng/Năm:";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new System.Drawing.Point(534, 72);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Nhập tên nhân viên...";
            txtTimKiem.Size = new System.Drawing.Size(176, 23);
            txtTimKiem.TabIndex = 11;
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.Location = new System.Drawing.Point(438, 75);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new System.Drawing.Size(68, 17);
            lblTimKiem.TabIndex = 10;
            lblTimKiem.Text = "Tìm kiếm:";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new System.Drawing.Point(718, 70);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new System.Drawing.Size(79, 28);
            btnTimKiem.TabIndex = 12;
            btnTimKiem.Text = "Tìm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // grpChucNang
            // 
            grpChucNang.Controls.Add(btnLamMoi);
            grpChucNang.Controls.Add(btnXoa);
            grpChucNang.Controls.Add(btnSua);
            grpChucNang.Controls.Add(btnThem);
            grpChucNang.Controls.Add(btnXoaHet);
            grpChucNang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            grpChucNang.Location = new System.Drawing.Point(10, 262);
            grpChucNang.Name = "grpChucNang";
            grpChucNang.Size = new System.Drawing.Size(854, 75);
            grpChucNang.TabIndex = 2;
            grpChucNang.TabStop = false;
            grpChucNang.Text = "Chức năng";
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = System.Drawing.Color.LightGray;
            btnLamMoi.Location = new System.Drawing.Point(681, 28);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new System.Drawing.Size(131, 33);
            btnLamMoi.TabIndex = 3;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = System.Drawing.Color.LightCoral;
            btnXoa.Location = new System.Drawing.Point(368, 28);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new System.Drawing.Size(131, 33);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = System.Drawing.Color.LightBlue;
            btnSua.Location = new System.Drawing.Point(208, 28);
            btnSua.Name = "btnSua";
            btnSua.Size = new System.Drawing.Size(131, 33);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = System.Drawing.Color.LightGreen;
            btnThem.Location = new System.Drawing.Point(40, 28);
            btnThem.Name = "btnThem";
            btnThem.Size = new System.Drawing.Size(131, 33);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoaHet
            // 
            btnXoaHet.BackColor = System.Drawing.Color.OrangeRed;
            btnXoaHet.Location = new System.Drawing.Point(523, 28);
            btnXoaHet.Name = "btnXoaHet";
            btnXoaHet.Size = new System.Drawing.Size(131, 33);
            btnXoaHet.TabIndex = 4;
            btnXoaHet.Text = "Xóa hết";
            btnXoaHet.UseVisualStyleBackColor = false;
            btnXoaHet.Click += btnXoaHet_Click;
            // 
            // dgvChamCong
            // 
            dgvChamCong.AllowUserToAddRows = false;
            dgvChamCong.AllowUserToDeleteRows = false;
            dgvChamCong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvChamCong.BackgroundColor = System.Drawing.SystemColors.Window;
            dgvChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChamCong.Location = new System.Drawing.Point(10, 347);
            dgvChamCong.MultiSelect = false;
            dgvChamCong.Name = "dgvChamCong";
            dgvChamCong.ReadOnly = true;
            dgvChamCong.RowHeadersWidth = 51;
            dgvChamCong.RowTemplate.Height = 24;
            dgvChamCong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvChamCong.Size = new System.Drawing.Size(854, 281);
            dgvChamCong.TabIndex = 3;
            dgvChamCong.CellClick += dgvChamCong_CellClick;
            // 
            // FormChamCong
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(875, 656);
            Controls.Add(dgvChamCong);
            Controls.Add(grpChucNang);
            Controls.Add(grpThongTin);
            Controls.Add(lblTitle);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormChamCong";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Quản lý chấm công";
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            grpChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvChamCong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.DateTimePicker dtpGioRa;
        private System.Windows.Forms.Label lblGioRa;
        private System.Windows.Forms.DateTimePicker dtpGioVao;
        private System.Windows.Forms.Label lblGioVao;
        private System.Windows.Forms.ComboBox cboNgay;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.GroupBox grpChucNang;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvChamCong;
        private System.Windows.Forms.DateTimePicker dtpThang;
        private System.Windows.Forms.Label lblThang;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnXoaHet;
    }
} 