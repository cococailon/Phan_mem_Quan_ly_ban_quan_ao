using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Taikhoan
    {
        public string MaTaiKhoan { get; set; } = null!;
        public string TenDangNhap { get; set; } = null!;
        public string MatKhau { get; set; } = null!;
        public string TenChucVu { get; set; } = null!;

        public virtual Nhanvien? Nhanvien { get; set; }
    }
}
