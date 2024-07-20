using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Hoadonchitiet
    {
        public string MaHoaDonChiTiet { get; set; } = null!;
        public string MaHoaDon { get; set; } = null!;
        public string MaSanPhamChiTiet { get; set; } = null!;
        public int SoLuong { get; set; }
        public double DonGia { get; set; }
        public string GhiChu { get; set; } = null!;

        public virtual Hoadon MaHoaDonNavigation { get; set; } = null!;
        public virtual Sanphamchitiet MaSanPhamChiTietNavigation { get; set; } = null!;
    }
}
