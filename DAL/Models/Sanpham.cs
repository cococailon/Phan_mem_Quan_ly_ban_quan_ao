using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Sanpham
    {
        public Sanpham()
        {
            Sanphamchitiets = new HashSet<Sanphamchitiet>();
        }

        public string MaSanPham { get; set; } = null!;
        public string TenSanPham { get; set; } = null!;
        public double GiaBan { get; set; }
        public int SoLuong { get; set; }
        public string MaThuongHieu { get; set; } = null!;
        public string TrangThai { get; set; } = null!;

        public virtual Thuonghieu MaThuongHieuNavigation { get; set; } = null!;
        public virtual ICollection<Sanphamchitiet> Sanphamchitiets { get; set; }
    }
}
