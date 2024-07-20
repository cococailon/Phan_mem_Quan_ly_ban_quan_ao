using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Chatlieu
    {
        public Chatlieu()
        {
            Sanphamchitiets = new HashSet<Sanphamchitiet>();
        }

        public string MaChatLieu { get; set; } = null!;
        public string Ten { get; set; } = null!;
        public string MoTa { get; set; } = null!;
        public string TrangThai { get; set; } = null!;

        public virtual ICollection<Sanphamchitiet> Sanphamchitiets { get; set; }
    }
}
