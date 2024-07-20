using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IService
{
    public interface ISPCTService
    {
        public List<Sanphamchitiet> GetCTSanphams();
        public string Add(Sanphamchitiet spct);

        public string Delete(Sanphamchitiet CTSanPham);
    }
}
