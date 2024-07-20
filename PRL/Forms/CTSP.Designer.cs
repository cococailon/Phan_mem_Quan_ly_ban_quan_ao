namespace PRL.Forms
{
    partial class CTSP
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
            TimMS = new ComboBox();
            TimCL = new ComboBox();
            TimKT = new ComboBox();
            txtTimTen = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label9 = new Label();
            label14 = new Label();
            cmbSale = new ComboBox();
            TimMa = new ComboBox();
            TimSL = new ComboBox();
            radDangBan = new RadioButton();
            label11 = new Label();
            groupBox1 = new GroupBox();
            label12 = new Label();
            radNgungBan = new RadioButton();
            cmbMS = new ComboBox();
            cmbCL = new ComboBox();
            cmbKT = new ComboBox();
            cmbMaSP = new ComboBox();
            label13 = new Label();
            dtgView = new DataGridView();
            label10 = new Label();
            button3 = new Button();
            button2 = new Button();
            btnThem = new Button();
            label7 = new Label();
            label8 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtSoLuong = new TextBox();
            txtGia = new TextBox();
            label2 = new Label();
            txtTenSP = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgView).BeginInit();
            SuspendLayout();
            // 
            // TimMS
            // 
            TimMS.DropDownStyle = ComboBoxStyle.DropDownList;
            TimMS.FormattingEnabled = true;
            TimMS.Location = new Point(728, 70);
            TimMS.Name = "TimMS";
            TimMS.Size = new Size(103, 28);
            TimMS.TabIndex = 86;
            TimMS.SelectedIndexChanged += TimMS_SelectedIndexChanged;
            // 
            // TimCL
            // 
            TimCL.DropDownStyle = ComboBoxStyle.DropDownList;
            TimCL.FormattingEnabled = true;
            TimCL.Location = new Point(594, 70);
            TimCL.Name = "TimCL";
            TimCL.Size = new Size(103, 28);
            TimCL.TabIndex = 86;
            TimCL.SelectedIndexChanged += TimCL_SelectedIndexChanged;
            // 
            // TimKT
            // 
            TimKT.DropDownStyle = ComboBoxStyle.DropDownList;
            TimKT.FormattingEnabled = true;
            TimKT.Location = new Point(460, 70);
            TimKT.Name = "TimKT";
            TimKT.Size = new Size(103, 28);
            TimKT.TabIndex = 86;
            TimKT.SelectedIndexChanged += TimKT_SelectedIndexChanged;
            // 
            // txtTimTen
            // 
            txtTimTen.Location = new Point(16, 70);
            txtTimTen.Name = "txtTimTen";
            txtTimTen.Size = new Size(270, 27);
            txtTimTen.TabIndex = 1;
            txtTimTen.TextChanged += txtTimTen_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 37);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên sản phẩm:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(460, 37);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 75;
            label3.Text = "Kích Thước";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(594, 37);
            label9.Name = "label9";
            label9.Size = new Size(70, 20);
            label9.TabIndex = 78;
            label9.Text = "Chất Liệu";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(326, 37);
            label14.Name = "label14";
            label14.Size = new Size(102, 20);
            label14.TabIndex = 88;
            label14.Text = "Mã Sản Phẩm:";
            // 
            // cmbSale
            // 
            cmbSale.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSale.FormattingEnabled = true;
            cmbSale.Location = new Point(1255, 72);
            cmbSale.Name = "cmbSale";
            cmbSale.Size = new Size(151, 28);
            cmbSale.TabIndex = 126;
            // 
            // TimMa
            // 
            TimMa.DropDownStyle = ComboBoxStyle.DropDownList;
            TimMa.FormattingEnabled = true;
            TimMa.Location = new Point(326, 69);
            TimMa.Name = "TimMa";
            TimMa.Size = new Size(107, 28);
            TimMa.TabIndex = 89;
            TimMa.SelectedIndexChanged += TimMa_SelectedIndexChanged;
            // 
            // TimSL
            // 
            TimSL.DropDownStyle = ComboBoxStyle.DropDownList;
            TimSL.FormattingEnabled = true;
            TimSL.Location = new Point(862, 70);
            TimSL.Name = "TimSL";
            TimSL.Size = new Size(103, 28);
            TimSL.TabIndex = 86;
            TimSL.SelectedIndexChanged += TimSL_SelectedIndexChanged;
            // 
            // radDangBan
            // 
            radDangBan.AutoSize = true;
            radDangBan.Checked = true;
            radDangBan.Location = new Point(26, 192);
            radDangBan.Name = "radDangBan";
            radDangBan.Size = new Size(92, 24);
            radDangBan.TabIndex = 127;
            radDangBan.TabStop = true;
            radDangBan.Text = "Đang bán";
            radDangBan.UseVisualStyleBackColor = true;
            radDangBan.CheckedChanged += radDangBan_CheckedChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(728, 37);
            label11.Name = "label11";
            label11.Size = new Size(65, 20);
            label11.TabIndex = 79;
            label11.Text = "Màu Sắc";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TimMa);
            groupBox1.Controls.Add(TimSL);
            groupBox1.Controls.Add(TimMS);
            groupBox1.Controls.Add(TimCL);
            groupBox1.Controls.Add(TimKT);
            groupBox1.Controls.Add(txtTimTen);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label12);
            groupBox1.Location = new Point(484, 107);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(983, 109);
            groupBox1.TabIndex = 129;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(862, 37);
            label12.Name = "label12";
            label12.Size = new Size(56, 20);
            label12.TabIndex = 85;
            label12.Text = "Masale";
            // 
            // radNgungBan
            // 
            radNgungBan.AutoSize = true;
            radNgungBan.Location = new Point(136, 192);
            radNgungBan.Name = "radNgungBan";
            radNgungBan.Size = new Size(102, 24);
            radNgungBan.TabIndex = 128;
            radNgungBan.Text = "Ngưng bán";
            radNgungBan.UseVisualStyleBackColor = true;
            radNgungBan.CheckedChanged += radNgungBan_CheckedChanged;
            // 
            // cmbMS
            // 
            cmbMS.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMS.FormattingEnabled = true;
            cmbMS.Location = new Point(1255, 23);
            cmbMS.Name = "cmbMS";
            cmbMS.Size = new Size(151, 28);
            cmbMS.TabIndex = 125;
            // 
            // cmbCL
            // 
            cmbCL.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCL.FormattingEnabled = true;
            cmbCL.Location = new Point(922, 70);
            cmbCL.Name = "cmbCL";
            cmbCL.Size = new Size(151, 28);
            cmbCL.TabIndex = 124;
            // 
            // cmbKT
            // 
            cmbKT.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKT.FormattingEnabled = true;
            cmbKT.Location = new Point(922, 23);
            cmbKT.Name = "cmbKT";
            cmbKT.Size = new Size(151, 28);
            cmbKT.TabIndex = 123;
            // 
            // cmbMaSP
            // 
            cmbMaSP.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMaSP.FormattingEnabled = true;
            cmbMaSP.Location = new Point(148, 64);
            cmbMaSP.Name = "cmbMaSP";
            cmbMaSP.Size = new Size(126, 28);
            cmbMaSP.TabIndex = 122;
            cmbMaSP.SelectedIndexChanged += cmbMaSP_SelectedIndexChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(19, 67);
            label13.Name = "label13";
            label13.Size = new Size(102, 20);
            label13.TabIndex = 121;
            label13.Text = "Mã Sản Phẩm:";
            // 
            // dtgView
            // 
            dtgView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgView.Location = new Point(5, 222);
            dtgView.Name = "dtgView";
            dtgView.RowHeadersWidth = 51;
            dtgView.RowTemplate.Height = 29;
            dtgView.Size = new Size(1462, 376);
            dtgView.TabIndex = 108;
            dtgView.CellClick += dtgView_CellClick;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1134, 75);
            label10.Name = "label10";
            label10.Size = new Size(56, 20);
            label10.TabIndex = 120;
            label10.Text = "Masale";
            // 
            // button3
            // 
            button3.Location = new Point(319, 117);
            button3.Name = "button3";
            button3.Size = new Size(118, 47);
            button3.TabIndex = 119;
            button3.Text = "XÓA";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(171, 120);
            button2.Name = "button2";
            button2.Size = new Size(118, 47);
            button2.TabIndex = 118;
            button2.Text = "SỬA";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(23, 120);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(118, 47);
            btnThem.TabIndex = 117;
            btnThem.Text = "THÊM ";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1134, 31);
            label7.Name = "label7";
            label7.Size = new Size(65, 20);
            label7.TabIndex = 116;
            label7.Text = "Màu Sắc";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(801, 74);
            label8.Name = "label8";
            label8.Size = new Size(70, 20);
            label8.TabIndex = 115;
            label8.Text = "Chất Liệu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(801, 31);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 112;
            label4.Text = "Kích Thước";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(461, 67);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 111;
            label5.Text = "Số Lượng:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(461, 31);
            label6.Name = "label6";
            label6.Size = new Size(103, 20);
            label6.TabIndex = 110;
            label6.Text = "Giá Sản Phẩm:";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(587, 64);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(147, 27);
            txtSoLuong.TabIndex = 114;
            // 
            // txtGia
            // 
            txtGia.Location = new Point(587, 24);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(147, 27);
            txtGia.TabIndex = 113;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 31);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 107;
            label2.Text = "Tên Sản Phẩm:";
            // 
            // txtTenSP
            // 
            txtTenSP.BackColor = Color.White;
            txtTenSP.Location = new Point(148, 24);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.ReadOnly = true;
            txtTenSP.Size = new Size(254, 27);
            txtTenSP.TabIndex = 109;
            // 
            // CTSP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 708);
            Controls.Add(cmbSale);
            Controls.Add(radDangBan);
            Controls.Add(groupBox1);
            Controls.Add(radNgungBan);
            Controls.Add(cmbMS);
            Controls.Add(cmbCL);
            Controls.Add(cmbKT);
            Controls.Add(cmbMaSP);
            Controls.Add(label13);
            Controls.Add(dtgView);
            Controls.Add(label10);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnThem);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(txtSoLuong);
            Controls.Add(txtGia);
            Controls.Add(label2);
            Controls.Add(txtTenSP);
            Name = "CTSP";
            Text = "CTSP";
            Load += CTSP_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox TimMS;
        private ComboBox TimCL;
        private ComboBox TimKT;
        private TextBox txtTimTen;
        private Label label1;
        private Label label3;
        private Label label9;
        private Label label14;
        private ComboBox cmbSale;
        private ComboBox TimMa;
        private ComboBox TimSL;
        private RadioButton radDangBan;
        private Label label11;
        private GroupBox groupBox1;
        private Label label12;
        private RadioButton radNgungBan;
        private ComboBox cmbMS;
        private ComboBox cmbCL;
        private ComboBox cmbKT;
        private ComboBox cmbMaSP;
        private Label label13;
        private DataGridView dtgView;
        private Label label10;
        private Button button3;
        private Button button2;
        private Button btnThem;
        private Label label7;
        private Label label8;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtSoLuong;
        private TextBox txtGia;
        private Label label2;
        private TextBox txtTenSP;
    }
}