using BUS.IService;
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
    public partial class QLNhanVien : Form
    {
        List<Nhanvien> lstnhanvien = NhanVienServices.GetAll();

        public QLNhanVien()
        {
            InitializeComponent();
            //Add giá trị cho combobox Lọc theo kiểu KM
            dgvNoiDung.DataSource = lstnhanvien;
            List<string> lstComboBoxLoc = new List<string>();
            for (int b = 0; b < lstnhanvien.Count; b++)
            {
                if (b == 0)
                {
                    lstComboBoxLoc.Add(lstnhanvien[0].TenChucVu);
                }
                else if (b != 0)
                {
                    bool giong = false;
                    for (int c = 0; c < lstComboBoxLoc.Count; c++)
                    {
                        if (string.Equals(lstnhanvien[b].TenChucVu, lstComboBoxLoc[c],
                            StringComparison.OrdinalIgnoreCase)) //so sánh 2 chuỗi ko phân biệt
                                                                 //chữ hoa chữ thường
                        {
                            giong = true;
                        }
                    }

                    if (giong == false)
                    {
                        lstComboBoxLoc.Add(lstnhanvien[b].TenChucVu);
                    }
                }
            }

            CbCV.Items.Clear();
            CbCV.Items.Add("");
            for (int d = 0; d < lstComboBoxLoc.Count; d++)
            {
                CbCV.Items.Add(lstComboBoxLoc[d]);
            }
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {

        }
        private void LoadData()
        {
            dgvNoiDung.DataSource = NhanVienServices.GetAll();
            dgvNoiDung.CellFormatting += GridCellFormatting;
            dgvNoiDung.Columns[0].Visible = false;

        }
        private void GridCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvNoiDung.Columns[e.ColumnIndex].Name == "STT")
            {
                e.Value = (e.RowIndex);
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {

            if (CbCV.Text == "")
            {
                LoadData();
            }
            else
            {
                found = NhanVienServices.GetLstObjectByCV(CbCV.Text).ToList();
                dgvNoiDung.DataSource = found;
            }
        }


        private void dgvNoiDung_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvNoiDung.CurrentRow;
            if (row.Index < dgvNoiDung.RowCount)
            {
                if (row.Cells[1].Value != null)
                {
                    txtMaNV.Text = (row.Cells[1]).Value.ToString();
                }
                if (row.Cells[2].Value != null)
                {
                    txtTenNV.Text = (row.Cells[2]).Value.ToString();
                }
                if (row.Cells[3].Value != null)
                {
                    txtDiaChi.Text = (row.Cells[3]).Value.ToString();
                }
                if (row.Cells[4].Value != null)
                {
                    txtSDT.Text = (row.Cells[4]).Value.ToString();
                }
                if (row.Cells[5].Value != null)
                {
                    txtGioiTinh.Text = (row.Cells[5]).Value.ToString();
                }
                if (row.Cells[6].Value != null)
                {
                    dtpNamSinh.Text = (row.Cells[6]).Value.ToString();
                }
                if (row.Cells[7].Value != null)
                {
                    txtChucVu.Text = (row.Cells[7]).Value.ToString();
                }
                if (row.Cells[8].Value != null)
                {
                    txtTrangThai.Text = (row.Cells[8]).Value.ToString();
                }
                if (row.Cells[9].Value != null)
                {
                    dtpNgayVaoLam.Text = (row.Cells[9]).Value.ToString();
                }
                if (row.Cells[10].Value != null)
                {
                    txtTenDangNhap.Text = (row.Cells[10]).Value.ToString();
                }
                if (row.Cells[11].Value != null)
                {
                    txtMatKhau.Text = (row.Cells[11]).Value.ToString();
                }


            }
        }



        Nhanvien nvSelected;


        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (CbCV.Text == null && txtTimKiem == null)
            {
                LoadData();
            }
            else if (txtTimKiem != null)
            {
                var lstnv = NhanVienServices.GetByID(txtTimKiem.Text);
                dgvNoiDung.DataSource = lstnv;
            }
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        List<Nhanvien> found = new List<Nhanvien>();

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "" || txtTenNV.Text == "" || txtDiaChi.Text == "" || txtSDT.Text == "" || txtGioiTinh.Text == "" || txtChucVu.Text == "" || txtTrangThai.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin trước khi thêm?", "Thông Báo Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                return;
            }

            nhanvienBindingSource.DataSource = new Nhanvien();
            Nhanvien nv = new Nhanvien();
            nv.MaNhanVien = txtMaNV.Text;
            nv.TenNhanVien = txtTenNV.Text;
            nv.DiaChi = txtDiaChi.Text;
            nv.SoDienThoai = txtSDT.Text;
            nv.GioiTinh = txtGioiTinh.Text;
            nv.NamSinh = dtpNamSinh.Value;
            nv.TenChucVu = txtChucVu.Text;
            nv.TrangThai = txtTrangThai.Text;
            nv.NgayVaoLam = dtpNgayVaoLam.Value;
            nv.TenDangNhap = txtTenDangNhap.Text;
            nv.MatKhau = txtMatKhau.Text;
            if (MessageBox.Show("Bạn Có Muốn Thêm?", "Thông Báo Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                NhanVienServices.Insert(nv);
            }
            LoadData();
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if(txtMaNV.Text == "" || txtTenNV.Text == "" || txtDiaChi.Text == "" || txtSDT.Text == "" || txtGioiTinh.Text == "" || txtChucVu.Text == "" || txtTrangThai.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin trước khi sửa?", "Thông Báo Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                return;
            }

            if (MessageBox.Show("Bạn Chắc Chắn Muốn Sửa?", "Thông Báo Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Nhanvien nv = new Nhanvien();
                nv.MaNhanVien = txtMaNV.Text;
                nv.TenNhanVien = txtTenNV.Text;
                nv.DiaChi = txtDiaChi.Text;
                nv.SoDienThoai = txtSDT.Text;
                nv.GioiTinh = txtGioiTinh.Text;
                nv.NamSinh = dtpNamSinh.Value;
                nv.TenChucVu = txtChucVu.Text;
                nv.TrangThai = txtTrangThai.Text;
                nv.NgayVaoLam = dtpNgayVaoLam.Value;
                nv.TenDangNhap = txtTenDangNhap.Text;
                nv.MatKhau = txtMatKhau.Text;
                NhanVienServices.Update(nv);
                LoadData();
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Vui lòng chọn nhân viên trước khi xóa?", "Thông Báo Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                return;
            }

            Nhanvien nv = new Nhanvien();
            nv.MaNhanVien = txtMaNV.Text;
            nv.TenNhanVien = txtTenNV.Text;
            nv.DiaChi = txtDiaChi.Text;
            nv.SoDienThoai = txtSDT.Text;
            nv.GioiTinh = txtGioiTinh.Text;
            nv.NamSinh = dtpNamSinh.Value;
            nv.TenChucVu = txtChucVu.Text;
            nv.TrangThai = txtTrangThai.Text;
            nv.NgayVaoLam = dtpNgayVaoLam.Value;
            nv.TenDangNhap = txtTenDangNhap.Text;
            nv.MatKhau = txtMatKhau.Text;

            bool timThay = false;
            var lstnv = NhanVienServices.GetByID(nv.MaNhanVien);
            for (int i = 0; i < lstnv.Count; i++)
            {
                if (lstnv[i].MaNhanVien == txtMaNV.Text)
                {
                    timThay = true;
                }
            }

            if (timThay == false)
            {
                MessageBox.Show("Không tìm thấy mã Nhân Viên", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                return;
            }

            if (MessageBox.Show("Bạn Chắc Chắn Muốn Xóa?", "Thông Báo Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                NhanVienServices.Delete(nv);
                LoadData();
            }
        }

        private void dgvNoiDung_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            var selectnhanvien = dgvNoiDung.Rows[index];
            if (selectnhanvien.Cells[9].Value != null)
            {
                txtTenDangNhap.Text = selectnhanvien.Cells[9].Value.ToString();
            }
            else
            {
                txtTenDangNhap.Text = "";
            }

            if (selectnhanvien.Cells[10].Value != null)
            {
                txtMatKhau.Text = selectnhanvien.Cells[10].Value.ToString();
            }
            else
            {
                txtMatKhau.Text = "";
            }
            txtMaNV.Text = selectnhanvien.Cells[1].Value.ToString();
            txtTenNV.Text = selectnhanvien.Cells[2].Value.ToString();
            txtDiaChi.Text = selectnhanvien.Cells[3].Value.ToString();
            txtSDT.Text = selectnhanvien.Cells[4].Value.ToString();
            txtGioiTinh.Text = selectnhanvien.Cells[5].Value.ToString();
            dtpNamSinh.Text = selectnhanvien.Cells[6].Value.ToString();
            txtChucVu.Text = selectnhanvien.Cells[7].Value.ToString();
            txtTrangThai.Text = selectnhanvien.Cells[8].Value.ToString();
            dtpNgayVaoLam.Text = selectnhanvien.Cells[11].Value.ToString();
        }
    }
}
