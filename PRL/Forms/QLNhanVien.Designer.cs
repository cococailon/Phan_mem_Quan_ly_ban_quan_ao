namespace PRL.Forms
{
    partial class QLNhanVien
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
            components = new System.ComponentModel.Container();
            btnHienThi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvNoiDung = new DataGridView();
            STT = new DataGridViewTextBoxColumn();
            maNhanVienDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tenNhanVienDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            diaChiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            soDienThoaiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            gioiTinhDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            namSinhDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tenChucVuDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            trangThaiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tenDangNhapDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            matKhauDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ngayVaoLamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nhanvienBindingSource1 = new BindingSource(components);
            nhanvienBindingSource = new BindingSource(components);
            txtMaNV = new TextBox();
            txtTenNV = new TextBox();
            txtDiaChi = new TextBox();
            txtSDT = new TextBox();
            txtGioiTinh = new TextBox();
            dtpNamSinh = new DateTimePicker();
            txtChucVu = new TextBox();
            txtTrangThai = new TextBox();
            txtTenDangNhap = new TextBox();
            txtMatKhau = new TextBox();
            dtpNgayVaoLam = new DateTimePicker();
            groupBox1 = new GroupBox();
            btnLoc = new Button();
            CbCV = new ComboBox();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvNoiDung).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nhanvienBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nhanvienBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnHienThi
            // 
            btnHienThi.Location = new Point(783, 252);
            btnHienThi.Name = "btnHienThi";
            btnHienThi.Size = new Size(115, 60);
            btnHienThi.TabIndex = 60;
            btnHienThi.Text = "Hiển Thị";
            btnHienThi.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(590, 252);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(125, 60);
            btnXoa.TabIndex = 58;
            btnXoa.Text = "Xóa Nhân Viên";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click_1;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(375, 252);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(122, 60);
            btnSua.TabIndex = 57;
            btnSua.Text = "Cập Nhật Thông Tin";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click_1;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(143, 252);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(121, 60);
            btnThem.TabIndex = 56;
            btnThem.Text = "Thêm Nhân Viên";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click_1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(1081, 96);
            label11.Name = "label11";
            label11.Size = new Size(72, 20);
            label11.TabIndex = 44;
            label11.Text = "Mật Khẩu";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1074, 37);
            label10.Name = "label10";
            label10.Size = new Size(112, 20);
            label10.TabIndex = 43;
            label10.Text = "Tên Đăng Nhập";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1074, 150);
            label9.Name = "label9";
            label9.Size = new Size(105, 20);
            label9.TabIndex = 42;
            label9.Text = "Ngày Vào Làm";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(720, 205);
            label8.Name = "label8";
            label8.Size = new Size(78, 20);
            label8.TabIndex = 41;
            label8.Text = "Trạng Thái";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(720, 145);
            label7.Name = "label7";
            label7.Size = new Size(90, 20);
            label7.TabIndex = 40;
            label7.Text = "Tên Chức Vụ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(720, 93);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 39;
            label6.Text = "Năm Sinh";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(720, 37);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 38;
            label5.Text = "Giới Tính";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 205);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 37;
            label4.Text = "Số Điện Thoại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 145);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 36;
            label3.Text = "Địa Chỉ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 93);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 35;
            label2.Text = "Tên Nhân Viên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 37);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 34;
            label1.Text = "Mã Nhân Viên";
            // 
            // dgvNoiDung
            // 
            dgvNoiDung.AllowUserToAddRows = false;
            dgvNoiDung.AllowUserToDeleteRows = false;
            dgvNoiDung.AutoGenerateColumns = false;
            dgvNoiDung.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNoiDung.Columns.AddRange(new DataGridViewColumn[] { STT, maNhanVienDataGridViewTextBoxColumn, tenNhanVienDataGridViewTextBoxColumn, diaChiDataGridViewTextBoxColumn, soDienThoaiDataGridViewTextBoxColumn, gioiTinhDataGridViewTextBoxColumn, namSinhDataGridViewTextBoxColumn, tenChucVuDataGridViewTextBoxColumn, trangThaiDataGridViewTextBoxColumn, tenDangNhapDataGridViewTextBoxColumn, matKhauDataGridViewTextBoxColumn, ngayVaoLamDataGridViewTextBoxColumn });
            dgvNoiDung.DataSource = nhanvienBindingSource1;
            dgvNoiDung.Location = new Point(38, 318);
            dgvNoiDung.Name = "dgvNoiDung";
            dgvNoiDung.ReadOnly = true;
            dgvNoiDung.RowHeadersWidth = 51;
            dgvNoiDung.RowTemplate.Height = 29;
            dgvNoiDung.Size = new Size(1430, 375);
            dgvNoiDung.TabIndex = 33;
            dgvNoiDung.CellClick += dgvNoiDung_CellClick_1;
            // 
            // STT
            // 
            STT.DataPropertyName = "STT";
            STT.HeaderText = "STT";
            STT.MinimumWidth = 6;
            STT.Name = "STT";
            STT.ReadOnly = true;
            STT.Width = 50;
            // 
            // maNhanVienDataGridViewTextBoxColumn
            // 
            maNhanVienDataGridViewTextBoxColumn.DataPropertyName = "MaNhanVien";
            maNhanVienDataGridViewTextBoxColumn.HeaderText = "MaNhanVien";
            maNhanVienDataGridViewTextBoxColumn.Name = "maNhanVienDataGridViewTextBoxColumn";
            maNhanVienDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenNhanVienDataGridViewTextBoxColumn
            // 
            tenNhanVienDataGridViewTextBoxColumn.DataPropertyName = "TenNhanVien";
            tenNhanVienDataGridViewTextBoxColumn.HeaderText = "TenNhanVien";
            tenNhanVienDataGridViewTextBoxColumn.Name = "tenNhanVienDataGridViewTextBoxColumn";
            tenNhanVienDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            diaChiDataGridViewTextBoxColumn.HeaderText = "DiaChi";
            diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            diaChiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soDienThoaiDataGridViewTextBoxColumn
            // 
            soDienThoaiDataGridViewTextBoxColumn.DataPropertyName = "SoDienThoai";
            soDienThoaiDataGridViewTextBoxColumn.HeaderText = "SoDienThoai";
            soDienThoaiDataGridViewTextBoxColumn.Name = "soDienThoaiDataGridViewTextBoxColumn";
            soDienThoaiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gioiTinhDataGridViewTextBoxColumn
            // 
            gioiTinhDataGridViewTextBoxColumn.DataPropertyName = "GioiTinh";
            gioiTinhDataGridViewTextBoxColumn.HeaderText = "GioiTinh";
            gioiTinhDataGridViewTextBoxColumn.Name = "gioiTinhDataGridViewTextBoxColumn";
            gioiTinhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namSinhDataGridViewTextBoxColumn
            // 
            namSinhDataGridViewTextBoxColumn.DataPropertyName = "NamSinh";
            namSinhDataGridViewTextBoxColumn.HeaderText = "NamSinh";
            namSinhDataGridViewTextBoxColumn.Name = "namSinhDataGridViewTextBoxColumn";
            namSinhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenChucVuDataGridViewTextBoxColumn
            // 
            tenChucVuDataGridViewTextBoxColumn.DataPropertyName = "TenChucVu";
            tenChucVuDataGridViewTextBoxColumn.HeaderText = "TenChucVu";
            tenChucVuDataGridViewTextBoxColumn.Name = "tenChucVuDataGridViewTextBoxColumn";
            tenChucVuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trangThaiDataGridViewTextBoxColumn
            // 
            trangThaiDataGridViewTextBoxColumn.DataPropertyName = "TrangThai";
            trangThaiDataGridViewTextBoxColumn.HeaderText = "TrangThai";
            trangThaiDataGridViewTextBoxColumn.Name = "trangThaiDataGridViewTextBoxColumn";
            trangThaiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenDangNhapDataGridViewTextBoxColumn
            // 
            tenDangNhapDataGridViewTextBoxColumn.DataPropertyName = "TenDangNhap";
            tenDangNhapDataGridViewTextBoxColumn.HeaderText = "TenDangNhap";
            tenDangNhapDataGridViewTextBoxColumn.Name = "tenDangNhapDataGridViewTextBoxColumn";
            tenDangNhapDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // matKhauDataGridViewTextBoxColumn
            // 
            matKhauDataGridViewTextBoxColumn.DataPropertyName = "MatKhau";
            matKhauDataGridViewTextBoxColumn.HeaderText = "MatKhau";
            matKhauDataGridViewTextBoxColumn.Name = "matKhauDataGridViewTextBoxColumn";
            matKhauDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngayVaoLamDataGridViewTextBoxColumn
            // 
            ngayVaoLamDataGridViewTextBoxColumn.DataPropertyName = "NgayVaoLam";
            ngayVaoLamDataGridViewTextBoxColumn.HeaderText = "NgayVaoLam";
            ngayVaoLamDataGridViewTextBoxColumn.Name = "ngayVaoLamDataGridViewTextBoxColumn";
            ngayVaoLamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nhanvienBindingSource1
            // 
            nhanvienBindingSource1.DataSource = typeof(DAL.Models.Nhanvien);
            // 
            // nhanvienBindingSource
            // 
            nhanvienBindingSource.DataSource = typeof(DAL.Models.Nhanvien);
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(170, 34);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(407, 27);
            txtMaNV.TabIndex = 45;
            txtMaNV.TabStop = false;
            // 
            // txtTenNV
            // 
            txtTenNV.Location = new Point(170, 90);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(407, 27);
            txtTenNV.TabIndex = 47;
            txtTenNV.TabStop = false;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(170, 142);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(407, 27);
            txtDiaChi.TabIndex = 46;
            txtDiaChi.TabStop = false;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(170, 198);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(407, 27);
            txtSDT.TabIndex = 49;
            txtSDT.TabStop = false;
            // 
            // txtGioiTinh
            // 
            txtGioiTinh.Location = new Point(831, 34);
            txtGioiTinh.Name = "txtGioiTinh";
            txtGioiTinh.Size = new Size(202, 27);
            txtGioiTinh.TabIndex = 48;
            txtGioiTinh.TabStop = false;
            // 
            // dtpNamSinh
            // 
            dtpNamSinh.Format = DateTimePickerFormat.Short;
            dtpNamSinh.Location = new Point(831, 88);
            dtpNamSinh.Name = "dtpNamSinh";
            dtpNamSinh.Size = new Size(202, 27);
            dtpNamSinh.TabIndex = 54;
            dtpNamSinh.TabStop = false;
            // 
            // txtChucVu
            // 
            txtChucVu.Location = new Point(831, 142);
            txtChucVu.Name = "txtChucVu";
            txtChucVu.Size = new Size(202, 27);
            txtChucVu.TabIndex = 53;
            txtChucVu.TabStop = false;
            // 
            // txtTrangThai
            // 
            txtTrangThai.Location = new Point(831, 202);
            txtTrangThai.Name = "txtTrangThai";
            txtTrangThai.Size = new Size(202, 27);
            txtTrangThai.TabIndex = 52;
            txtTrangThai.TabStop = false;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(1210, 34);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(213, 27);
            txtTenDangNhap.TabIndex = 51;
            txtTenDangNhap.TabStop = false;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(1210, 89);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(213, 27);
            txtMatKhau.TabIndex = 50;
            txtMatKhau.TabStop = false;
            // 
            // dtpNgayVaoLam
            // 
            dtpNgayVaoLam.Format = DateTimePickerFormat.Short;
            dtpNgayVaoLam.Location = new Point(1210, 145);
            dtpNgayVaoLam.Name = "dtpNgayVaoLam";
            dtpNgayVaoLam.Size = new Size(213, 27);
            dtpNgayVaoLam.TabIndex = 55;
            dtpNgayVaoLam.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLoc);
            groupBox1.Controls.Add(CbCV);
            groupBox1.Controls.Add(txtTimKiem);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Location = new Point(1074, 187);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(394, 125);
            groupBox1.TabIndex = 59;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lọc";
            // 
            // btnLoc
            // 
            btnLoc.Location = new Point(325, 32);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(50, 44);
            btnLoc.TabIndex = 28;
            btnLoc.UseVisualStyleBackColor = true;
            btnLoc.Click += btnLoc_Click;
            // 
            // CbCV
            // 
            CbCV.FormattingEnabled = true;
            CbCV.Location = new Point(7, 42);
            CbCV.Name = "CbCV";
            CbCV.Size = new Size(312, 28);
            CbCV.TabIndex = 30;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(124, 82);
            txtTimKiem.Multiline = true;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(264, 34);
            txtTimKiem.TabIndex = 29;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(7, 82);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(105, 37);
            btnTimKiem.TabIndex = 27;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // QLNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1504, 726);
            Controls.Add(btnHienThi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvNoiDung);
            Controls.Add(txtMaNV);
            Controls.Add(txtTenNV);
            Controls.Add(txtDiaChi);
            Controls.Add(txtSDT);
            Controls.Add(txtGioiTinh);
            Controls.Add(dtpNamSinh);
            Controls.Add(txtChucVu);
            Controls.Add(txtTrangThai);
            Controls.Add(txtTenDangNhap);
            Controls.Add(txtMatKhau);
            Controls.Add(dtpNgayVaoLam);
            Controls.Add(groupBox1);
            Name = "QLNhanVien";
            Text = "NhanVien";
            Load += NhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNoiDung).EndInit();
            ((System.ComponentModel.ISupportInitialize)nhanvienBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nhanvienBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHienThi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvNoiDung;
        private TextBox txtMaNV;
        private TextBox txtTenNV;
        private TextBox txtDiaChi;
        private TextBox txtSDT;
        private TextBox txtGioiTinh;
        private DateTimePicker dtpNamSinh;
        private TextBox txtChucVu;
        private TextBox txtTrangThai;
        private TextBox txtTenDangNhap;
        private TextBox txtMatKhau;
        private DateTimePicker dtpNgayVaoLam;
        private GroupBox groupBox1;
        private Button btnLoc;
        private ComboBox CbCV;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private DataGridViewTextBoxColumn chucVuDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maTaiKhoanDataGridViewTextBoxColumn;
        private BindingSource nhanvienBindingSource;
        private BindingSource nhanvienBindingSource1;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn maNhanVienDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenNhanVienDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soDienThoaiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn namSinhDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenChucVuDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn trangThaiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenDangNhapDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn matKhauDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ngayVaoLamDataGridViewTextBoxColumn;
    }
}