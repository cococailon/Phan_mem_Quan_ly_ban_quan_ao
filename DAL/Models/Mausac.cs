using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Mausac
    {
        public Mausac()
        {
            Sanphamchitiets = new HashSet<Sanphamchitiet>();
        }

        public string MaMauSac { get; set; } = null!;
        public string Ten { get; set; } = null!;
        public string MoTa { get; set; } = null!;
        public string TrangThai { get; set; } = null!;

        public virtual ICollection<Sanphamchitiet> Sanphamchitiets { get; set; }
    }
}
