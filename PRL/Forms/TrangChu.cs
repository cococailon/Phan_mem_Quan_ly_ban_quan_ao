using BUS.Service;
using DAL.Models;
using DAL.Repositories;
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
    public partial class TrangChu : Form
    {

        string tenchucvulg;
        public TrangChu(string tenchucvu)
        {
            InitializeComponent();
            tenchucvulg = tenchucvu;
        }



        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            quanLiMaGiamGia quanLiMaGiamGia = new quanLiMaGiamGia(new KhuyenMaiServices(new KhuyenMaiRepos(new DUAN1_QL_BANQUANAOContext())));
            quanLiMaGiamGia.TopLevel = false;
            quanLiMaGiamGia.FormBorderStyle = FormBorderStyle.None;
            quanLiMaGiamGia.Dock = DockStyle.Fill;
            panel1.Controls.Add(quanLiMaGiamGia);
            quanLiMaGiamGia.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tenchucvulg == "Nhân viên")
            {
                MessageBox.Show("Ko Được truy Cập");
               
            }
            
            panel1.Controls.Clear();
            QLNhanVien nhanVien = new QLNhanVien();
            nhanVien.TopLevel = false;
            nhanVien.FormBorderStyle = FormBorderStyle.None;
            nhanVien.Dock = DockStyle.Fill;
            panel1.Controls.Add(nhanVien);
            nhanVien.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            TrangChu trangChu = new TrangChu(tenchucvulg);
            trangChu.TopLevel = false;
            trangChu.FormBorderStyle = FormBorderStyle.None;
            trangChu.Dock = DockStyle.Fill;
            //panel1.Controls.Add(trangChu);
            trangChu.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            FormQLTong ql = new FormQLTong();
            ql.TopLevel = false;
            ql.FormBorderStyle = FormBorderStyle.None;
            ql.Dock = DockStyle.Fill;
            panel1.Controls.Add(ql);
            ql.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            QLKhachHang qLKhachHang = new QLKhachHang();
            qLKhachHang.TopLevel = false;
            qLKhachHang.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(qLKhachHang);
            qLKhachHang.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            QLHoaDon quanLiMaGiamGia = new QLHoaDon(new HoaDonServices(new HoaDonRepos(new DUAN1_QL_BANQUANAOContext())));
            quanLiMaGiamGia.TopLevel = false;
            quanLiMaGiamGia.FormBorderStyle = FormBorderStyle.None;
            quanLiMaGiamGia.Dock = DockStyle.Fill;
            panel1.Controls.Add(quanLiMaGiamGia);
            quanLiMaGiamGia.Show();
        }
    }
}
