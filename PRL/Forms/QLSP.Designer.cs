namespace PRL.Forms
{
    partial class QLSP
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
            groupBox1 = new GroupBox();
            label6 = new Label();
            cmbTimTH = new ComboBox();
            label4 = new Label();
            txtTimKiem = new TextBox();
            radDangBan = new RadioButton();
            cmbTH = new ComboBox();
            dtgView = new DataGridView();
            radNgungBan = new RadioButton();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            txtGia = new TextBox();
            txtTenSP = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cmbTimTH);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtTimKiem);
            groupBox1.Location = new Point(625, 89);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(536, 94);
            groupBox1.TabIndex = 79;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(335, 30);
            label6.Name = "label6";
            label6.Size = new Size(95, 20);
            label6.TabIndex = 3;
            label6.Text = "Thương hiệu:";
            // 
            // cmbTimTH
            // 
            cmbTimTH.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTimTH.FormattingEnabled = true;
            cmbTimTH.Location = new Point(335, 60);
            cmbTimTH.Name = "cmbTimTH";
            cmbTimTH.Size = new Size(151, 28);
            cmbTimTH.TabIndex = 2;
            cmbTimTH.SelectedIndexChanged += cmbTimTH_SelectedIndexChanged_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 30);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 1;
            label4.Text = "Tên sản phẩm:";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(18, 61);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(224, 27);
            txtTimKiem.TabIndex = 0;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged_1;
            // 
            // radDangBan
            // 
            radDangBan.AutoSize = true;
            radDangBan.Checked = true;
            radDangBan.Location = new Point(14, 171);
            radDangBan.Name = "radDangBan";
            radDangBan.Size = new Size(92, 24);
            radDangBan.TabIndex = 77;
            radDangBan.TabStop = true;
            radDangBan.Text = "Đang bán";
            radDangBan.UseVisualStyleBackColor = true;
            radDangBan.CheckedChanged += radDangBan_CheckedChanged;
            // 
            // cmbTH
            // 
            cmbTH.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTH.FormattingEnabled = true;
            cmbTH.Location = new Point(587, 22);
            cmbTH.Name = "cmbTH";
            cmbTH.Size = new Size(151, 28);
            cmbTH.TabIndex = 76;
            // 
            // dtgView
            // 
            dtgView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgView.ColumnHeadersHeight = 30;
            dtgView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtgView.Location = new Point(14, 201);
            dtgView.Name = "dtgView";
            dtgView.RowHeadersWidth = 51;
            dtgView.RowTemplate.Height = 29;
            dtgView.Size = new Size(1178, 500);
            dtgView.TabIndex = 75;
            dtgView.CellClick += dtgView_CellClick_1;
            // 
            // radNgungBan
            // 
            radNgungBan.AutoSize = true;
            radNgungBan.Location = new Point(125, 171);
            radNgungBan.Name = "radNgungBan";
            radNgungBan.Size = new Size(102, 24);
            radNgungBan.TabIndex = 78;
            radNgungBan.TabStop = true;
            radNgungBan.Text = "Ngưng bán";
            radNgungBan.UseVisualStyleBackColor = true;
            radNgungBan.CheckedChanged += radNgungBan_CheckedChanged;
            // 
            // button3
            // 
            button3.Location = new Point(398, 89);
            button3.Name = "button3";
            button3.Size = new Size(120, 40);
            button3.TabIndex = 74;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(219, 89);
            button2.Name = "button2";
            button2.Size = new Size(120, 40);
            button2.TabIndex = 73;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.Location = new Point(40, 89);
            button1.Name = "button1";
            button1.Size = new Size(120, 40);
            button1.TabIndex = 72;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // txtGia
            // 
            txtGia.Location = new Point(928, 23);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(151, 27);
            txtGia.TabIndex = 71;
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(132, 18);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(206, 27);
            txtTenSP.TabIndex = 70;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(850, 26);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 69;
            label5.Text = "Giá bán";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(429, 25);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 68;
            label3.Text = "Mã Thương Hiệu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 25);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 67;
            label2.Text = "Tên Sản Phẩm:";
            // 
            // QLSP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1206, 718);
            Controls.Add(groupBox1);
            Controls.Add(radDangBan);
            Controls.Add(cmbTH);
            Controls.Add(dtgView);
            Controls.Add(radNgungBan);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtGia);
            Controls.Add(txtTenSP);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "QLSP";
            Text = "QLSP";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label6;
        private ComboBox cmbTimTH;
        private Label label4;
        private TextBox txtTimKiem;
        private RadioButton radDangBan;
        private ComboBox cmbTH;
        private DataGridView dtgView;
        private RadioButton radNgungBan;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox txtGia;
        private TextBox txtTenSP;
        private Label label5;
        private Label label3;
        private Label label2;
    }
}