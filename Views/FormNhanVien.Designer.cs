namespace QuanLyNhanVien.Views
{
    partial class FormNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvNhanVien; // Bảng hiển thị danh sách nhân viên
        private System.Windows.Forms.TextBox txtTimKiem; // Ô tìm kiếm
        private System.Windows.Forms.Button btnThem; // Nút thêm
        private System.Windows.Forms.Button btnXoa; // Nút xóa
        private System.Windows.Forms.Button btnSua; // Nút sửa
        private System.Windows.Forms.Button btnTimKiem; // Nút tìm kiếm
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.ComboBox cmbGioiTinh; // Thay cho txtGioiTinh
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblSoDT;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.Label lblPhongBan;
        private System.Windows.Forms.TextBox txtPhongBan;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.Label lblNgayVaoLam;
        private System.Windows.Forms.DateTimePicker dtpNgayVaoLam;
        private System.Windows.Forms.ComboBox cmbPhongBan; // ComboBox cho phòng ban

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
            dgvNhanVien = new System.Windows.Forms.DataGridView();
            txtTimKiem = new System.Windows.Forms.TextBox();
            btnThem = new System.Windows.Forms.Button();
            btnXoa = new System.Windows.Forms.Button();
            btnSua = new System.Windows.Forms.Button();
            btnTimKiem = new System.Windows.Forms.Button();
            lblHoTen = new System.Windows.Forms.Label();
            txtHoTen = new System.Windows.Forms.TextBox();
            lblNgaySinh = new System.Windows.Forms.Label();
            dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            lblGioiTinh = new System.Windows.Forms.Label();
            cmbGioiTinh = new System.Windows.Forms.ComboBox();
            lblDiaChi = new System.Windows.Forms.Label();
            txtDiaChi = new System.Windows.Forms.TextBox();
            lblSoDT = new System.Windows.Forms.Label();
            txtSoDT = new System.Windows.Forms.TextBox();
            lblPhongBan = new System.Windows.Forms.Label();
            lblChucVu = new System.Windows.Forms.Label();
            txtChucVu = new System.Windows.Forms.TextBox();
            lblNgayVaoLam = new System.Windows.Forms.Label();
            dtpNgayVaoLam = new System.Windows.Forms.DateTimePicker();
            cmbPhongBan = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.Location = new System.Drawing.Point(306, 53);
            dgvNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.ReadOnly = true;
            dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvNhanVien.Size = new System.Drawing.Size(470, 240);
            dgvNhanVien.TabIndex = 2;
            dgvNhanVien.SelectionChanged += dgvNhanVien_SelectionChanged;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new System.Drawing.Point(306, 15);
            txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new System.Drawing.Size(263, 23);
            txtTimKiem.TabIndex = 0;
            // 
            // btnThem
            // 
            btnThem.Location = new System.Drawing.Point(175, 314);
            btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnThem.Name = "btnThem";
            btnThem.Size = new System.Drawing.Size(88, 30);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new System.Drawing.Point(306, 314);
            btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new System.Drawing.Size(88, 30);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new System.Drawing.Point(438, 314);
            btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnSua.Name = "btnSua";
            btnSua.Size = new System.Drawing.Size(88, 30);
            btnSua.TabIndex = 5;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new System.Drawing.Point(602, 16);
            btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new System.Drawing.Size(88, 22);
            btnTimKiem.TabIndex = 1;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // lblHoTen
            // 
            lblHoTen.Location = new System.Drawing.Point(18, 60);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new System.Drawing.Size(80, 20);
            lblHoTen.TabIndex = 6;
            lblHoTen.Text = "Họ tên";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new System.Drawing.Point(110, 60);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new System.Drawing.Size(180, 23);
            txtHoTen.TabIndex = 7;
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.Location = new System.Drawing.Point(18, 90);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new System.Drawing.Size(80, 20);
            lblNgaySinh.TabIndex = 8;
            lblNgaySinh.Text = "Ngày sinh";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Location = new System.Drawing.Point(110, 90);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new System.Drawing.Size(180, 23);
            dtpNgaySinh.TabIndex = 9;
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.Location = new System.Drawing.Point(18, 120);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new System.Drawing.Size(80, 20);
            lblGioiTinh.TabIndex = 10;
            lblGioiTinh.Text = "Giới tính";
            // 
            // cmbGioiTinh
            // 
            cmbGioiTinh.Location = new System.Drawing.Point(110, 120);
            cmbGioiTinh.Name = "cmbGioiTinh";
            cmbGioiTinh.Size = new System.Drawing.Size(180, 23);
            cmbGioiTinh.TabIndex = 11;
            cmbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbGioiTinh.Items.AddRange(new object[] {"Nam", "Nữ"});
            // 
            // lblDiaChi
            // 
            lblDiaChi.Location = new System.Drawing.Point(18, 150);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new System.Drawing.Size(80, 20);
            lblDiaChi.TabIndex = 12;
            lblDiaChi.Text = "Địa chỉ";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new System.Drawing.Point(110, 150);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new System.Drawing.Size(180, 23);
            txtDiaChi.TabIndex = 13;
            // 
            // lblSoDT
            // 
            lblSoDT.Location = new System.Drawing.Point(18, 180);
            lblSoDT.Name = "lblSoDT";
            lblSoDT.Size = new System.Drawing.Size(80, 20);
            lblSoDT.TabIndex = 14;
            lblSoDT.Text = "Số ĐT";
            // 
            // txtSoDT
            // 
            txtSoDT.Location = new System.Drawing.Point(110, 180);
            txtSoDT.Name = "txtSoDT";
            txtSoDT.Size = new System.Drawing.Size(180, 23);
            txtSoDT.TabIndex = 15;
            // 
            // lblPhongBan
            // 
            lblPhongBan.Location = new System.Drawing.Point(18, 210);
            lblPhongBan.Name = "lblPhongBan";
            lblPhongBan.Size = new System.Drawing.Size(80, 20);
            lblPhongBan.TabIndex = 16;
            lblPhongBan.Text = "Phòng ban";
            // 
            // lblChucVu
            // 
            lblChucVu.Location = new System.Drawing.Point(18, 240);
            lblChucVu.Name = "lblChucVu";
            lblChucVu.Size = new System.Drawing.Size(80, 20);
            lblChucVu.TabIndex = 18;
            lblChucVu.Text = "Chức vụ";
            // 
            // txtChucVu
            // 
            txtChucVu.Location = new System.Drawing.Point(110, 240);
            txtChucVu.Name = "txtChucVu";
            txtChucVu.Size = new System.Drawing.Size(180, 23);
            txtChucVu.TabIndex = 19;
            // 
            // lblNgayVaoLam
            // 
            lblNgayVaoLam.Location = new System.Drawing.Point(18, 270);
            lblNgayVaoLam.Name = "lblNgayVaoLam";
            lblNgayVaoLam.Size = new System.Drawing.Size(90, 20);
            lblNgayVaoLam.TabIndex = 20;
            lblNgayVaoLam.Text = "Ngày vào làm";
            // 
            // dtpNgayVaoLam
            // 
            dtpNgayVaoLam.Location = new System.Drawing.Point(110, 270);
            dtpNgayVaoLam.Name = "dtpNgayVaoLam";
            dtpNgayVaoLam.Size = new System.Drawing.Size(180, 23);
            dtpNgayVaoLam.TabIndex = 21;
            // 
            // cmbPhongBan
            // 
            cmbPhongBan.Location = new System.Drawing.Point(110, 210);
            cmbPhongBan.Name = "cmbPhongBan";
            cmbPhongBan.Size = new System.Drawing.Size(180, 23);
            cmbPhongBan.TabIndex = 22;
            // 
            // FormNhanVien
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(788, 375);
            Controls.Add(txtTimKiem);
            Controls.Add(btnTimKiem);
            Controls.Add(dgvNhanVien);
            Controls.Add(btnThem);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(lblHoTen);
            Controls.Add(txtHoTen);
            Controls.Add(lblNgaySinh);
            Controls.Add(dtpNgaySinh);
            Controls.Add(lblGioiTinh);
            Controls.Add(cmbGioiTinh);
            Controls.Add(lblDiaChi);
            Controls.Add(txtDiaChi);
            Controls.Add(lblSoDT);
            Controls.Add(txtSoDT);
            Controls.Add(lblPhongBan);
            Controls.Add(lblChucVu);
            Controls.Add(txtChucVu);
            Controls.Add(lblNgayVaoLam);
            Controls.Add(dtpNgayVaoLam);
            Controls.Add(cmbPhongBan);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "FormNhanVien";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Quản lý thông tin nhân viên";
            Load += NhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
    }
}