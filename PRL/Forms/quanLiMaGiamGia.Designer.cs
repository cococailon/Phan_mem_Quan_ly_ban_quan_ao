namespace PRL.Forms
{
    partial class quanLiMaGiamGia
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
            label1 = new Label();
            groupBoxLoc = new GroupBox();
            buttonLoc = new Button();
            labelLocKKM = new Label();
            comboBoxLoc = new ComboBox();
            textBoxLocDen = new TextBox();
            labelLocKG = new Label();
            textBoxLocTu = new TextBox();
            label3 = new Label();
            buttonXem = new Button();
            numberUDSL = new NumericUpDown();
            dTPNHH = new DateTimePicker();
            dTPNT = new DateTimePicker();
            buttonTimKiem = new Button();
            textBoxTimKiem = new TextBox();
            buttonXoa = new Button();
            buttonSua = new Button();
            buttonThem = new Button();
            labelGhiChu = new Label();
            labelSL = new Label();
            labelTrangThai = new Label();
            labelMucGiam = new Label();
            labelKieuKM = new Label();
            labelNgayHetHan = new Label();
            labelNgayTao = new Label();
            labelMaKM = new Label();
            richTextBoxGhiChu = new RichTextBox();
            textBoxTrangThai = new TextBox();
            textBoxMucGiam = new TextBox();
            textBoxKieuKM = new TextBox();
            textBoxMaKM = new TextBox();
            dataGridView1 = new DataGridView();
            STT = new DataGridViewTextBoxColumn();
            labelFocus = new Label();
            groupBoxLoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numberUDSL).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(593, 224);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 86;
            // 
            // groupBoxLoc
            // 
            groupBoxLoc.Controls.Add(buttonLoc);
            groupBoxLoc.Controls.Add(labelLocKKM);
            groupBoxLoc.Controls.Add(comboBoxLoc);
            groupBoxLoc.Controls.Add(textBoxLocDen);
            groupBoxLoc.Controls.Add(labelLocKG);
            groupBoxLoc.Controls.Add(textBoxLocTu);
            groupBoxLoc.Controls.Add(label3);
            groupBoxLoc.Location = new Point(825, 262);
            groupBoxLoc.Margin = new Padding(3, 4, 3, 4);
            groupBoxLoc.Name = "groupBoxLoc";
            groupBoxLoc.Padding = new Padding(3, 4, 3, 4);
            groupBoxLoc.Size = new Size(429, 108);
            groupBoxLoc.TabIndex = 85;
            groupBoxLoc.TabStop = false;
            groupBoxLoc.Text = "Lọc";
            // 
            // buttonLoc
            // 
            buttonLoc.Location = new Point(8, 25);
            buttonLoc.Margin = new Padding(3, 4, 3, 4);
            buttonLoc.Name = "buttonLoc";
            buttonLoc.Size = new Size(80, 31);
            buttonLoc.TabIndex = 37;
            buttonLoc.Text = "Lọc";
            buttonLoc.UseVisualStyleBackColor = true;
            buttonLoc.Click += buttonLoc_Click;
            // 
            // labelLocKKM
            // 
            labelLocKKM.AutoSize = true;
            labelLocKKM.Location = new Point(138, 27);
            labelLocKKM.Name = "labelLocKKM";
            labelLocKKM.Size = new Size(125, 20);
            labelLocKKM.TabIndex = 25;
            labelLocKKM.Text = "Lọc theo Kiểu KM";
            // 
            // comboBoxLoc
            // 
            comboBoxLoc.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxLoc.FormattingEnabled = true;
            comboBoxLoc.Location = new Point(259, 21);
            comboBoxLoc.Margin = new Padding(3, 4, 3, 4);
            comboBoxLoc.Name = "comboBoxLoc";
            comboBoxLoc.Size = new Size(158, 28);
            comboBoxLoc.TabIndex = 22;
            // 
            // textBoxLocDen
            // 
            textBoxLocDen.Location = new Point(323, 71);
            textBoxLocDen.Margin = new Padding(3, 4, 3, 4);
            textBoxLocDen.Name = "textBoxLocDen";
            textBoxLocDen.Size = new Size(93, 27);
            textBoxLocDen.TabIndex = 34;
            // 
            // labelLocKG
            // 
            labelLocKG.AutoSize = true;
            labelLocKG.Location = new Point(8, 77);
            labelLocKG.Name = "labelLocKG";
            labelLocKG.Size = new Size(186, 20);
            labelLocKG.TabIndex = 26;
            labelLocKG.Text = "Lọc theo khoảng Số Lượng";
            // 
            // textBoxLocTu
            // 
            textBoxLocTu.Location = new Point(185, 71);
            textBoxLocTu.Margin = new Padding(3, 4, 3, 4);
            textBoxLocTu.Name = "textBoxLocTu";
            textBoxLocTu.Size = new Size(93, 27);
            textBoxLocTu.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(286, 77);
            label3.Name = "label3";
            label3.Size = new Size(34, 20);
            label3.TabIndex = 27;
            label3.Text = "đến";
            // 
            // buttonXem
            // 
            buttonXem.Location = new Point(287, 301);
            buttonXem.Margin = new Padding(3, 4, 3, 4);
            buttonXem.Name = "buttonXem";
            buttonXem.Size = new Size(199, 31);
            buttonXem.TabIndex = 84;
            buttonXem.Text = "Xem";
            buttonXem.UseVisualStyleBackColor = true;
            buttonXem.Click += buttonXem_Click;
            // 
            // numberUDSL
            // 
            numberUDSL.Location = new Point(872, 121);
            numberUDSL.Margin = new Padding(3, 4, 3, 4);
            numberUDSL.Maximum = new decimal(new int[] { 1569325055, 23283064, 0, 0 });
            numberUDSL.Name = "numberUDSL";
            numberUDSL.Size = new Size(157, 27);
            numberUDSL.TabIndex = 83;
            // 
            // dTPNHH
            // 
            dTPNHH.CustomFormat = " ";
            dTPNHH.Format = DateTimePickerFormat.Custom;
            dTPNHH.Location = new Point(181, 129);
            dTPNHH.Margin = new Padding(3, 4, 3, 4);
            dTPNHH.Name = "dTPNHH";
            dTPNHH.Size = new Size(305, 27);
            dTPNHH.TabIndex = 82;
            dTPNHH.ValueChanged += dTPNHH_ValueChanged;
            // 
            // dTPNT
            // 
            dTPNT.CustomFormat = " ";
            dTPNT.Format = DateTimePickerFormat.Custom;
            dTPNT.Location = new Point(181, 74);
            dTPNT.Margin = new Padding(3, 4, 3, 4);
            dTPNT.Name = "dTPNT";
            dTPNT.Size = new Size(305, 27);
            dTPNT.TabIndex = 81;
            dTPNT.ValueChanged += dTPNT_ValueChanged;
            // 
            // buttonTimKiem
            // 
            buttonTimKiem.Location = new Point(825, 220);
            buttonTimKiem.Margin = new Padding(3, 4, 3, 4);
            buttonTimKiem.Name = "buttonTimKiem";
            buttonTimKiem.Size = new Size(100, 31);
            buttonTimKiem.TabIndex = 80;
            buttonTimKiem.Text = "Tìm Kiếm";
            buttonTimKiem.UseVisualStyleBackColor = true;
            buttonTimKiem.Click += buttonTimKiem_Click;
            // 
            // textBoxTimKiem
            // 
            textBoxTimKiem.Location = new Point(931, 224);
            textBoxTimKiem.Margin = new Padding(3, 4, 3, 4);
            textBoxTimKiem.Name = "textBoxTimKiem";
            textBoxTimKiem.Size = new Size(322, 27);
            textBoxTimKiem.TabIndex = 79;
            // 
            // buttonXoa
            // 
            buttonXoa.Location = new Point(-7, 301);
            buttonXoa.Margin = new Padding(3, 4, 3, 4);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(199, 31);
            buttonXoa.TabIndex = 78;
            buttonXoa.Text = "Xóa";
            buttonXoa.UseVisualStyleBackColor = true;
            buttonXoa.Click += buttonXoa_Click;
            // 
            // buttonSua
            // 
            buttonSua.Location = new Point(287, 247);
            buttonSua.Margin = new Padding(3, 4, 3, 4);
            buttonSua.Name = "buttonSua";
            buttonSua.Size = new Size(199, 31);
            buttonSua.TabIndex = 77;
            buttonSua.Text = "Sửa";
            buttonSua.UseVisualStyleBackColor = true;
            buttonSua.Click += buttonSua_Click;
            // 
            // buttonThem
            // 
            buttonThem.Location = new Point(-7, 247);
            buttonThem.Margin = new Padding(3, 4, 3, 4);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(199, 31);
            buttonThem.TabIndex = 76;
            buttonThem.Text = "Thêm";
            buttonThem.UseVisualStyleBackColor = true;
            buttonThem.Click += buttonThem_Click;
            // 
            // labelGhiChu
            // 
            labelGhiChu.AutoSize = true;
            labelGhiChu.Location = new Point(1314, 202);
            labelGhiChu.Name = "labelGhiChu";
            labelGhiChu.Size = new Size(60, 20);
            labelGhiChu.TabIndex = 75;
            labelGhiChu.Text = "Ghi Chú";
            // 
            // labelSL
            // 
            labelSL.AutoSize = true;
            labelSL.Location = new Point(785, 128);
            labelSL.Name = "labelSL";
            labelSL.Size = new Size(72, 20);
            labelSL.TabIndex = 74;
            labelSL.Text = "Số Lượng";
            // 
            // labelTrangThai
            // 
            labelTrangThai.AutoSize = true;
            labelTrangThai.Location = new Point(780, 77);
            labelTrangThai.Name = "labelTrangThai";
            labelTrangThai.Size = new Size(78, 20);
            labelTrangThai.TabIndex = 73;
            labelTrangThai.Text = "Trạng Thái";
            // 
            // labelMucGiam
            // 
            labelMucGiam.AutoSize = true;
            labelMucGiam.Location = new Point(780, 26);
            labelMucGiam.Name = "labelMucGiam";
            labelMucGiam.Size = new Size(77, 20);
            labelMucGiam.TabIndex = 72;
            labelMucGiam.Text = "Mức Giảm";
            // 
            // labelKieuKM
            // 
            labelKieuKM.AutoSize = true;
            labelKieuKM.Location = new Point(35, 185);
            labelKieuKM.Name = "labelKieuKM";
            labelKieuKM.Size = new Size(119, 20);
            labelKieuKM.TabIndex = 71;
            labelKieuKM.Text = "Kiểu Khuyến Mãi";
            // 
            // labelNgayHetHan
            // 
            labelNgayHetHan.AutoSize = true;
            labelNgayHetHan.Location = new Point(35, 133);
            labelNgayHetHan.Name = "labelNgayHetHan";
            labelNgayHetHan.Size = new Size(103, 20);
            labelNgayHetHan.TabIndex = 70;
            labelNgayHetHan.Text = "Ngày Hết Hạn";
            // 
            // labelNgayTao
            // 
            labelNgayTao.AutoSize = true;
            labelNgayTao.Location = new Point(35, 78);
            labelNgayTao.Name = "labelNgayTao";
            labelNgayTao.Size = new Size(73, 20);
            labelNgayTao.TabIndex = 69;
            labelNgayTao.Text = "Ngày Tạo";
            // 
            // labelMaKM
            // 
            labelMaKM.AutoSize = true;
            labelMaKM.Location = new Point(35, 27);
            labelMaKM.Name = "labelMaKM";
            labelMaKM.Size = new Size(111, 20);
            labelMaKM.TabIndex = 68;
            labelMaKM.Text = "Mã Khuyến Mãi";
            // 
            // richTextBoxGhiChu
            // 
            richTextBoxGhiChu.Location = new Point(1314, 226);
            richTextBoxGhiChu.Margin = new Padding(3, 4, 3, 4);
            richTextBoxGhiChu.Name = "richTextBoxGhiChu";
            richTextBoxGhiChu.Size = new Size(158, 135);
            richTextBoxGhiChu.TabIndex = 67;
            richTextBoxGhiChu.Text = "";
            // 
            // textBoxTrangThai
            // 
            textBoxTrangThai.Location = new Point(872, 73);
            textBoxTrangThai.Margin = new Padding(3, 4, 3, 4);
            textBoxTrangThai.Name = "textBoxTrangThai";
            textBoxTrangThai.Size = new Size(378, 27);
            textBoxTrangThai.TabIndex = 66;
            // 
            // textBoxMucGiam
            // 
            textBoxMucGiam.Location = new Point(872, 22);
            textBoxMucGiam.Margin = new Padding(3, 4, 3, 4);
            textBoxMucGiam.Name = "textBoxMucGiam";
            textBoxMucGiam.Size = new Size(378, 27);
            textBoxMucGiam.TabIndex = 65;
            // 
            // textBoxKieuKM
            // 
            textBoxKieuKM.Location = new Point(180, 181);
            textBoxKieuKM.Margin = new Padding(3, 4, 3, 4);
            textBoxKieuKM.Name = "textBoxKieuKM";
            textBoxKieuKM.Size = new Size(306, 27);
            textBoxKieuKM.TabIndex = 64;
            // 
            // textBoxMaKM
            // 
            textBoxMaKM.Location = new Point(180, 23);
            textBoxMaKM.Margin = new Padding(3, 4, 3, 4);
            textBoxMaKM.Name = "textBoxMaKM";
            textBoxMaKM.Size = new Size(306, 27);
            textBoxMaKM.TabIndex = 63;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { STT });
            dataGridView1.Location = new Point(12, 376);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1480, 341);
            dataGridView1.TabIndex = 62;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.RowsAdded += dataGridView1_RowsAdded;
            // 
            // STT
            // 
            STT.HeaderText = "STT";
            STT.Name = "STT";
            STT.ReadOnly = true;
            // 
            // labelFocus
            // 
            labelFocus.AutoSize = true;
            labelFocus.Location = new Point(635, 320);
            labelFocus.Name = "labelFocus";
            labelFocus.Size = new Size(82, 20);
            labelFocus.TabIndex = 87;
            labelFocus.Text = "LabelFocus";
            labelFocus.Visible = false;
            // 
            // quanLiMaGiamGia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1504, 726);
            Controls.Add(labelFocus);
            Controls.Add(label1);
            Controls.Add(groupBoxLoc);
            Controls.Add(buttonXem);
            Controls.Add(numberUDSL);
            Controls.Add(dTPNHH);
            Controls.Add(dTPNT);
            Controls.Add(buttonTimKiem);
            Controls.Add(textBoxTimKiem);
            Controls.Add(buttonXoa);
            Controls.Add(buttonSua);
            Controls.Add(buttonThem);
            Controls.Add(labelGhiChu);
            Controls.Add(labelSL);
            Controls.Add(labelTrangThai);
            Controls.Add(labelMucGiam);
            Controls.Add(labelKieuKM);
            Controls.Add(labelNgayHetHan);
            Controls.Add(labelNgayTao);
            Controls.Add(labelMaKM);
            Controls.Add(richTextBoxGhiChu);
            Controls.Add(textBoxTrangThai);
            Controls.Add(textBoxMucGiam);
            Controls.Add(textBoxKieuKM);
            Controls.Add(textBoxMaKM);
            Controls.Add(dataGridView1);
            Name = "quanLiMaGiamGia";
            Text = "quanLiMaGiamGia";
            Load += Form_Ma_giam_gia_Load;
            MouseClick += Form_Ma_giam_gia_MouseClick;
            groupBoxLoc.ResumeLayout(false);
            groupBoxLoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numberUDSL).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBoxLoc;
        private Button buttonLoc;
        private Label labelLocKKM;
        private ComboBox comboBoxLoc;
        private TextBox textBoxLocDen;
        private Label labelLocKG;
        private TextBox textBoxLocTu;
        private Label label3;
        private Button buttonXem;
        private NumericUpDown numberUDSL;
        private DateTimePicker dTPNHH;
        private DateTimePicker dTPNT;
        private Button buttonTimKiem;
        private TextBox textBoxTimKiem;
        private Button buttonXoa;
        private Button buttonSua;
        private Button buttonThem;
        private Label labelGhiChu;
        private Label labelSL;
        private Label labelTrangThai;
        private Label labelMucGiam;
        private Label labelKieuKM;
        private Label labelNgayHetHan;
        private Label labelNgayTao;
        private Label labelMaKM;
        private RichTextBox richTextBoxGhiChu;
        private TextBox textBoxTrangThai;
        private TextBox textBoxMucGiam;
        private TextBox textBoxKieuKM;
        private TextBox textBoxMaKM;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn STT;
        private Label labelFocus;
    }
}