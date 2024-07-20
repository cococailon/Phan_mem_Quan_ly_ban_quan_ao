using BUS.Service;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL.Forms
{
    public partial class Login : Form
    {
        NhanVienServices _service = new NhanVienServices();

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string password = textBox2.Text;

            Nhanvien taikhoan = _service.GetNvForLogin(user, password);
            QLNhanVien qLNhanVien = new QLNhanVien();

            if (taikhoan != null)
            {
                MessageBox.Show("dang nhap thanh cong");
                TrangChu trangChu = new TrangChu(taikhoan.TenChucVu);
                trangChu.ShowDialog();
            }
            else
            {
                MessageBox.Show("dang nhap khong thanh cong");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }


    }
}
