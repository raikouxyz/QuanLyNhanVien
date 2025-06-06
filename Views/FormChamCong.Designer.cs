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
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.dtpGioRa = new System.Windows.Forms.DateTimePicker();
            this.lblGioRa = new System.Windows.Forms.Label();
            this.dtpGioVao = new System.Windows.Forms.DateTimePicker();
            this.lblGioVao = new System.Windows.Forms.Label();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.lblNgay = new System.Windows.Forms.Label();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.grpChucNang = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvChamCong = new System.Windows.Forms.DataGridView();
            
            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblTitle.Location = new System.Drawing.Point(300, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ CHẤM CÔNG";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // grpThongTin
            this.grpThongTin.Controls.Add(this.dtpGioRa);
            this.grpThongTin.Controls.Add(this.lblGioRa);
            this.grpThongTin.Controls.Add(this.dtpGioVao);
            this.grpThongTin.Controls.Add(this.lblGioVao);
            this.grpThongTin.Controls.Add(this.dtpNgay);
            this.grpThongTin.Controls.Add(this.lblNgay);
            this.grpThongTin.Controls.Add(this.cboNhanVien);
            this.grpThongTin.Controls.Add(this.lblNhanVien);
            this.grpThongTin.Controls.Add(this.txtGhiChu);
            this.grpThongTin.Controls.Add(this.lblGhiChu);
            this.grpThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpThongTin.Location = new System.Drawing.Point(12, 70);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(976, 200);
            this.grpThongTin.TabIndex = 1;
            this.grpThongTin.Text = "Thông tin chấm công";

            // lblNhanVien
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Location = new System.Drawing.Point(20, 40);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(100, 20);
            this.lblNhanVien.TabIndex = 0;
            this.lblNhanVien.Text = "Nhân viên:";

            // cboNhanVien
            this.cboNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(130, 37);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(300, 28);
            this.cboNhanVien.TabIndex = 1;

            // lblNgay
            this.lblNgay.AutoSize = true;
            this.lblNgay.Location = new System.Drawing.Point(20, 80);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(100, 20);
            this.lblNgay.TabIndex = 2;
            this.lblNgay.Text = "Ngày:";

            // dtpNgay
            this.dtpNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgay.Location = new System.Drawing.Point(130, 77);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(300, 26);
            this.dtpNgay.TabIndex = 3;

            // lblGioVao
            this.lblGioVao.AutoSize = true;
            this.lblGioVao.Location = new System.Drawing.Point(20, 120);
            this.lblGioVao.Name = "lblGioVao";
            this.lblGioVao.Size = new System.Drawing.Size(100, 20);
            this.lblGioVao.TabIndex = 4;
            this.lblGioVao.Text = "Giờ vào:";

            // dtpGioVao
            this.dtpGioVao.CustomFormat = "HH:mm";
            this.dtpGioVao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpGioVao.Location = new System.Drawing.Point(130, 117);
            this.dtpGioVao.Name = "dtpGioVao";
            this.dtpGioVao.ShowUpDown = true;
            this.dtpGioVao.Size = new System.Drawing.Size(300, 26);
            this.dtpGioVao.TabIndex = 5;

            // lblGioRa
            this.lblGioRa.AutoSize = true;
            this.lblGioRa.Location = new System.Drawing.Point(500, 40);
            this.lblGioRa.Name = "lblGioRa";
            this.lblGioRa.Size = new System.Drawing.Size(100, 20);
            this.lblGioRa.TabIndex = 6;
            this.lblGioRa.Text = "Giờ ra:";

            // dtpGioRa
            this.dtpGioRa.CustomFormat = "HH:mm";
            this.dtpGioRa.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpGioRa.Location = new System.Drawing.Point(610, 37);
            this.dtpGioRa.Name = "dtpGioRa";
            this.dtpGioRa.ShowUpDown = true;
            this.dtpGioRa.Size = new System.Drawing.Size(300, 26);
            this.dtpGioRa.TabIndex = 7;

            // lblGhiChu
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Location = new System.Drawing.Point(500, 120);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(100, 20);
            this.lblGhiChu.TabIndex = 10;
            this.lblGhiChu.Text = "Ghi chú:";

            // txtGhiChu
            this.txtGhiChu.Location = new System.Drawing.Point(610, 117);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(300, 60);
            this.txtGhiChu.TabIndex = 11;

            // grpChucNang
            this.grpChucNang.Controls.Add(this.btnLamMoi);
            this.grpChucNang.Controls.Add(this.btnXoa);
            this.grpChucNang.Controls.Add(this.btnSua);
            this.grpChucNang.Controls.Add(this.btnThem);
            this.grpChucNang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpChucNang.Location = new System.Drawing.Point(12, 280);
            this.grpChucNang.Name = "grpChucNang";
            this.grpChucNang.Size = new System.Drawing.Size(976, 80);
            this.grpChucNang.TabIndex = 2;
            this.grpChucNang.Text = "Chức năng";

            // btnThem
            this.btnThem.BackColor = System.Drawing.Color.LightGreen;
            this.btnThem.Location = new System.Drawing.Point(130, 30);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(150, 35);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            // btnSua
            this.btnSua.BackColor = System.Drawing.Color.LightBlue;
            this.btnSua.Location = new System.Drawing.Point(330, 30);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(150, 35);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            // btnXoa
            this.btnXoa.BackColor = System.Drawing.Color.LightCoral;
            this.btnXoa.Location = new System.Drawing.Point(530, 30);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(150, 35);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            // btnLamMoi
            this.btnLamMoi.BackColor = System.Drawing.Color.LightGray;
            this.btnLamMoi.Location = new System.Drawing.Point(730, 30);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(150, 35);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);

            // dgvChamCong
            this.dgvChamCong.AllowUserToAddRows = false;
            this.dgvChamCong.AllowUserToDeleteRows = false;
            this.dgvChamCong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChamCong.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChamCong.Location = new System.Drawing.Point(12, 370);
            this.dgvChamCong.MultiSelect = false;
            this.dgvChamCong.Name = "dgvChamCong";
            this.dgvChamCong.ReadOnly = true;
            this.dgvChamCong.RowHeadersWidth = 51;
            this.dgvChamCong.RowTemplate.Height = 24;
            this.dgvChamCong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChamCong.Size = new System.Drawing.Size(976, 300);
            this.dgvChamCong.TabIndex = 3;
            this.dgvChamCong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChamCong_CellClick);

            // FormChamCong
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.dgvChamCong);
            this.Controls.Add(this.grpChucNang);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormChamCong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý chấm công";
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.grpChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.DateTimePicker dtpGioRa;
        private System.Windows.Forms.Label lblGioRa;
        private System.Windows.Forms.DateTimePicker dtpGioVao;
        private System.Windows.Forms.Label lblGioVao;
        private System.Windows.Forms.DateTimePicker dtpNgay;
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
    }
} 