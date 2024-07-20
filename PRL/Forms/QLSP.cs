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
    public partial class QLSP : Form
    {
        private SanPhamService _service;

        public QLSP()
        {
            InitializeComponent();
            _service = new SanPhamService();
            LoadData();
            LoadCombobox();
        }

        private void LoadData()
        {
            //var count = 0;
            //var data = _service.GetNhanViens().ToList();
            //dtgView.DataSource = data;

            //Tạo stt = 1
            int stt = 1;
            // cài đặt số lượng thược tính cho grid view
            int Soluongthuoctinh = 7;
            dtgView.ColumnCount = Soluongthuoctinh;
            //đặt tên cột
            dtgView.Columns[0].Name = "STT";
            dtgView.Columns[1].Name = "Mã sản phẩm";
            dtgView.Columns[2].Name = "Tên sản phẩm";
            dtgView.Columns[3].Name = "Giá";
            dtgView.Columns[4].Name = "Số lượng";
            dtgView.Columns[5].Name = "Mã thương hiệu";
            dtgView.Columns[6].Name = "Trạng thái";

            //xóa dữ liêij mỗi lần load lại
            dtgView.Rows.Clear();
            //thêm các dòng dữ liệu
            foreach (var x in _service.GetSanphams().Where(sp => sp.TrangThai == "Đang bán"))
            {
                dtgView.Rows.Add(stt++, x.MaSanPham, x.TenSanPham, x.GiaBan, x.SoLuong, x.MaThuongHieu, x.TrangThai);
            }
        }
        private void LoadNgungBan()
        {
            //var count = 0;
            //var data = _service.GetNhanViens().ToList();
            //dtgView.DataSource = data;

            //Tạo stt = 1
            int stt = 1;
            // cài đặt số lượng thược tính cho grid view
            int Soluongthuoctinh = 7;
            dtgView.ColumnCount = Soluongthuoctinh;
            //đặt tên cột
            dtgView.Columns[0].Name = "STT";
            dtgView.Columns[1].Name = "Mã sản phẩm";
            dtgView.Columns[2].Name = "Tên sản phẩm";
            dtgView.Columns[3].Name = "Giá";
            dtgView.Columns[4].Name = "Số lượng";
            dtgView.Columns[5].Name = "Mã thương hiệu";
            dtgView.Columns[6].Name = "Trạng thái";

            //xóa dữ liêij mỗi lần load lại
            dtgView.Rows.Clear();
            //thêm các dòng dữ liệu
            foreach (var x in _service.GetSanphams().Where(sp => sp.TrangThai == "Ngưng bán"))
            {
                dtgView.Rows.Add(stt++, x.MaSanPham, x.TenSanPham, x.GiaBan, x.SoLuong, x.MaThuongHieu, x.TrangThai);
            }
        }
        private void LoadCombobox()
        {
            foreach (var item in _service.GetThuonghieus())
            {
                cmbTH.Items.Add(item.MaThuongHieu);
                cmbTimTH.Items.Add(item.MaThuongHieu);
                cmbTH.SelectedIndex = 0;
            }
        }

        private int originalQuantity;



        private void button1_Click_1(object sender, EventArgs e)
        {
            var kq = MessageBox.Show("Bạn chắc muốn thêm không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (kq == DialogResult.Yes)
            {
                var stt = _service.GetSanphams().Count() + 1;
                var existingProduct = _service.GetSanphams()
                    .FirstOrDefault(sp => sp.TenSanPham == txtTenSP.Text && sp.MaThuongHieu == cmbTH.Text && sp.GiaBan == double.Parse(txtGia.Text));

                if (existingProduct != null)
                {
                    if (existingProduct.TrangThai == "Đang bán")
                    {
                        MessageBox.Show("Sản phẩm đã có");
                    }
                    else if (existingProduct.TrangThai == "Ngưng bán")
                    {
                        existingProduct.TrangThai = "Đang bán";
                        existingProduct.SoLuong = 0;

                        MessageBox.Show(_service.Update(existingProduct));
                        LoadNgungBan();
                    }
                }
                else
                {
                    var maSP = "SP" + stt;
                    var sp = new Sanpham
                    {
                        MaSanPham = maSP,
                        TenSanPham = txtTenSP.Text,
                        MaThuongHieu = cmbTH.Text,
                        GiaBan = double.Parse(txtGia.Text),
                        SoLuong = 0,
                        TrangThai = "Đang bán"
                    };

                    MessageBox.Show(_service.Add(sp));
                    LoadData();
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var kq = MessageBox.Show("Bạn chắc muốn sửa không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (kq == DialogResult.Yes)
            {
                if (dtgView.SelectedRows.Count > 0)
                {
                    // Get the original quantity before updating
                    originalQuantity = int.Parse(dtgView.SelectedRows[0].Cells["Số lượng"].Value.ToString());
                    // Update the data in the database
                    var updatedSanPham = new Sanpham
                    {
                        MaSanPham = dtgView.SelectedRows[0].Cells["Mã sản phẩm"].Value.ToString(),
                        TenSanPham = txtTenSP.Text,
                        MaThuongHieu = cmbTH.Text,
                        GiaBan = double.Parse(txtGia.Text),
                        SoLuong = originalQuantity
                    };


                    MessageBox.Show(_service.Update(updatedSanPham));
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một dòng để sửa.");
                }
            }
            LoadData();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            var kq = MessageBox.Show("Bạn chắc muốn sửa không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (kq == DialogResult.Yes)
            {
                if (dtgView.SelectedRows.Count > 0)
                {

                    // Update the data in the database
                    var updatedSanPham = new Sanpham
                    {
                        MaSanPham = dtgView.SelectedRows[0].Cells["Mã sản phẩm"].Value.ToString(),
                        TenSanPham = txtTenSP.Text,
                        MaThuongHieu = cmbTH.Text,
                        GiaBan = double.Parse(txtGia.Text),
                        TrangThai = "Ngưng bán",
                        SoLuong = 0
                    };
                    MessageBox.Show(_service.Delete(updatedSanPham));
                    _service.UpdateSPCT(updatedSanPham.MaSanPham, 0, "Ngưng bán");
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một dòng để xóa.");
                }
            }
            LoadData();
        }

        private void dtgView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgView.Rows[e.RowIndex];

                // Populate textboxes with data from the selected row
                txtTenSP.Text = row.Cells["Tên sản phẩm"].Value.ToString();
                cmbTH.Text = row.Cells["Mã thương hiệu"].Value.ToString();
                txtGia.Text = row.Cells["Giá"].Value.ToString();

                dtgView.Rows[e.RowIndex].Selected = true;
            }
        }

        private void radDangBan_CheckedChanged(object sender, EventArgs e)
        {
            int stt = 1;
            // Clear existing rows
            dtgView.Rows.Clear();

            foreach (var x in _service.GetSanphams().Where(sp => sp.TrangThai == "Đang bán"))
            {
                dtgView.Rows.Add(stt++, x.MaSanPham, x.TenSanPham, x.GiaBan, x.SoLuong, x.MaThuongHieu, x.TrangThai);
            }

            // Refresh the DataGridView
            dtgView.Refresh();
        }

        private void radNgungBan_CheckedChanged(object sender, EventArgs e)
        {
            int stt = 1;
            // Clear existing rows
            dtgView.Rows.Clear();

            foreach (var x in _service.GetSanphams().Where(sp => sp.TrangThai == "Ngưng bán"))
            {
                dtgView.Rows.Add(stt++, x.MaSanPham, x.TenSanPham, x.GiaBan, x.SoLuong, x.MaThuongHieu, x.TrangThai);
            }

            // Refresh the DataGridView
            dtgView.Refresh();
        }

        private void txtTimKiem_TextChanged_1(object sender, EventArgs e)
        {
            string searchKeyword = txtTimKiem.Text.Trim().ToLower();
            string TimTH = cmbTimTH.SelectedItem?.ToString();

            // Clear existing rows
            dtgView.Rows.Clear();

            int stt = 1;
            string selectedRadioButtonText = radDangBan.Checked ? "Đang bán" : "Ngưng bán";

            // Filter the data based on the search keyword
            var filteredData = _service.GetSanphams()
                .Where(sp => sp.TrangThai == selectedRadioButtonText && (TimTH == null || sp.MaThuongHieu == TimTH) && (string.IsNullOrEmpty(searchKeyword) || sp.TenSanPham.ToLower().Contains(searchKeyword)))
                .ToList();

            // Add the filtered data to the DataGridView
            foreach (var x in filteredData)
            {
                dtgView.Rows.Add(stt++, x.MaSanPham, x.TenSanPham, x.GiaBan, x.SoLuong, x.MaThuongHieu, x.TrangThai);
            }

            // Refresh the DataGridView
            dtgView.Refresh();
        }

        private void cmbTimTH_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtTimKiem_TextChanged_1(sender, e);
        }
    }
}
