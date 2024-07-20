using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepositories
{
    public interface ISPCTRepos
    {
        public List<Sanphamchitiet> GetCTSanphams();
        public bool Add(Sanphamchitiet spct);
        public bool DeleteCTSanPham(Sanphamchitiet spct);
    }
}
