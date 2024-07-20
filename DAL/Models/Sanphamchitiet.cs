using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Sanphamchitiet
    {
        public Sanphamchitiet()
        {
            Hoadonchitiets = new HashSet<Hoadonchitiet>();
        }

        public string MaSanPhamChiTiet { get; set; } = null!;
        public string TenSanPham { get; set; } = null!;
        public double Gia { get; set; }
        public int SoLuong { get; set; }
        public string MaKichThuoc { get; set; } = null!;
        public string MaChatLieu { get; set; } = null!;
        public string MaMauSac { get; set; } = null!;
        public string MaSale { get; set; } = null!;
        public string MaSanPham { get; set; } = null!;
        public string TrangThai { get; set; } = null!;

        public virtual Chatlieu MaChatLieuNavigation { get; set; } = null!;
        public virtual Kichthuoc MaKichThuocNavigation { get; set; } = null!;
        public virtual Mausac MaMauSacNavigation { get; set; } = null!;
        public virtual Salesanpham MaSaleNavigation { get; set; } = null!;
        public virtual Sanpham MaSanPhamNavigation { get; set; } = null!;
        public virtual ICollection<Hoadonchitiet> Hoadonchitiets { get; set; }
    }
}
