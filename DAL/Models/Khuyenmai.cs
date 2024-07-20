using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Khuyenmai
    {
        public Khuyenmai()
        {
            Hoadons = new HashSet<Hoadon>();
        }

        public string MaKhuyenMai { get; set; } = null!;
        public DateTime NgayTao { get; set; }
        public DateTime NgayHetHan { get; set; }
        public string KieuKhuyenMai { get; set; } = null!;
        public string MucGiam { get; set; } = null!;
        public string TrangThai { get; set; } = null!;
        public int SoLuong { get; set; }
        public string GhiChu { get; set; } = null!;

        public virtual ICollection<Hoadon> Hoadons { get; set; }
    }
}
