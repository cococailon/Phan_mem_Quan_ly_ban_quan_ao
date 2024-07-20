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
    public partial class CTSP : Form
    {
        private SPCTServices _service;
        public CTSP()
        {
            InitializeComponent();
            _service = new SPCTServices();
            LoadData();
            LoadComboBox();
        }

        private void LoadData()
        {
            //var count = 0;
            //var data = _service.GetNhanViens().ToList();
            //dtgView.DataSource = data;

            //Tạo stt = 1
            int stt = 1;
            // cài đặt số lượng thược tính cho grid view
            int Soluongthuoctinh = 11;
            dtgView.ColumnCount = Soluongthuoctinh;
            //đặt tên cột
            dtgView.Columns[0].Name = "STT";
            dtgView.Columns[1].Name = "Mã CTSP";
            dtgView.Columns[2].Name = "Mã sản phẩm";
            dtgView.Columns[3].Name = "Tên sản phẩm";
            dtgView.Columns[4].Name = "Giá";
            dtgView.Columns[5].Name = "Số lượng";
            dtgView.Columns[6].Name = "Mã kích thước";
            dtgView.Columns[7].Name = "Mã chất liệu";
            dtgView.Columns[8].Name = "Mã màu sắc";
            dtgView.Columns[9].Name = "Mã Sale";
            dtgView.Columns[10].Name = "Trạng thái";

            //xóa dữ liêij mỗi lần load lại
            dtgView.Rows.Clear();
            //thêm các dòng dữ liệu
            foreach (var x in _service.GetCTSanphams().Where(sp => sp.TrangThai == "Đang bán"))
            {
                dtgView.Rows.Add(stt++, x.MaSanPhamChiTiet, x.MaSanPham, x.TenSanPham, x.Gia, x.SoLuong, x.MaKichThuoc, x.MaChatLieu, x.MaMauSac, x.MaSale, x.TrangThai);
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
            int Soluongthuoctinh = 11;
            dtgView.ColumnCount = Soluongthuoctinh;
            //đặt tên cột
            dtgView.Columns[0].Name = "STT";
            dtgView.Columns[1].Name = "Mã CTSP";
            dtgView.Columns[2].Name = "Mã sản phẩm";
            dtgView.Columns[3].Name = "Tên sản phẩm";
            dtgView.Columns[4].Name = "Giá";
            dtgView.Columns[5].Name = "Số lượng";
            dtgView.Columns[6].Name = "Mã kích thước";
            dtgView.Columns[7].Name = "Mã chất liệu";
            dtgView.Columns[8].Name = "Mã màu sắc";
            dtgView.Columns[9].Name = "Mã Sale";
            dtgView.Columns[10].Name = "Trạng thái";

            //xóa dữ liêij mỗi lần load lại
            dtgView.Rows.Clear();
            //thêm các dòng dữ liệu
            foreach (var x in _service.GetCTSanphams().Where(spct => spct.TrangThai == "Ngưng bán"))
            {
                dtgView.Rows.Add(stt++, x.MaSanPhamChiTiet, x.MaSanPham, x.TenSanPham, x.Gia, x.SoLuong, x.MaKichThuoc, x.MaChatLieu, x.MaMauSac, x.MaSale, x.TrangThai);
            }
        }



        public void LoadComboBox()
        {
            foreach (var item in _service.GetMaSanphams().Where(sp => sp.TrangThai == "Đang bán"))
            {
                cmbMaSP.Items.Add(item.MaSanPham);
                cmbMaSP.SelectedIndex = 0;
            }

            foreach (var item in _service.GetMaSanphams())
            {
                TimMa.Items.Add(item.MaSanPham);
            }

            foreach (var item in _service.GetMaKichthuoc())
            {
                cmbKT.Items.Add(item.MaKichThuoc);
                TimKT.Items.Add(item.MaKichThuoc);
                cmbKT.SelectedIndex = 0;
            }

            foreach (var item in _service.GetMaChatLieu())
            {
                cmbCL.Items.Add(item.MaChatLieu);
                TimCL.Items.Add(item.MaChatLieu);
                cmbCL.SelectedIndex = 0;
            }

            foreach (var item in _service.GetMaMauSac())
            {
                cmbMS.Items.Add(item.MaMauSac);
                TimMS.Items.Add(item.MaMauSac);
                cmbMS.SelectedIndex = 0;
            }

            foreach (var item in _service.GetMaSale())
            {
                cmbSale.Items.Add(item.MaSale);
                TimSL.Items.Add(item.MaSale);
                cmbSale.SelectedIndex = 0;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var kq = MessageBox.Show("Bạn chắc muốn thêm không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (kq == DialogResult.Yes)
            {
                var duplicateProduct = _service.GetCTSanphams().FirstOrDefault(sp =>
                            sp.TenSanPham == txtTenSP.Text &&
                            sp.Gia == double.Parse(txtGia.Text) &&
                            sp.MaSanPham == cmbMaSP.Text &&
                            sp.MaKichThuoc == cmbKT.Text &&
                            sp.MaChatLieu == cmbCL.Text &&
                            sp.MaMauSac == cmbMS.Text &&
                            sp.MaSale == cmbSale.Text);

                if (duplicateProduct != null)
                {
                    if (duplicateProduct.TrangThai == "Đang bán")
                    {
                        // Nếu sản phẩm đã tồn tại, cộng thêm số lượng
                        duplicateProduct.SoLuong += int.Parse(txtSoLuong.Text);
                        MessageBox.Show("Đã có sản phẩm. Số lượng đã được cập nhật.");
                        MessageBox.Show(_service.Update(duplicateProduct));
                        LoadData();
                    }
                    else if (duplicateProduct.TrangThai == "Ngưng bán")
                    {
                        duplicateProduct.TrangThai = "Đang bán";
                        duplicateProduct.SoLuong += int.Parse(txtSoLuong.Text);

                        MessageBox.Show(_service.Update(duplicateProduct));
                        LoadNgungBan();
                    }

                }
                else
                {
                    // Nếu sản phẩm chưa tồn tại, thêm sản phẩm mới
                    var stt = _service.GetCTSanphams().Count() + 1;
                    var maSPCT = "SPCT" + stt;

                    var spct = new Sanphamchitiet
                    {
                        MaSanPhamChiTiet = maSPCT,
                        TenSanPham = txtTenSP.Text,
                        MaSanPham = cmbMaSP.Text,
                        Gia = double.Parse(txtGia.Text),
                        SoLuong = int.Parse(txtSoLuong.Text),
                        MaKichThuoc = cmbKT.Text,
                        MaChatLieu = cmbCL.Text,
                        MaMauSac = cmbMS.Text,
                        MaSale = cmbSale.Text,
                        TrangThai = "Đang bán"
                    };

                    MessageBox.Show(_service.Add(spct));
                    LoadData();
                }
            }
        }



        private void dtgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgView.Rows[e.RowIndex];

                // Populate textboxes with data from the selected row
                cmbMaSP.Text = row.Cells["Mã sản phẩm"].Value.ToString();
                txtTenSP.Text = row.Cells["Tên sản phẩm"].Value.ToString();
                txtGia.Text = row.Cells["Giá"].Value.ToString();
                txtSoLuong.Text = row.Cells["Số lượng"].Value.ToString();
                cmbKT.Text = row.Cells["Mã kích thước"].Value.ToString();
                cmbCL.Text = row.Cells["Mã chất liệu"].Value.ToString();
                cmbMS.Text = row.Cells["Mã màu sắc"].Value.ToString();
                cmbSale.Text = row.Cells["Mã Sale"].Value.ToString();
                dtgView.Rows[e.RowIndex].Selected = true;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            var kq = MessageBox.Show("Bạn chắc muốn sửa không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (kq == DialogResult.Yes)
            {
                if (dtgView.SelectedRows.Count > 0)
                {
                    // Get the original quantity before updating
                    int originalQuantity = int.Parse(dtgView.SelectedRows[0].Cells["Số lượng"].Value.ToString());
                    // Update the data in the database
                    var updatedSanPham = new Sanphamchitiet
                    {
                        MaSanPhamChiTiet = dtgView.SelectedRows[0].Cells["Mã CTSP"].Value.ToString(),
                        TenSanPham = txtTenSP.Text,
                        MaSanPham = cmbMaSP.Text,
                        Gia = double.Parse(txtGia.Text),
                        SoLuong = int.Parse(txtSoLuong.Text),
                        MaKichThuoc = cmbKT.Text,
                        MaChatLieu = cmbCL.Text,
                        MaMauSac = cmbMS.Text,
                        MaSale = cmbSale.Text
                    };

                    int quantityDifference = updatedSanPham.SoLuong - originalQuantity;

                    // Update the corresponding SanPham record
                    var sanPham = _service.GetSanPhamByMaSanPham(updatedSanPham.MaSanPham);
                    if (sanPham != null)
                    {
                        sanPham.SoLuong += quantityDifference; // Adjust the quantity
                        MessageBox.Show(_service.Update(updatedSanPham));
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sản phẩm tương ứng.");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một dòng để sửa.");
                }
            }
            LoadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var kq = MessageBox.Show("Bạn chắc muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (kq == DialogResult.Yes)
            {
                if (dtgView.SelectedRows.Count > 0)
                {

                    // Update the data in the database
                    var updatedSanPham = new Sanphamchitiet
                    {
                        MaSanPhamChiTiet = dtgView.SelectedRows[0].Cells["Mã CTSP"].Value.ToString(),
                        TenSanPham = txtTenSP.Text,
                        MaSanPham = cmbMaSP.Text,
                        Gia = double.Parse(txtGia.Text),
                        SoLuong = 0,
                        MaKichThuoc = cmbKT.Text,
                        MaChatLieu = cmbCL.Text,
                        MaMauSac = cmbMS.Text,
                        MaSale = cmbSale.Text,
                        TrangThai = "Ngưng bán"
                    };
                    MessageBox.Show(_service.Delete(updatedSanPham));
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một dòng để xóa.");
                }
            }
            LoadData();
        }

        private void cmbMaSP_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Lấy mã sản phẩm được chọn từ ComboBox
            string selectedMaSP = cmbMaSP.SelectedItem.ToString();

            // Gọi phương thức để lấy tên sản phẩm dựa trên mã sản phẩm
            string tenSanPham = _service.GetTenSanPhamByMaSP(selectedMaSP);


            // Đặt giá trị của txtTenSP bằng tên sản phẩm
            txtTenSP.Text = tenSanPham;
        }

        private void radDangBan_CheckedChanged(object sender, EventArgs e)
        {
            int stt = 1;
            // Clear existing rows
            dtgView.Rows.Clear();

            foreach (var x in _service.GetCTSanphams().Where(spct => spct.TrangThai == "Đang bán"))
            {
                dtgView.Rows.Add(stt++, x.MaSanPhamChiTiet, x.MaSanPham, x.TenSanPham, x.Gia, x.SoLuong, x.MaKichThuoc, x.MaChatLieu, x.MaMauSac, x.MaSale, x.TrangThai);
            }

            // Refresh the DataGridView
            dtgView.Refresh();
        }

        private void radNgungBan_CheckedChanged(object sender, EventArgs e)
        {

            int stt = 1;
            // Clear existing rows
            dtgView.Rows.Clear();

            foreach (var x in _service.GetCTSanphams().Where(spct => spct.TrangThai == "Ngưng bán"))
            {
                dtgView.Rows.Add(stt++, x.MaSanPhamChiTiet, x.MaSanPham, x.TenSanPham, x.Gia, x.SoLuong, x.MaKichThuoc, x.MaChatLieu, x.MaMauSac, x.MaSale, x.TrangThai);
            }

            // Refresh the DataGridView
            dtgView.Refresh();
        }

        private void TimMa_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTimTen_TextChanged(sender, e);
        }

        private void TimKT_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTimTen_TextChanged(sender, e);
        }

        private void TimCL_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTimTen_TextChanged(sender, e);
        }

        private void TimMS_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTimTen_TextChanged(sender, e);
        }

        private void TimSL_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTimTen_TextChanged(sender, e);
        }

        private void txtTimTen_TextChanged(object sender, EventArgs e)
        {
            string searchKeyword = txtTimTen.Text.Trim().ToLower();
            string TimMaSP = TimMa.SelectedItem?.ToString();
            string TimMaKT = TimKT.SelectedItem?.ToString();
            string TimMaCL = TimCL.SelectedItem?.ToString();
            string TimMaMS = TimMS.SelectedItem?.ToString();
            string TimMaSL = TimSL.SelectedItem?.ToString();

            // Clear existing rows
            dtgView.Rows.Clear();

            int stt = 1;
            string selectedRadioButtonText = radDangBan.Checked ? "Đang bán" : "Ngưng bán";

            // Filter the data based on the search keyword
            var filteredData = _service.GetCTSanphams()
                .Where(sp => sp.TrangThai == selectedRadioButtonText &&
                (TimMaSP == null || sp.MaSanPham == TimMaSP) &&
                (TimMaKT == null || sp.MaKichThuoc == TimMaKT) &&
                (TimMaCL == null || sp.MaChatLieu == TimMaCL) &&
                (TimMaMS == null || sp.MaMauSac == TimMaMS) &&
                (TimMaSL == null || sp.MaSale == TimMaSL) &&
                (string.IsNullOrEmpty(searchKeyword) || sp.TenSanPham.ToLower().Contains(searchKeyword)))
                .ToList();

            // Add the filtered data to the DataGridView
            foreach (var x in filteredData)
            {
                dtgView.Rows.Add(stt++, x.MaSanPhamChiTiet, x.MaSanPham, x.TenSanPham, x.Gia, x.SoLuong, x.MaKichThuoc, x.MaChatLieu, x.MaMauSac, x.MaSale, x.TrangThai);
            }

            // Refresh the DataGridView
            dtgView.Refresh();
        }

        private void CTSP_Load(object sender, EventArgs e)
        {

        }
    }
}
