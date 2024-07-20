using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Thuonghieu
    {
        public Thuonghieu()
        {
            Sanphams = new HashSet<Sanpham>();
        }

        public string MaThuongHieu { get; set; } = null!;
        public string TenThuongHieu { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string SoDienThoai { get; set; } = null!;

        public virtual ICollection<Sanpham> Sanphams { get; set; }
    }
}
