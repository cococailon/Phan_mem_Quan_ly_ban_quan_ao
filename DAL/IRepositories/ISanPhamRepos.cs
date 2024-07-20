using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepositories
{
    public interface ISanPhamRepos
    {
        public List<Sanpham> GetSanphams();
        public bool Add(Sanpham sp);
        public List<Thuonghieu> GetMaThuongHieu();
        public bool DeleteSanPham(Sanpham sanpham);
    }
}
