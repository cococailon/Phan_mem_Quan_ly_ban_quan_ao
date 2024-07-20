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
    public partial class QLKhachHang : Form
    {
        KhachHangService _khservice = new KhachHangService();

        public QLKhachHang()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            dtgdanhsach.Rows.Clear();
            int stt = 1;
            dtgdanhsach.ColumnCount = 7;
            dtgdanhsach.Columns[0].Name = "STT";
            dtgdanhsach.Columns[1].Name = "Số Điện Thoại";
            dtgdanhsach.Columns[2].Name = "Họ Và Tên";
            dtgdanhsach.Columns[3].Name = "Giới Tính";
            dtgdanhsach.Columns[4].Name = "Địa chỉ ";
            dtgdanhsach.Columns[5].Name = "Ngày Sinh";
            dtgdanhsach.Columns[6].Name = "Email";
            dtgdanhsach.Rows.Clear();
            foreach (var item in _khservice.GetALL())
            {
                dtgdanhsach.Rows.Add(stt++, item.SoDienThoai, item.HoVaTen, item.GioiTinh, item.DiaChi, item.NgaySinh, item.Email);
            }
        }










        private void btnthem_Click_1(object sender, EventArgs e)
        {

            var kq = MessageBox.Show("bạn có muốn thêm không ? ", "Thông báo ", MessageBoxButtons.YesNo);
            if (kq == DialogResult.Yes)
            {
                var kh = new Khachhang();
                kh.SoDienThoai = txtsdt.Text;
                kh.HoVaTen = txthoten.Text;
                if (rbnam.Checked)
                {
                    kh.GioiTinh = "Nam";
                }
                else if (rbnu.Checked)
                {
                    kh.GioiTinh = "Nữ";
                }
                kh.NgaySinh = dtngaysinh.Value;
                kh.DiaChi = txtdiachi.Text;
                kh.Email = txtemail.Text;
                MessageBox.Show(_khservice.Createkh(kh));
            }
            LoadData();
        }

        private void btnsua_Click_1(object sender, EventArgs e)
        {

            string gioiTinh = null;
            if (rbnam.Checked == true)
            {
                gioiTinh = rbnam.Text;
            }
            else if (rbnu.Checked == true)
            {
                gioiTinh = rbnu.Text;
            }

            DateTime dtNS = dtngaysinh.Value;

            MessageBox.Show("Sửa thành công ", "Thông báo" + _khservice.Updatekh(txtsdt.Text, txthoten.Text, gioiTinh, txtdiachi.Text, dtNS, txtemail.Text));
        }

        private void btnxoa_Click_1(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có muốn xóa không?", "Xác nhận",
            MessageBoxButtons.YesNoCancel);
            if (DialogResult == DialogResult.Yes)
            {
                _khservice.Removekh(txtsdt.Text);
                LoadData();
            }
        }

        private void btndong_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void dtgdanhsach_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dtgdanhsach.Rows[e.RowIndex];
                txtsdt.Text = row.Cells[1].Value.ToString();
                txthoten.Text = row.Cells[2].Value.ToString();
                string GioiTinh = row.Cells[3].Value.ToString();
                if (GioiTinh == "Nam")
                {
                    rbnam.Checked = true;
                    rbnu.Checked = false;
                }
                else if (GioiTinh == "Nữ")
                {
                    rbnam.Checked = false;
                    rbnu.Checked = true;
                }
                dtngaysinh.Text = row.Cells[5].Value.ToString();
                txtdiachi.Text = row.Cells[4].Value.ToString();
                txtemail.Text = row.Cells[6].Value.ToString();
                dtgdanhsach.Rows[e.RowIndex].Selected = true;
            }
        }
    }
}
