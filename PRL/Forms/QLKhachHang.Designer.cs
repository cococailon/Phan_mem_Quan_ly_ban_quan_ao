namespace PRL.Forms
{
    partial class QLKhachHang
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
            groupBox2 = new GroupBox();
            dtgdanhsach = new DataGridView();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            label3 = new Label();
            btnsua = new Button();
            btndong = new Button();
            btnxoa = new Button();
            btnluu = new Button();
            btnthem = new Button();
            dtngaysinh = new DateTimePicker();
            rbnu = new RadioButton();
            rbnam = new RadioButton();
            txtemail = new TextBox();
            txtdiachi = new TextBox();
            txtsdt = new TextBox();
            txthoten = new TextBox();
            lbemail = new Label();
            lbdiachi = new Label();
            lbngaysinh = new Label();
            label4 = new Label();
            lbhoten = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgdanhsach).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtgdanhsach);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Location = new Point(0, 365);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1396, 298);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách";
            // 
            // dtgdanhsach
            // 
            dtgdanhsach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgdanhsach.Dock = DockStyle.Fill;
            dtgdanhsach.Location = new Point(3, 23);
            dtgdanhsach.Name = "dtgdanhsach";
            dtgdanhsach.RowHeadersWidth = 51;
            dtgdanhsach.RowTemplate.Height = 29;
            dtgdanhsach.Size = new Size(1390, 272);
            dtgdanhsach.TabIndex = 0;
            dtgdanhsach.CellClick += dtgdanhsach_CellClick_1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnsua);
            groupBox1.Controls.Add(btndong);
            groupBox1.Controls.Add(btnxoa);
            groupBox1.Controls.Add(btnluu);
            groupBox1.Controls.Add(btnthem);
            groupBox1.Controls.Add(dtngaysinh);
            groupBox1.Controls.Add(rbnu);
            groupBox1.Controls.Add(rbnam);
            groupBox1.Controls.Add(txtemail);
            groupBox1.Controls.Add(txtdiachi);
            groupBox1.Controls.Add(txtsdt);
            groupBox1.Controls.Add(txthoten);
            groupBox1.Controls.Add(lbemail);
            groupBox1.Controls.Add(lbdiachi);
            groupBox1.Controls.Add(lbngaysinh);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lbhoten);
            groupBox1.Controls.Add(label2);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1396, 361);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(430, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(333, 27);
            textBox1.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(333, 27);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 36;
            label3.Text = "Tìm Kiếm";
            // 
            // btnsua
            // 
            btnsua.Location = new Point(234, 268);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(94, 29);
            btnsua.TabIndex = 35;
            btnsua.Text = "SỬA";
            btnsua.UseVisualStyleBackColor = true;
            btnsua.Click += btnsua_Click_1;
            // 
            // btndong
            // 
            btndong.Location = new Point(603, 268);
            btndong.Name = "btndong";
            btndong.Size = new Size(94, 29);
            btndong.TabIndex = 34;
            btndong.Text = "ĐÓNG";
            btndong.UseVisualStyleBackColor = true;
            btndong.Click += btndong_Click_1;
            // 
            // btnxoa
            // 
            btnxoa.Location = new Point(357, 268);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(94, 29);
            btnxoa.TabIndex = 33;
            btnxoa.Text = "XÓA";
            btnxoa.UseVisualStyleBackColor = true;
            btnxoa.Click += btnxoa_Click_1;
            // 
            // btnluu
            // 
            btnluu.Location = new Point(480, 268);
            btnluu.Name = "btnluu";
            btnluu.Size = new Size(94, 29);
            btnluu.TabIndex = 32;
            btnluu.Text = "LƯU";
            btnluu.UseVisualStyleBackColor = true;
            // 
            // btnthem
            // 
            btnthem.Location = new Point(111, 268);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(94, 29);
            btnthem.TabIndex = 31;
            btnthem.Text = "THÊM";
            btnthem.UseVisualStyleBackColor = true;
            btnthem.Click += btnthem_Click_1;
            // 
            // dtngaysinh
            // 
            dtngaysinh.Location = new Point(143, 210);
            dtngaysinh.Name = "dtngaysinh";
            dtngaysinh.Size = new Size(250, 27);
            dtngaysinh.TabIndex = 30;
            // 
            // rbnu
            // 
            rbnu.AutoSize = true;
            rbnu.Location = new Point(323, 160);
            rbnu.Name = "rbnu";
            rbnu.Size = new Size(47, 24);
            rbnu.TabIndex = 29;
            rbnu.TabStop = true;
            rbnu.Text = "Nữ";
            rbnu.UseVisualStyleBackColor = true;
            // 
            // rbnam
            // 
            rbnam.AutoSize = true;
            rbnam.Location = new Point(143, 161);
            rbnam.Name = "rbnam";
            rbnam.Size = new Size(59, 24);
            rbnam.TabIndex = 28;
            rbnam.TabStop = true;
            rbnam.Text = "Nam";
            rbnam.UseVisualStyleBackColor = true;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(620, 121);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(344, 27);
            txtemail.TabIndex = 27;
            // 
            // txtdiachi
            // 
            txtdiachi.Location = new Point(620, 72);
            txtdiachi.Name = "txtdiachi";
            txtdiachi.Size = new Size(344, 27);
            txtdiachi.TabIndex = 26;
            // 
            // txtsdt
            // 
            txtsdt.Location = new Point(143, 118);
            txtsdt.Name = "txtsdt";
            txtsdt.Size = new Size(344, 27);
            txtsdt.TabIndex = 25;
            // 
            // txthoten
            // 
            txthoten.Location = new Point(143, 75);
            txthoten.Name = "txthoten";
            txthoten.Size = new Size(344, 27);
            txthoten.TabIndex = 24;
            // 
            // lbemail
            // 
            lbemail.AutoSize = true;
            lbemail.Location = new Point(541, 124);
            lbemail.Name = "lbemail";
            lbemail.Size = new Size(46, 20);
            lbemail.TabIndex = 23;
            lbemail.Text = "Email";
            // 
            // lbdiachi
            // 
            lbdiachi.AutoSize = true;
            lbdiachi.Location = new Point(541, 79);
            lbdiachi.Name = "lbdiachi";
            lbdiachi.Size = new Size(61, 20);
            lbdiachi.TabIndex = 22;
            lbdiachi.Text = "Địa Chỉ ";
            // 
            // lbngaysinh
            // 
            lbngaysinh.AutoSize = true;
            lbngaysinh.Location = new Point(30, 210);
            lbngaysinh.Name = "lbngaysinh";
            lbngaysinh.Size = new Size(76, 20);
            lbngaysinh.TabIndex = 21;
            lbngaysinh.Text = "Ngày Sinh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 161);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 20;
            label4.Text = "Giới Tính";
            // 
            // lbhoten
            // 
            lbhoten.AutoSize = true;
            lbhoten.Location = new Point(30, 79);
            lbhoten.Name = "lbhoten";
            lbhoten.Size = new Size(76, 20);
            lbhoten.TabIndex = 19;
            lbhoten.Text = "Họ Và Tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 121);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 18;
            label2.Text = "Số Điện Thoại";
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1396, 63);
            label1.TabIndex = 15;
            label1.Text = "Khách Hàng";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // QLKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1396, 663);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "QLKhachHang";
            Text = "QLKhachHang";
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgdanhsach).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private DataGridView dtgdanhsach;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label3;
        private Button btnsua;
        private Button btndong;
        private Button btnxoa;
        private Button btnluu;
        private Button btnthem;
        private DateTimePicker dtngaysinh;
        private RadioButton rbnu;
        private RadioButton rbnam;
        private TextBox txtemail;
        private TextBox txtdiachi;
        private TextBox txtsdt;
        private TextBox txthoten;
        private Label lbemail;
        private Label lbdiachi;
        private Label lbngaysinh;
        private Label label4;
        private Label lbhoten;
        private Label label2;
        private Label label1;
    }
}