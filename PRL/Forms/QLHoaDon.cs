using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms.Design;
using DAL.IRepositories;
using BUS.IService;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Drawing.Printing;

namespace PRL.Forms
{
    public partial class QLHoaDon : Form
    {
        private IHoaDonServices _service;

        public QLHoaDon(IHoaDonServices service)
        {
            InitializeComponent();
            _service = service;
        }

        private void Form_HoaDon_Load(object sender, EventArgs e)
        {
            //Xử lý ngoại lệ bảng hóa đơn và sản phẩm chi tiết bị trống
            try
            {
                dataGridView1.DataSource = _service.GetAllHD();
                dataGridView3.DataSource = _service.GetAllSpct();

                if (_service.GetAllHD() == null)
                {
                    MessageBox.Show("Hóa đơn trống!!", "Thông báo",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    return;
                }
                else if (_service.GetAllSpct() == null)
                {
                    MessageBox.Show("Sản phẩm chi tiết trống!!", "Thông báo",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    return;
                }
                else if (_service.GetAllHD() == null && _service.GetAllSpct() == null)
                {
                    MessageBox.Show("Hóa đơn trống!!", "Thông báo",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    MessageBox.Show("Sản phẩm chi tiết trống!!", "Thông báo",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    return;
                }

                AddSTTCloumn(dataGridView1);
                AddSTTCloumn(dataGridView3);
            }
            catch (Exception ex)
            {
                //Ngoại lệ không xác định
                MessageBox.Show($"Lỗi không xác định!! Vui lòng thử lại\nChi tiết lỗi {ex}", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
        }

        //Hàm tính thành tiền và Add cột Thành tiền cho datagridview2
        public void TinhVaAddCotThanhTien()
        {
            bool columnExists = false;
            foreach (DataGridViewColumn column in dataGridView2.Columns)
            {
                if (column.HeaderText == "ThanhTien")
                {
                    columnExists = true;
                    break;
                }
            }

            //Xử lý ngoại lệ hóa đơn không có sản phẩm và ngoại lệ không xác định
            List<TbJoinHdctSpct> lstHdct;
            try
            {
                lstHdct = _service.GetSPTrongHD(textBoxMaHD.Text);
                if (lstHdct == null)
                {
                    MessageBox.Show("Chưa thêm sản phẩm nào hóa đơn!!", "Thông báo",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception ex)
            {
                //Ngoại lệ không xác định
                MessageBox.Show($"Lỗi không xác định!! Vui lòng thử lại\nChi tiết lỗi {ex}", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }

            dataGridView2.DataSource = lstHdct;
            if (columnExists == false)
            {
                dataGridView2.Columns.Add("ThanhTien", "ThanhTien");
            }

            for (int i = 0; i < lstHdct.Count; i++)
            {
                if (textBoxTrangThai.Text == "Chưa thanh toán")
                {
                    bool dGSlE0 = false;
                    //Trường hợp số lượng hoặc đơn giá = 0
                    if (lstHdct[i].DonGia == 0 || lstHdct[i].SoLuong == 0)
                    {
                        float thanhTien = 0;
                        dataGridView2.Rows[i].Cells["ThanhTien"].Value = thanhTien;
                        dGSlE0 = true;
                    }

                    if (dGSlE0 == false)
                    {
                        if (lstHdct[i].NgayHetHanS.Year > DateTime.Now.Year ||
                        lstHdct[i].NgayHetHanS.Year == DateTime.Now.Year && lstHdct[i].NgayHetHanS.Month > DateTime.Now.Month ||
                        lstHdct[i].NgayHetHanS.Year == DateTime.Now.Year && lstHdct[i].NgayHetHanS.Month == DateTime.Now.Month && lstHdct[i].NgayHetHanS.Day > DateTime.Now.Day)
                        {
                            float thanhTien = ((float)Convert.ToDouble((lstHdct[i].DonGia) - (float)Convert.ToDouble(lstHdct[i].Sale)) * (float)Convert.ToInt32(lstHdct[i].SoLuong));
                            dataGridView2.Rows[i].Cells["ThanhTien"].Value = thanhTien;
                        }
                        else
                        {
                            float thanhTien = (float)Convert.ToDouble((lstHdct[i].DonGia) * (float)Convert.ToInt32(lstHdct[i].SoLuong));
                            dataGridView2.Rows[i].Cells["ThanhTien"].Value = thanhTien;
                        }
                    }
                }
                else if (textBoxTrangThai.Text == "Đã thanh toán")
                {
                    bool dGSlE0 = false;
                    //Trường hợp số lượng hoặc đơn giá = 0
                    if (lstHdct[i].DonGia == 0 || lstHdct[i].SoLuong == 0)
                    {
                        float thanhTien = 0;
                        dataGridView2.Rows[i].Cells["ThanhTien"].Value = thanhTien;
                        dGSlE0 = true;
                    }

                    if (dGSlE0 == false)
                    {
                        int indexR = 0;
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.Cells["MaHoaDon"].Value.ToString() == textBoxMaHD.Text)
                            {
                                indexR = row.Index;
                                break;
                            }
                        }
                        var dateTT = Convert.ToDateTime(dataGridView1.Rows[indexR].Cells["NgayThanhToan"].Value);

                        if (lstHdct[i].NgayHetHanS.Year > dateTT.Year ||
                        lstHdct[i].NgayHetHanS.Year == dateTT.Year && lstHdct[i].NgayHetHanS.Month > dateTT.Month ||
                        lstHdct[i].NgayHetHanS.Year == dateTT.Year && lstHdct[i].NgayHetHanS.Month == dateTT.Month && lstHdct[i].NgayHetHanS.Day > dateTT.Day)
                        {
                            float thanhTien = ((float)Convert.ToDouble((lstHdct[i].DonGia) - (float)Convert.ToDouble(lstHdct[i].Sale)) * (float)Convert.ToInt32(lstHdct[i].SoLuong));
                            dataGridView2.Rows[i].Cells["ThanhTien"].Value = thanhTien;
                        }
                        else
                        {
                            float thanhTien = (float)Convert.ToDouble((lstHdct[i].DonGia) * (float)Convert.ToInt32(lstHdct[i].SoLuong));
                            dataGridView2.Rows[i].Cells["ThanhTien"].Value = thanhTien;
                        }
                    }
                }

                dataGridView2.Columns["MaHoaDon"].Visible = false;
                dataGridView2.Columns["MaHoaDonCT"].Visible = false;
            }
        }

        //Update lại Tổng Tiền trong hóa đơn
        public void UpdateTongTienHD()
        {
            Hoadon hd = new Hoadon();
            hd.MaHoaDon = textBoxMaHD.Text;
            hd.SoDienThoai = textBoxSDT.Text;
            hd.MaNhanVien = textBoxMaNV.Text;
            hd.MaKhuyenMai = textBoxMaKM.Text;
            hd.NgayLap = Convert.ToDateTime(textBoxNgayLap.Text);
            hd.TrangThai = textBoxTrangThai.Text;
            hd.TongTien = TinhTongTien();
            _service.UpdateHD(hd);

            dataGridView1.DataSource = _service.GetAllHD();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dGV1RowSelected = dataGridView1.Rows[e.RowIndex];

                //Xử lý ngoại lệ khi click vào row trống
                if (dGV1RowSelected.Cells["MaHoaDon"].Value == null ||
                    dGV1RowSelected.Cells["SoDienThoai"].Value == null ||
                    dGV1RowSelected.Cells["MaNhanVien"].Value == null ||
                    dGV1RowSelected.Cells["MaKhuyenMai"].Value == null ||
                    dGV1RowSelected.Cells["NgayLap"].Value == null ||
                    dGV1RowSelected.Cells["TrangThai"].Value == null ||
                    dGV1RowSelected.Cells["TongTien"].Value == null)
                {
                    return;
                }

                //Truyền row đã chọn lên textbox
                textBoxMaHD.Text = dGV1RowSelected.Cells["MaHoaDon"].Value.ToString();
                textBoxSDT.Text = dGV1RowSelected.Cells["SoDienThoai"].Value.ToString();
                textBoxMaNV.Text = dGV1RowSelected.Cells["MaNhanVien"].Value.ToString();
                textBoxMaKM.Text = dGV1RowSelected.Cells["MaKhuyenMai"].Value.ToString();
                int index = dGV1RowSelected.Cells["NgayLap"].Value.ToString().IndexOf(" ");
                textBoxNgayLap.Text = dGV1RowSelected.Cells["NgayLap"].Value.ToString().Substring(0, index);
                textBoxTrangThai.Text = dGV1RowSelected.Cells["TrangThai"].Value.ToString();
                textBoxTongTien.Text = dGV1RowSelected.Cells["TongTien"].Value.ToString();
                if (textBoxTrangThai.Text == "Đã thanh toán")
                {
                    int index2 = dGV1RowSelected.Cells["NgayThanhToan"].Value.ToString().IndexOf(" ");
                    textBoxNTT.Text = dGV1RowSelected.Cells["NgayThanhToan"].Value.ToString().Substring(0, index2);
                }
                else if (textBoxTrangThai.Text == "Chưa thanh toán")
                {
                    textBoxNTT.Text = "";
                }

                //Thêm cột thành tiền cho datagridview
                TinhVaAddCotThanhTien();

                textBoxMaSp.Text = "";
                textBoxMaSpct.Text = "";
                textBoxSL.Text = "";
                textBoxDonGia.Text = "";
                richTextBoxGhiChu.Text = "";
            }
        }

        //Hàm tính tổng tiền hóa đơn
        public float TinhTongTien()
        {
            float tongTien = 0;

            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                tongTien = tongTien + (float)Convert.ToDouble(dataGridView2.Rows[i].Cells["ThanhTien"].Value);
            }

            var km = _service.GetKMByMaKM(textBoxMaKM.Text);

            if (textBoxTrangThai.Text == "Chưa thanh toán")
            {
                if (km.NgayHetHan.Year > DateTime.Now.Year && km.TrangThai == "Còn" ||
                    km.NgayHetHan.Year == DateTime.Now.Year && km.NgayHetHan.Month > DateTime.Now.Month && km.TrangThai == "Còn" ||
                    km.NgayHetHan.Year == DateTime.Now.Year && km.NgayHetHan.Month == DateTime.Now.Month && km.NgayHetHan.Day > DateTime.Now.Day && km.TrangThai == "Còn")
                {
                    tongTien = tongTien - (float)Convert.ToDouble(km.MucGiam);
                }
            }
            else if (textBoxTrangThai.Text == "Đã thanh toán")
            {
                int indexR = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["MaHoaDon"].Value.ToString() == textBoxMaHD.Text)
                    {
                        indexR = row.Index;
                        break;
                    }
                }
                var dateTT = Convert.ToDateTime(dataGridView1.Rows[indexR].Cells["NgayThanhToan"].Value);

                if (km.NgayHetHan.Year > dateTT.Year && km.TrangThai == "Còn" ||
                    km.NgayHetHan.Year == dateTT.Year && km.NgayHetHan.Month > dateTT.Month && km.TrangThai == "Còn" ||
                    km.NgayHetHan.Year == dateTT.Year && km.NgayHetHan.Month == dateTT.Month && km.NgayHetHan.Day > dateTT.Day && km.TrangThai == "Còn")
                {
                    tongTien = tongTien - (float)Convert.ToDouble(km.MucGiam);
                }
            }

            return tongTien;
        }

        DataGridViewRow dGV2RowSelected;
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dGV2RowSelected = dataGridView2.Rows[e.RowIndex];

                //Xử lý ngoại lệ khi click vào row trống
                if (dGV2RowSelected.Cells["MaSanPham"].Value == null ||
                    dGV2RowSelected.Cells["MaSanPhamChiTiet"].Value == null ||
                    dGV2RowSelected.Cells["TenSanPham"].Value == null ||
                    dGV2RowSelected.Cells["DonGia"].Value == null ||
                    dGV2RowSelected.Cells["SoLuong"].Value == null ||
                    dGV2RowSelected.Cells["Sale"].Value == null ||
                    dGV2RowSelected.Cells["NgayHetHanS"].Value == null ||
                    dGV2RowSelected.Cells["GhiChu"].Value == null ||
                    dGV2RowSelected.Cells["ThanhTien"].Value == null)
                {
                    return;
                }

                //Truyền row đã chọn lên textbox
                textBoxMaHdct.Text = dGV2RowSelected.Cells["MaHoaDonCT"].Value.ToString();
                textBoxMaSp.Text = dGV2RowSelected.Cells["MaSanPham"].Value.ToString();
                textBoxMaSpct.Text = dGV2RowSelected.Cells["MaSanPhamChiTiet"].Value.ToString();
                textBoxSL.Text = dGV2RowSelected.Cells["SoLuong"].Value.ToString();
                textBoxDonGia.Text = dGV2RowSelected.Cells["DonGia"].Value.ToString();
                richTextBoxGhiChu.Text = dGV2RowSelected.Cells["GhiChu"].Value.ToString();
            }
        }

        //Không cho nhập vào số lượng ký tự khác ngoài số
        private void textBoxSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        //Không cho phép nhập số lượng sản phẩm > số lượng Spct
        private void textBoxSL_TextChanged(object sender, EventArgs e)
        {
            if (textBoxMaSpct.Text == "")
            {
                return;
            }

            if (textBoxSL.Text == "")
            {
                return;
            }

            var km = _service.GetSpctByMaSpct(textBoxMaSpct.Text);
            if (km == null)
            {
                return;
            }

            int tongDat = Convert.ToInt32(textBoxSL.Text);
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                if (dataGridView2.Rows[i].Cells["MaSanPhamChiTiet"].Value.ToString() == textBoxMaSpct.Text)
                {
                    tongDat = tongDat + Convert.ToInt32(dataGridView2.Rows[i].Cells["SoLuong"].Value);
                }
            }

            if (tongDat > km.SoLuong)
            {
                panel2.Location = new Point(textBoxSL.Location.X + 100, textBoxSL.Location.Y - 30);
                panel2.Visible = true;
                richTextBox1.Text = "Bạn đã thêm tổng số lượng Sản phẩm này vào hóa đơn là " +
                    (tongDat - Convert.ToInt32(textBoxSL.Text)) + "/" + km.SoLuong +
                    " sản phẩm. Vui lòng nhập số lượng ít hơn hoặc bằng " + (km.SoLuong - (tongDat - Convert.ToInt32(textBoxSL.Text)));
                textBoxSL.Text = "";
            }
        }

        //Tắt thông báo số lượng (Panel2)
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            panel2.Visible = false;
        }

        //Không cho phép nhập vào đơn giá chữ hoặc số âm
        private void textBoxDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        //Không cho nhập vào số lượng ký tự khác ngoài số
        private void textBoxPnSl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        //Không cho phép nhập số lượng sản phẩm > số lượng Spct
        private void textBoxPnSl_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPnMaSpct.Text == "")
            {
                return;
            }

            if (textBoxPnSl.Text == "")
            {
                return;
            }

            var km = _service.GetSpctByMaSpct(textBoxPnMaSpct.Text);
            if (km == null)
            {
                return;
            }

            int tongDat = Convert.ToInt32(textBoxPnSl.Text);
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                if (dataGridView2.Rows[i].Cells["MaSanPhamChiTiet"].Value.ToString() == textBoxPnMaSpct.Text)
                {
                    tongDat = tongDat + Convert.ToInt32(dataGridView2.Rows[i].Cells["SoLuong"].Value);
                }
            }

            if (tongDat > km.SoLuong)
            {
                panel2.Location = new Point(panel1.Location.X + 220, panel1.Location.Y + 50);
                panel2.BringToFront();
                panel2.Visible = true;
                richTextBox1.Text = "Bạn đã thêm tổng số lượng Sản phẩm này vào hóa đơn là " +
                    (tongDat - Convert.ToInt32(textBoxPnSl.Text)) + "/" + km.SoLuong +
                    " sản phẩm. Vui lòng nhập số lượng ít hơn hoặc bằng " + (km.SoLuong - (tongDat - Convert.ToInt32(textBoxPnSl.Text)));
                textBoxPnSl.Text = "";
            }
        }


        //Hàm làm nền ảnh
        public System.Drawing.Image MakeBackGroundImg()
        {
            // Tạo một đối tượng Bitmap với kích thước của form
            Bitmap bitmap = new Bitmap(this.Width, this.Height);

            // Tạo một đối tượng Graphics từ đối tượng Bitmap
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                // Vẽ tất cả các thành phần trong form, trừ form chính
                foreach (Control control in this.Controls)
                {
                    if (control != this && control != textBoxMaHdct && control != panel3)
                    {
                        control.DrawToBitmap(bitmap, control.Bounds);
                    }
                }
            }

            // Tạo một đối tượng Bitmap mới để chứa ảnh đã làm mờ
            Bitmap blurredImage = new Bitmap(bitmap.Width, bitmap.Height);

            // Tạo một đối tượng Graphics từ ảnh đã làm mờ
            using (Graphics graphics = Graphics.FromImage(blurredImage))
            {
                // Tạo một hiệu ứng làm mờ bằng cách vẽ ảnh ban đầu lên ảnh mới với thuộc tính Opacity
                using (ImageAttributes imageAttributes = new ImageAttributes())
                {
                    // Đặt thuộc tính Opacity để làm mờ ảnh
                    imageAttributes.SetColorMatrix(new ColorMatrix { Matrix33 = 0.4f });

                    // Vẽ ảnh ban đầu lên ảnh mới với thuộc tính Opacity
                    graphics.DrawImage(bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height), 0, 0, bitmap
                        .Width, bitmap.Height, GraphicsUnit.Pixel, imageAttributes);
                }
            }

            return blurredImage;
        }

        //Thêm sản phẩm vào hóa đơn
        private void buttonThemSP_Click(object sender, EventArgs e)
        {
            //Không cho thêm sản phẩm vào hóa đơn đã thanh toán
            if (textBoxTrangThai.Text == "Đã thanh toán")
            {
                MessageBox.Show("Vui lòng không thêm sản phẩm vào hóa đơn đã thanh toán!!",
                    "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return;
            }

            if (textBoxMaHD.Text == "")
            {
                MessageBox.Show("Vui lòng chọn hóa đơn trước khi thêm sản phẩm!!",
                    "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return;
            }

            if (rowSpctSelected == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần thêm vào hóa đơn!!",
                    "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return;
            }

            // Hiển thị ảnh đã chụp lên một PictureBox
            pictureBox1.Visible = true;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = MakeBackGroundImg();
            panel1.Visible = true;

            pictureBox1.BringToFront();
            panel1.BringToFront();

            panel1.Focus();
        }

        DataGridViewRow rowSpctSelected;
        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                rowSpctSelected = dataGridView3.Rows[e.RowIndex];
                textBoxPnMaSp.Text = rowSpctSelected.Cells["MaSanPham"].Value.ToString();
                textBoxPnMaSpct.Text = rowSpctSelected.Cells["MaSanPhamChiTiet"].Value.ToString();
                textBoxPnDonGia.Text = rowSpctSelected.Cells["Gia"].Value.ToString();
            }
            else
            {
                return;
            }
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            panel1.Visible = false;
            textBoxPnSl.Text = "";
            richTextBoxPnGC.Text = "";
            textBoxPnDonGia.Text = rowSpctSelected.Cells["Gia"].Value.ToString();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBoxPnMaSp.Text == "" || textBoxPnMaSpct.Text == "" || textBoxPnSl.Text == ""
                || textBoxPnDonGia.Text == "" || richTextBoxPnGC.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin trước khi thêm!!",
                    "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return;
            }

            DialogResult dlrs = MessageBox.Show("Bạn có chắc muốn thêm sản phẩm này vào Hóa Đơn " +
                textBoxMaHD.Text + " không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlrs == DialogResult.Cancel)
            {
                return;
            }

            //Tự sinh mã Hdct
            List<Hoadonchitiet> lstHdct1 = _service.GetAllHdct();
            List<string> lstMaHdct = new List<string>();
            for (int i = 0; i < lstHdct1.Count; i++)
            {
                lstMaHdct.Add(lstHdct1[i].MaHoaDonChiTiet);
            }

            Random random = new Random();
            string maHdctTuSinh = "";
            do
            {
                maHdctTuSinh = "HDCT" + random.Next(0, 10 ^ 251 - 1).ToString();
            } while (lstMaHdct.Contains(maHdctTuSinh));

            //Thêm Hdct
            Hoadonchitiet hdct = new Hoadonchitiet();
            hdct.MaHoaDonChiTiet = maHdctTuSinh;
            hdct.MaHoaDon = textBoxMaHD.Text;
            hdct.MaSanPhamChiTiet = textBoxPnMaSpct.Text;
            hdct.SoLuong = Convert.ToInt32(textBoxPnSl.Text);
            hdct.DonGia = Convert.ToDouble(textBoxPnDonGia.Text);
            hdct.GhiChu = richTextBoxPnGC.Text;

            _service.InsertSpVaoHD(hdct);

            pictureBox1.Visible = false;
            textBoxPnSl.Text = "";
            richTextBoxPnGC.Text = "";
            textBoxPnDonGia.Text = rowSpctSelected.Cells["Gia"].Value.ToString();
            panel1.Visible = false;

            //Load lại datagridview 2
            TinhVaAddCotThanhTien();

            //Update Tổng tiền của Hóa đơn
            UpdateTongTienHD();

            //Load lại Hóa đơn
            dataGridView1.DataSource = _service.GetAllHD();

            //Load lại textbox Tổng tiền của Hóa đơn
            textBoxTongTien.Text = TinhTongTien().ToString();
        }


        //Sửa Sản phẩm trong hóa đơn
        private void buttonSuaSP_Click(object sender, EventArgs e)
        {
            //Không cho phép sửa sản phẩm hóa đơn đã thanh toán
            if (textBoxTrangThai.Text == "Đã thanh toán")
            {
                MessageBox.Show("Vui lòng không sửa sản phẩm của hóa đơn đã thanh toán!!",
                    "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return;
            }

            if (dGV2RowSelected == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm trong hóa đơn muốn sửa!!",
                    "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return;
            }

            if (textBoxSL.Text == "" || textBoxDonGia.Text == "" || richTextBoxGhiChu.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin trước khi sửa!!",
                    "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return;
            }

            DialogResult dlrs = MessageBox.Show("Bạn có chắc muốn sửa sản phẩm này trong Hóa Đơn " +
                textBoxMaHD.Text + " không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlrs == DialogResult.Cancel)
            {
                return;
            }

            //Update hóa đơn chi tiết
            Hoadonchitiet hdct = new Hoadonchitiet();
            hdct.MaHoaDonChiTiet = textBoxMaHdct.Text;
            hdct.MaHoaDon = textBoxMaHD.Text;
            hdct.MaSanPhamChiTiet = textBoxMaSpct.Text;
            hdct.SoLuong = Convert.ToInt32(textBoxSL.Text);
            hdct.DonGia = Convert.ToDouble(textBoxDonGia.Text);
            hdct.GhiChu = richTextBoxGhiChu.Text;
            _service.UpdateHdct(hdct);

            MessageBox.Show("Sửa thành công!!", "Thông báo", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information);

            dataGridView2.DataSource = _service.GetSPTrongHD(textBoxMaHD.Text);
            TinhVaAddCotThanhTien();
            UpdateTongTienHD();
            textBoxTongTien.Text = TinhTongTien().ToString();
        }


        //Xóa Sản phẩm trong Hóa đơn
        private void buttonXoaSP_Click(object sender, EventArgs e)
        {
            //Không cho phép xóa sản phẩm hóa đơn đã thanh toán
            if (textBoxTrangThai.Text == "Đã thanh toán")
            {
                MessageBox.Show("Vui lòng không xóa sản phẩm trong hóa đơn đã thanh toán!!",
                    "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return;
            }

            if (dGV2RowSelected == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm trong hóa đơn muốn xóa!!",
                    "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return;
            }

            DialogResult dlrs = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này ra khỏi Hóa Đơn " +
                textBoxMaHD.Text + " không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlrs == DialogResult.Cancel)
            {
                return;
            }

            _service.XoaHdct(textBoxMaHdct.Text);

            MessageBox.Show("Xóa thành công!!", "Thông báo", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information);

            dataGridView2.DataSource = _service.GetSPTrongHD(textBoxMaHD.Text);
            TinhVaAddCotThanhTien();
            UpdateTongTienHD();
            textBoxTongTien.Text = TinhTongTien().ToString();

            dGV2RowSelected = null;
            textBoxMaSp.Text = "";
            textBoxMaSpct.Text = "";
            textBoxSL.Text = "";
            textBoxDonGia.Text = "";
            richTextBoxGhiChu.Text = "";
        }


        //Tìm kiếm sản phẩm
        private void buttonTKSP_Click(object sender, EventArgs e)
        {
            rowSpctSelected = null;

            if (textBoxTKSP.Text == "")
            {
                dataGridView3.DataSource = _service.GetAllSpct();
                return;
            }

            dataGridView3.DataSource = _service.GetSpctByMaspSpctTenSp(textBoxTKSP.Text);
        }


        //Chức năng thanh toán hóa đơn
        private void buttonThanhToan_Click(object sender, EventArgs e)
        {
            if (textBoxMaHD.Text == "")
            {
                MessageBox.Show("Vui lòng chọn hóa đơn muốn thanh toán!!",
                    "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return;
            }

            //Check xem hóa đơn đã đc thanh toán chưa
            if (textBoxTrangThai.Text == "Đã thanh toán")
            {
                MessageBox.Show("Hóa đơn này đã được thanh toán!!", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return;
            }

            //Check số lượng sản phẩm trong hóa đơn có vượt quá Tổng số spct trong kho không
            List<string> lstMaSpctTrongHd = new List<string>();
            //Xử lý ngoại lệ không có sản phẩm nào trong hóa đơn và ngoại lệ khác
            List<TbJoinHdctSpct> lstSpTrongHd;
            try
            {
                lstSpTrongHd = _service.GetSPTrongHD(textBoxMaHD.Text);
                if (lstSpTrongHd.Count == 0)
                {
                    MessageBox.Show("Chưa thêm sản phẩm nào vào hóa đơn!!", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    textBoxTongTien.Text = "0";
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi không xác định!! Vui lòng thử lại\nChi tiết lỗi: {ex}", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return;
            }

            for (int i = 0; i < lstSpTrongHd.Count; i++)
            {
                if (i == 0)
                {
                    lstMaSpctTrongHd.Add(lstSpTrongHd[i].MaSanPhamChiTiet);
                }
                else if (i != 0)
                {
                    for (int a = 0; a < lstMaSpctTrongHd.Count; a++)
                    {
                        bool daGiong = false;
                        if (lstSpTrongHd[i].MaHoaDonCT == lstMaSpctTrongHd[a])
                        {
                            daGiong = true;
                            break;
                        }
                    }

                    lstMaSpctTrongHd.Add(lstSpTrongHd[i].MaSanPhamChiTiet);
                }
            }

            for (int b = 0; b < lstMaSpctTrongHd.Count; b++)
            {
                int sl = 0;
                var lst = lstSpTrongHd.Where(sp => sp.MaSanPhamChiTiet == lstMaSpctTrongHd[b]).ToList();

                for (int c = 0; c < lst.Count; c++)
                {
                    sl = sl + lst[c].SoLuong;
                }

                int allSlSpct = Convert.ToInt32(_service.GetSpctByMaSpct(lstMaSpctTrongHd[b]).SoLuong);

                if (sl > allSlSpct)
                {
                    MessageBox.Show("Số lượng sản phẩm trong hóa đơn vượt quá số lượng sản phẩm trong kho!!"
                        , "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    return;
                }
            }

            //Xác nhận
            DialogResult dlrs = MessageBox.Show("Bạn có chắc muốn thanh toán Hóa Đơn " +
                textBoxMaHD.Text + " không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlrs == DialogResult.Cancel)
            {
                return;
            }

            //Trừ số lượng sản phẩm và thay đổi trạng thái hóa đơn
            for (int d = 0; d < lstSpTrongHd.Count; d++)
            {
                Sanphamchitiet spct = _service.GetSpctByMaSpct(lstSpTrongHd[d].MaSanPhamChiTiet);
                spct.SoLuong = spct.SoLuong - lstSpTrongHd[d].SoLuong;

                Sanpham sp = _service.GetSpByMaSp(spct.MaSanPham);
                sp.SoLuong = sp.SoLuong - lstSpTrongHd[d].SoLuong;

                _service.UpdateSpctSp(spct, sp);
            }

            Hoadon hd = new Hoadon();
            hd.MaHoaDon = textBoxMaHD.Text;
            hd.SoDienThoai = textBoxSDT.Text;
            hd.MaNhanVien = textBoxMaNV.Text;
            hd.MaKhuyenMai = textBoxMaKM.Text;
            hd.NgayLap = Convert.ToDateTime(textBoxNgayLap.Text);
            hd.TrangThai = "Đã thanh toán";
            hd.TongTien = Convert.ToDouble(textBoxTongTien.Text);
            hd.NgayThanhToan = DateTime.Now;

            _service.UpdateHD(hd);

            textBoxTrangThai.Text = "Đã thanh toán";

            MessageBox.Show("Đã thanh toán thành công!!", "Thông báo", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information);

            dataGridView1.DataSource = _service.GetAllHD();
            dataGridView3.DataSource = _service.GetAllSpct();
        }


        //Chức năng In hóa đơn
        private void buttonInHd_Click_1(object sender, EventArgs e)
        {
            if (textBoxMaHD.Text == "")
            {
                MessageBox.Show("Vui lòng chọn hóa đơn trước khi in!!", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return;
            }

            //Không cho phép in hóa đơn chưa thanh toán
            if (textBoxTrangThai.Text == "Chưa thanh toán")
            {
                MessageBox.Show("Vui lòng thanh toán hóa đơn trước khi in!!",
                    "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return;
            }

            DialogResult dlrs = MessageBox.Show("Bạn có chắc muốn in hóa đơn " +
                textBoxMaHD.Text + " không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlrs == DialogResult.Cancel)
            {
                return;
            }

            //Định dạng văn bản cho hóa đơn
            panel3.Size = new Size(700, 100);
            panel3.Location = new Point(this.Size.Width / 2 - panel3.Size.Width / 2, 0);

            labelBanXemThu.Location = new Point(10, 5);
            labelBanXemThu.Font = new Font("Arial", 16, FontStyle.Bold);
            labelBanXemThu.Text = "Bản Xem thử";

            labelTenCT.Location = new Point(10, 10);
            labelTenCT.Font = new Font("Arial", 9, FontStyle.Bold);
            labelTenCT.Text = "Cửa hàng bán quần áo thể thao";

            panel4.Location = new Point(10, labelBanXemThu.Size.Height + 10);
            panel4.Size = new Size(panel3.Size.Width - 20, labelLine4.Location.Y);

            labelHoaDon.Location = new Point(panel4.Size.Width / 2 - labelHoaDon.Size.Width / 2, labelTenCT.Size.Height + 30);
            labelHoaDon.Font = new Font("Arial", 14, FontStyle.Bold);
            labelHoaDon.Text = "Hóa Đơn";

            labelLine1.Location = new Point(10, labelHoaDon.Size.Height + labelTenCT.Size.Height + 50);
            labelLine1.Font = new Font("Arial", 9, FontStyle.Regular);
            var kh = _service.GetKHBySDT(textBoxSDT.Text);
            labelLine1.Text = "Họ và tên khách hàng: " + kh.HoVaTen +
                "\nSố điện thoại: " + kh.SoDienThoai + "\nĐịa chỉ: " + kh.DiaChi;

            dataGridView4.Location = new Point(10, labelHoaDon.Size.Height + labelTenCT.Size.Height + labelLine1.Size.Height + 70);
            dataGridView4.Columns.Add("Tên sản phẩm", "Tên sản phẩm");
            dataGridView4.Columns.Add("Số lượng", "Số lượng");
            dataGridView4.Columns.Add("Đơn giá", "Đơn giá");
            dataGridView4.Columns.Add("Thành tiền", "Thành tiền");
            dataGridView4.RowCount = dataGridView2.RowCount;
            //Add giá trị cho datagridview 4
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                if (i >= 0)
                {
                    dataGridView4.Rows[i].Cells["Tên sản phẩm"].Value = dataGridView2.Rows[i].Cells["TenSanPham"].Value;
                    dataGridView4.Rows[i].Cells["Số Lượng"].Value = dataGridView2.Rows[i].Cells["SoLuong"].Value;
                    dataGridView4.Rows[i].Cells["Đơn giá"].Value = Convert.ToDouble(dataGridView2.Rows[i].Cells["ThanhTien"].Value) / Convert.ToInt32(dataGridView2.Rows[i].Cells["SoLuong"].Value);
                    dataGridView4.Rows[i].Cells["Thành tiền"].Value = dataGridView2.Rows[i].Cells["ThanhTien"].Value;
                }
            }
            dataGridView4.Size = new Size(panel4.Size.Width - 20, (dataGridView4.RowCount * dataGridView4.Rows[0].Height) + dataGridView4.ColumnHeadersHeight + 20);

            labelLine2.Location = new Point(10, labelHoaDon.Size.Height + labelTenCT.Size.Height + labelLine1.Size.Height + dataGridView4.Size.Height + 90);
            labelLine2.Font = new Font("Arial", 9, FontStyle.Regular);

            int indexR = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["MaHoaDon"].Value.ToString() == textBoxMaHD.Text)
                {
                    indexR = row.Index;
                    break;
                }
            }

            var dateTT = Convert.ToDateTime(dataGridView1.Rows[indexR].Cells["NgayThanhToan"].Value);

            if (_service.GetKMByMaKM(textBoxMaKM.Text).TrangThai == "Còn" && dateTT.Year < _service.GetKMByMaKM(textBoxMaKM.Text).NgayHetHan.Year ||
                dateTT.Year == _service.GetKMByMaKM(textBoxMaKM.Text).NgayHetHan.Year && dateTT.Month < _service.GetKMByMaKM(textBoxMaKM.Text).NgayHetHan.Month && _service.GetKMByMaKM(textBoxMaKM.Text).TrangThai == "Còn" ||
                    dateTT.Year == _service.GetKMByMaKM(textBoxMaKM.Text).NgayHetHan.Year && dateTT.Month == _service.GetKMByMaKM(textBoxMaKM.Text).NgayHetHan.Month && dateTT.Day < _service.GetKMByMaKM(textBoxMaKM.Text).NgayHetHan.Day && _service.GetKMByMaKM(textBoxMaKM.Text).TrangThai == "Còn")
            {
                labelLine2.Text = "Khuyến mãi: -" + _service.GetKMByMaKM(textBoxMaKM.Text).MucGiam + " đồng\n" + "Tổng tiền: " + textBoxTongTien.Text + " đồng";
            }
            else
            {
                labelLine2.Text = "Tổng tiền: " + textBoxTongTien.Text + " đồng";
            }

            labelLine3.Location = new Point(10, labelHoaDon.Size.Height + labelTenCT.Size.Height + labelLine1.Size.Height + dataGridView4.Size.Height + labelLine2.Size.Height + 100);
            labelLine3.Font = new Font("Arial", 9, FontStyle.Bold);
            labelLine3.Text = "Chữ ký khách hàng\n(Ký và Ghi đầy đủ rõ họ, tên)";

            var dateNow = DateTime.Now;
            labelLine4.Text = $"Ngày {dateNow.Day} Tháng {dateNow.Month} Năm {dateNow.Year}" + "\n" +
                "Chữ ký chủ cửa hàng hoặc nhân viên\n(Ký và Ghi đầy đủ rõ họ, tên)";
            labelLine4.Location = new Point(panel4.Size.Width - 40 - labelLine4.Size.Width, labelHoaDon.Size.Height + labelTenCT.Size.Height + labelLine1.Size.Height + dataGridView4.Size.Height + labelLine2.Size.Height + 100);
            labelLine4.Font = new Font("Arial", 9, FontStyle.Bold);

            panel4.Size = new Size(panel3.Size.Width - 40, labelHoaDon.Size.Height + labelTenCT.Size.Height + labelLine1.Size.Height + dataGridView4.Size.Height + labelLine3.Size.Height + labelLine4.Size.Height + 200);
            dataGridView4.Size = new Size(panel4.Size.Width - 20, (dataGridView4.RowCount * dataGridView4.Rows[0].Height) + dataGridView4.ColumnHeadersHeight + 20);

            buttonHuyIn.Location = new Point(panel3.Size.Width - 30 - buttonHuyIn.Width, 5);
            buttonLuu.Location = new Point(panel3.Size.Width - 30 - buttonHuyIn.Width - buttonHuyIn.Size.Width, 5);

            panel3.Size = new Size(panel3.Size.Width, panel4.Size.Height + buttonLuu.Size.Height + labelBanXemThu.Size.Height + 50);

            labelMaHoaDon.Font = new Font("Arial", 9, FontStyle.Bold);
            labelMaHoaDon.Text = "Mã hóa đơn: " + textBoxMaHD.Text;
            labelMaHoaDon.Location = new Point(panel4.Size.Width - labelMaHoaDon.Size.Width - 10, 10);

            panel3.Location = new Point(this.Size.Width / 2 - panel3.Size.Width / 2, this.Size.Height / 2 - panel3.Size.Height / 2);

            //Tạo ảnh nền
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = MakeBackGroundImg();
            pictureBox1.BringToFront();
            panel3.BringToFront();

            pictureBox1.Visible = true;
            panel3.Visible = true;
            dataGridView4.ClearSelection();
            panel3.Focus();
        }

        //Thoát in hóa đơn
        private void buttonHuyIn_Click(object sender, EventArgs e)
        {
            dataGridView4.Columns.Clear();
            pictureBox1.Visible = false;
            panel3.Visible = false;
        }

        //Lưu hóa đơn dưới dạng PDF
        private void buttonLuu_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            saveFileDialog.Title = "Save as PDF";
            saveFileDialog.FileName = "noname.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Chụp màn hình form hiện tại
                Bitmap screenshot = new Bitmap(panel4.Width, panel4.Height);
                panel4.DrawToBitmap(screenshot, new Rectangle(0, 0, panel4.Width, panel4.Height));

                // Tạo tài liệu PDF
                PdfDocument pdfDoc = new PdfDocument();
                PdfPage pdfPage = pdfDoc.AddPage();
                XGraphics gfx = XGraphics.FromPdfPage(pdfPage);

                // Chuyển đổi ảnh chụp màn hình thành đối tượng XImage
                MemoryStream ms = new MemoryStream();
                screenshot.Save(ms, ImageFormat.Png);
                XImage image = XImage.FromStream(ms);

                // Vẽ ảnh chụp màn hình lên trang PDF
                gfx.DrawImage(image, 0, 0);

                // Lưu tài liệu PDF
                pdfDoc.Save(saveFileDialog.FileName);
                pdfDoc.Close();
            }
        }


        //Add cột stt cho datagridview
        public void AddSTTCloumn(DataGridView dgv)
        {
            if (dgv.Columns.Contains("STT"))
            {
                dgv.Columns.Remove("STT");
            }

            DataGridViewTextBoxColumn sttColumn = new DataGridViewTextBoxColumn();
            sttColumn.Name = "STT";
            sttColumn.HeaderText = "STT";
            dgv.Columns.Insert(0, sttColumn);

            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                dgv.Rows[i].Cells["STT"].Value = (i + 1).ToString();
            }
        }

        private void dataGridView2_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            AddSTTCloumn(dataGridView2);
        }

        private void dataGridView4_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            AddSTTCloumn(dataGridView4);
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            AddSTTCloumn(dataGridView1);
        }

        private void dataGridView3_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            AddSTTCloumn(dataGridView3);
        }

        //Thêm hóa đơn
        private void buttonThemHD_Click(object sender, EventArgs e)
        {
            if (textBoxMaHD.Text == "" || textBoxSDT.Text == "" || textBoxMaNV.Text == "" || textBoxMaKM.Text == "" || textBoxNgayLap.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin trước khi thêm!!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn thêm hóa đơn này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                return;
            }

            Hoadon hd = new Hoadon();
            hd.MaHoaDon = textBoxMaHD.Text;
            hd.SoDienThoai = textBoxSDT.Text;
            hd.MaNhanVien = textBoxMaNV.Text;
            hd.MaKhuyenMai = textBoxMaKM.Text;
            hd.NgayLap = DateTime.Now;
            hd.TrangThai = "Chưa thanh toán";
            hd.TongTien = 0;
            hd.NgayThanhToan = null;

            try
            {
                if (_service.GetHDByID(textBoxMaHD.Text) != null)
                {
                    MessageBox.Show("Mã hóa đơn đã tồn tại!! Vui lòng kiểm tra lại!!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    return;
                }
                _service.InsertHD(hd);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không xác định!! Vui lòng thử lại!!\nChi tiết: " + ex, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show("Thêm thành công!!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            dataGridView1.DataSource = _service.GetAllHD();
            dataGridView3.DataSource = _service.GetAllSpct();
            dataGridView2.Columns.Clear();
            textBoxMaSp.Text = "";
            textBoxMaSpct.Text = "";
            textBoxDonGia.Text = "";
            textBoxSL.Text = "";
            richTextBoxGhiChu.Text = "";
        }

        //Sửa hóa đơn
        private void buttonSuaHD_Click(object sender, EventArgs e)
        {
            if (textBoxMaHD.Text == "" || textBoxSDT.Text == "" || textBoxMaNV.Text == "" || textBoxMaKM.Text == "" || textBoxNgayLap.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin trước khi sửa!!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return;
            }

            if (textBoxTrangThai.Text == "Đã thanh toán")
            {
                MessageBox.Show("Vui lòng không sửa hóa đơn đã thanh toán", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn sửa hóa đơn này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                return;
            }

            Hoadon hd = new Hoadon();
            hd.MaHoaDon = textBoxMaHD.Text;
            hd.SoDienThoai = textBoxSDT.Text;
            hd.MaNhanVien = textBoxMaNV.Text;
            hd.MaKhuyenMai = textBoxMaKM.Text;
            hd.NgayLap = Convert.ToDateTime(textBoxNgayLap.Text);
            hd.TrangThai = textBoxTrangThai.Text;
            hd.TongTien = Convert.ToDouble(textBoxTongTien.Text);
            if (textBoxNTT.Text == "")
            {
                hd.NgayThanhToan = null;
            }

            try
            {
                if (_service.GetHDByID(textBoxMaHD.Text) == null)
                {
                    MessageBox.Show("Mã hóa đơn không tồn tại!! Vui lòng kiểm tra lại!!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    return;
                }
                _service.UpdateHD(hd);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không xác định!! Vui lòng thử lại!!\nChi tiết: " + ex, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show("Sửa thành công!!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            dataGridView1.DataSource = _service.GetAllHD();
            TinhTongTien();
            dataGridView3.DataSource = _service.GetAllSpct();
        }

        //Xóa hóa đơn
        private void buttonXoaHD_Click(object sender, EventArgs e)
        {
            if (textBoxMaHD.Text == "")
            {
                MessageBox.Show("Vui lòng chọn hóa đơn trước khi xóa!!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return;
            }

            if (textBoxTrangThai.Text == "Đã thanh toán")
            {
                MessageBox.Show("Vui lòng không xóa hóa đơn đã thanh toán", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa hóa đơn này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                return;
            }

            List<TbJoinHdctSpct> lstSPTroHD;
            try
            {
                if (_service.GetHDByID(textBoxMaHD.Text) == null)
                {
                    MessageBox.Show("Mã hóa đơn không tồn tại!! Vui lòng kiểm tra lại!!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    return;
                }

                lstSPTroHD = _service.GetSPTrongHD(textBoxMaHD.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không xác định!! Vui lòng thử lại!!\nChi tiết: " + ex, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return;
            }

            if (lstSPTroHD.Count == 0)
            {
                try
                {
                    _service.DeleteHD(textBoxMaHD.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi không xác định!! Vui lòng thử lại!!\nChi tiết: " + ex, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    return;
                }
            }
            else if (lstSPTroHD.Count != 0)
            {
                for (int i = 0; i < lstSPTroHD.Count; i++)
                {
                    try
                    {
                        _service.XoaHdct(lstSPTroHD[i].MaHoaDonCT);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi không xác định!! Vui lòng thử lại!!\nChi tiết: " + ex, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        return;
                    }
                }

                try
                {
                    _service.DeleteHD(textBoxMaHD.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi không xác định!! Vui lòng thử lại!!\nChi tiết: " + ex, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    return;
                }
            }

            MessageBox.Show("Xóa hóa đơn thành công!!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            dataGridView1.DataSource = _service.GetAllHD();
            dataGridView3.DataSource = _service.GetAllSpct();
            dataGridView2.Columns.Clear();

            textBoxMaHD.Text = "";
            textBoxSDT.Text = "";
            textBoxMaNV.Text = "";
            textBoxMaKM.Text = "";
            textBoxNgayLap.Text = "";
            textBoxTrangThai.Text = "";
            textBoxTongTien.Text = "";
            textBoxNTT.Text = "";

            textBoxMaSp.Text = "";
            textBoxMaSpct.Text = "";
            textBoxDonGia.Text = "";
            textBoxSL.Text = "";
            richTextBoxGhiChu.Text = "";
        }
    }
}