using BUS.IService;
using DAL.Models;
using DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace PRL.Forms
{
    public partial class quanLiMaGiamGia : Form
    {
        private IKhuyenMaiServices _service;

        bool daLoc;
        string textSaveFOrCCB;

        public quanLiMaGiamGia(IKhuyenMaiServices service)
        {
            InitializeComponent();
            _service = service;

            daLoc = false;

            //Làm trống dateTimePicker
            dTPNT.Format = DateTimePickerFormat.Custom;
            dTPNT.CustomFormat = " ";

            dTPNHH.Format = DateTimePickerFormat.Custom;
            dTPNHH.CustomFormat = " ";
        }

        //Cho dateTimePicker hiện giá trị trở lại
        private void dTPNT_ValueChanged(object sender, EventArgs e)
        {
            dTPNT.Format = DateTimePickerFormat.Short;
        }

        private void dTPNHH_ValueChanged(object sender, EventArgs e)
        {
            dTPNHH.Format = DateTimePickerFormat.Short;
        }

        //Bỏ Focus các thành phần khi click vào khoảng không
        private void Form_Ma_giam_gia_MouseClick(object sender, MouseEventArgs e)
        {
            //cho focus vào một label tàn hình
            labelFocus.Focus();
        }

        //Phương thức Load Form
        public void LoadForm()
        {
            //Xử lý ngoại lệ bảng trong csdl bị trống
            List<Khuyenmai> lstKM = new List<Khuyenmai>();
            try
            {
                lstKM = _service.GetAll();
                if (lstKM.Count == 0)
                {
                    MessageBox.Show("Bảng trống!!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không xác đinh!!\nChi tiết: " + ex, "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }

            //Add bảng trong csdl vào datagridview
            dataGridView1.DataSource = lstKM;

            //Add giá trị cho cột STT
            int a = 1;
            for (int i = 0; i < lstKM.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = a;
                a++;
            }

            LoadCBB();
        }

        //Ham Load Combobox
        public void LoadCBB()
        {
            var lstKM = _service.GetAll();

            textSaveFOrCCB = comboBoxLoc.Text;
            //Add giá trị cho combobox Lọc theo kiểu KM
            List<string> lstComboBoxLoc = new List<string>();
            for (int b = 0; b < lstKM.Count; b++)
            {
                if (b == 0)
                {
                    lstComboBoxLoc.Add(lstKM[0].KieuKhuyenMai);
                }
                else if (b != 0)
                {
                    bool giong = false;
                    for (int c = 0; c < lstComboBoxLoc.Count; c++)
                    {
                        if (string.Equals(lstKM[b].KieuKhuyenMai, lstComboBoxLoc[c],
                            StringComparison.OrdinalIgnoreCase)) //so sánh 2 chuỗi ko phân biệt
                                                                 //chữ hoa chữ thường
                        {
                            giong = true;
                        }
                    }

                    if (giong == false)
                    {
                        lstComboBoxLoc.Add(lstKM[b].KieuKhuyenMai);
                    }
                }
            }

            comboBoxLoc.Items.Clear();
            comboBoxLoc.Items.Add("");
            for (int d = 0; d < lstComboBoxLoc.Count; d++)
            {
                comboBoxLoc.Items.Add(lstComboBoxLoc[d]);
            }

            for (int i = 0; i < lstComboBoxLoc.Count; i++)
            {
                if (lstComboBoxLoc[i] == textSaveFOrCCB)
                {
                    comboBoxLoc.Text = textSaveFOrCCB;
                }
            }
        }

        //Load Form
        private void Form_Ma_giam_gia_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        //Hiện thông tin của cell/row được chọn lên textbox
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow RowSelected = dataGridView1.Rows[e.RowIndex];

                //Xử lý ngoại lệ khi click vào cell/row trống
                if (RowSelected.Cells["MaKhuyenMai"].Value == null ||
                    RowSelected.Cells["NgayTao"].Value == null ||
                    RowSelected.Cells["NgayHetHan"].Value == null ||
                    RowSelected.Cells["KieuKhuyenMai"].Value == null ||
                    RowSelected.Cells["MucGiam"].Value == null ||
                    RowSelected.Cells["TrangThai"].Value == null ||
                    RowSelected.Cells["SoLuong"].Value == null ||
                    RowSelected.Cells["GhiChu"].Value == null)
                {
                    return;
                }

                //Truyền row đã chọn lên textbox
                textBoxMaKM.Text = RowSelected.Cells["MaKhuyenMai"].Value.ToString();
                dTPNT.Text = RowSelected.Cells["NgayTao"].Value.ToString();
                dTPNHH.Text = RowSelected.Cells["NgayHetHan"].Value.ToString();
                textBoxKieuKM.Text = RowSelected.Cells["KieuKhuyenMai"].Value.ToString();
                textBoxMucGiam.Text = RowSelected.Cells["MucGiam"].Value.ToString();
                textBoxTrangThai.Text = RowSelected.Cells["TrangThai"].Value.ToString();
                numberUDSL.Value = Convert.ToInt32(RowSelected.Cells["SoLuong"].Value);
                richTextBoxGhiChu.Text = RowSelected.Cells["GhiChu"].Value.ToString();
            }
        }


        //Tính năng Xem
        private void buttonXem_Click(object sender, EventArgs e)
        {
            LoadForm();
            daLoc = false;
        }


        //Tính năng Thêm
        private void buttonThem_Click(object sender, EventArgs e)
        {
            //Kiểm tra ngoại lệ các giá trị bị trống
            if (textBoxMaKM.Text == "" || textBoxKieuKM.Text == "" || textBoxMucGiam.Text == "" ||
                dTPNT.Text == "" || dTPNHH.Text == "" || numberUDSL.Text == "" ||
                textBoxTrangThai.Text == "" || richTextBoxGhiChu.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin trước khi Thêm !!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }

            //Kiểm tra ngoại lệ Mã KM bị trùng khi thêm
            try
            {
                var OjectFound = _service.GetOject(textBoxMaKM.Text);
                if (OjectFound != null)
                {
                    MessageBox.Show("Mã KM bị trùng, Vui lòng nhập Mã KM khác !!", "Thông báo",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không xác định!! Vui lòng thử lại!!\nChi tiết: " + ex, "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }

            //Thông báo xác nhận trước khi thêm
            var ms = MessageBox.Show("Có chắc muốn thêm không ?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (ms == DialogResult.Cancel)
            {
                return;
            }

            //Thêm Oject vào csdl
            Khuyenmai km = new Khuyenmai();
            km.MaKhuyenMai = textBoxMaKM.Text;
            km.NgayTao = dTPNT.Value;
            km.NgayHetHan = dTPNHH.Value;
            km.KieuKhuyenMai = textBoxKieuKM.Text;
            km.MucGiam = textBoxMucGiam.Text;
            km.TrangThai = textBoxTrangThai.Text;
            km.SoLuong = Convert.ToInt32(numberUDSL.Text);
            km.GhiChu = richTextBoxGhiChu.Text;

            //Xử lý ngoại lệ trong quá trình Thêm Khuyến mãi
            try
            {
                _service.Insert(km);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi trong quá trình Thêm Khuyến Mãi vào hệ thống!! Vui lòng thử lại!!\nChi tiết: " + ex, "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }

            //Thông báo khi Thêm thành công
            MessageBox.Show("Thêm thành công!!", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            daLoc = false;
            LoadForm();
        }


        //Tính năng Sửa
        private void buttonSua_Click(object sender, EventArgs e)
        {
            //Kiểm tra ngoại lệ các giá trị bị trống
            if (textBoxMaKM.Text == "" || textBoxKieuKM.Text == "" || textBoxMucGiam.Text == "" ||
                dTPNT.Text == "" || dTPNHH.Text == "" || numberUDSL.Text == "" ||
                textBoxTrangThai.Text == "" || richTextBoxGhiChu.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin trước khi Sửa !!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }

            //Kiểm tra ngoại lệ Mã KM không tìm thấy
            try
            {
                var OjectFound = _service.GetOject(textBoxMaKM.Text);
                if (OjectFound == null)
                {
                    MessageBox.Show("Không tìm thấy Mã KM!! Vui lòng kiểm tra lại!!", "Thông báo",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không xác định!! Vui lòng thử lại!!\nChi tiết: " + ex, "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }

            //Thông báo xác nhận trước khi Sửa
            var ms = MessageBox.Show("Có chắc muốn sửa không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (ms == DialogResult.Cancel)
            {
                return;
            }

            Khuyenmai km = new Khuyenmai();
            km.MaKhuyenMai = textBoxMaKM.Text;
            km.NgayTao = dTPNT.Value;
            km.NgayHetHan = dTPNHH.Value;
            km.MucGiam = textBoxMucGiam.Text;
            km.KieuKhuyenMai = textBoxKieuKM.Text;
            km.TrangThai = textBoxTrangThai.Text;
            km.SoLuong = Convert.ToInt32(numberUDSL.Value);
            km.GhiChu = richTextBoxGhiChu.Text;

            //Xử lý ngoại lệ trong quá trình Sửa Khuyến Mãi
            try
            {
                _service.Update(km);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi trong quá trình hệ thống thực hiện Sửa Khuyến Mãi!! Vui lòng thử lại!!\nChi tiết: " + ex, "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }

            //Thông báo sửa thành công
            MessageBox.Show("Sửa thành công!!", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (daLoc == false)
            {
                LoadForm();
            }
            else if (daLoc == true)
            {
                LocTongHop();
                LoadCBB();
            }
        }


        //Tính năng Xóa
        private void buttonXoa_Click(object sender, EventArgs e)
        {
            Khuyenmai OjectFound = new Khuyenmai();
            //Xử lý ngoại lệ không tìm thấy
            try
            {
                OjectFound = _service.GetOject(textBoxMaKM.Text);
                if (OjectFound == null)
                {
                    MessageBox.Show("Không tìm thấy Mã KM!! Vui lòng kiểm tra lại!!", "Thông báo",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không xác định!! Vui lòng thử lại!!\nChi tiết: " + ex, "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }

            //Thông báo xác nhận trước khi Xóa
            var ms = MessageBox.Show("Có chắc muốn xóa không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (ms == DialogResult.Cancel)
            {
                return;
            }

            //Xử lý ngoại lệ trong quá trình xóa
            try
            {
                Khuyenmai km = new Khuyenmai();
                km.MaKhuyenMai = textBoxMaKM.Text;
                km.NgayTao = dTPNT.Value;
                km.NgayHetHan = dTPNHH.Value;
                km.KieuKhuyenMai = textBoxKieuKM.Text;
                km.MucGiam = textBoxMucGiam.Text;
                km.TrangThai = "Hết";
                km.SoLuong = Convert.ToInt32(numberUDSL.Text);
                km.GhiChu = richTextBoxGhiChu.Text;
                _service.Update(km);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không xác định trong quá trình Xóa Khuyến Mãi!! Vui lòng thử lại!!\nChi tiết: " + ex, "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }

            //Thông báo Xóa thành công
            MessageBox.Show("Xóa thành công!!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (daLoc == false)
            {
                LoadForm();
            }
            else if (daLoc == true)
            {
                LocTongHop();
                LoadCBB();
            }
        }


        //Tính năng Tìm kiếm
        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            //Xử lý ngoại lệ khi để trống textbox tìm kiếm
            if (textBoxTimKiem.Text == "")
            {
                MessageBox.Show("Vui lòng điền giá trị cần tìm trước khi tìm kiếm!!", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }

            Khuyenmai kmFound = new Khuyenmai();

            //Xử lý ngoại lệ không tìm thấy
            try
            {
                kmFound = _service.GetOject(textBoxTimKiem.Text);
                if (kmFound == null)
                {
                    MessageBox.Show("Không tìm thấy Mã Khuyến Mãi!! Vui lòng kiểm tra lại", "Thống báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không xác định!! Vui lòng thử lại!!\nChi tiết: " + ex, "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }

            List<Khuyenmai> lstKM = new List<Khuyenmai>();
            lstKM.Add(kmFound);

            //Hiện kết quả tìm thấy ra datagridview
            dataGridView1.DataSource = lstKM;
            daLoc = false;
        }


        //Hàm Lọc tổng hợp giữa Lọc theo Kiểu KM và Khoảng Số Lượng
        public void LocTongHop()
        {
            if (comboBoxLoc.Text == "" && textBoxLocTu.Text == "" && textBoxLocDen.Text == "")
            {
                LoadForm();
            }
            else if (comboBoxLoc.Text != "" && textBoxLocTu.Text == "" ||
                comboBoxLoc.Text != "" && textBoxLocDen.Text == "")
            {
                //Xử lý ngoại lệ không xác định
                try
                {
                    dataGridView1.DataSource = _service.GetLstObjectByKKM(comboBoxLoc.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi không xác định!! Vui lòng thử lại!!\nChi tiết: " + ex, "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }

                daLoc = true;
            }
            else if (comboBoxLoc.Text != "" && textBoxLocTu.Text != "" && textBoxLocDen.Text != "")
            {
                List<Khuyenmai> lstKMLocTheoKKM = new List<Khuyenmai>();
                //Xử lý ngoại lệ không xác định
                try
                {
                    lstKMLocTheoKKM = _service.GetLstObjectByKKM(comboBoxLoc.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi không xác định!! Vui lòng thử lại!!\nChi tiết: " + ex, "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }

                List<Khuyenmai> lstLocTheoKKMVaSL = new List<Khuyenmai>();
                for (int i = 0; i < lstKMLocTheoKKM.Count; i++)
                {
                    int tu = Convert.ToInt32(textBoxLocTu.Text);
                    int den = Convert.ToInt32(textBoxLocDen.Text);
                    int stringCut = lstKMLocTheoKKM[i].SoLuong;

                    if (tu < den)
                    {
                        if (tu <= stringCut && stringCut <= den)
                        {
                            lstLocTheoKKMVaSL.Add(lstKMLocTheoKKM[i]);
                        }
                    }
                    else if (tu > den)
                    {
                        if (tu >= stringCut && stringCut >= den)
                        {
                            lstLocTheoKKMVaSL.Add(lstKMLocTheoKKM[i]);
                        }
                    }
                    else if (tu == den)
                    {
                        if (stringCut == den)
                        {
                            lstLocTheoKKMVaSL.Add(lstKMLocTheoKKM[i]);
                        }
                    }
                }

                daLoc = true;
                dataGridView1.DataSource = lstLocTheoKKMVaSL;
            }
            else if (comboBoxLoc.Text == "" && textBoxLocTu.Text != "" && textBoxLocDen.Text != "")
            {
                List<Khuyenmai> lstLocTheoSL = new List<Khuyenmai>();
                int tu = Convert.ToInt32(textBoxLocTu.Text);
                int den = Convert.ToInt32(textBoxLocDen.Text);

                //Xử lý ngoại lệ không xác định
                try
                {
                    var lstKM = _service.GetAll();
                    lstLocTheoSL = _service.GetLstOjectBySL(tu, den);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi không xác định!! Vui lòng thử lại!!\nChi tiết: " + ex, "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }

                daLoc = true;
                dataGridView1.DataSource = lstLocTheoSL;
            }

            textSaveFOrCCB = comboBoxLoc.Text;
        }

        private void buttonLoc_Click(object sender, EventArgs e)
        {
            LocTongHop();
        }


        //Ngăn ko cho người dùng nhập vào textboxLoc những ký tự khác số
        private void textBoxLocTu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void textBoxLocDen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }


        //Add STT mỗi khi bảng thay đổi
        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int a = 1;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = a;
                a++;
            }
        }
    }
}
