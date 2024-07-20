using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IService
{
    public interface IKhachHangService
    {
        public List<Khachhang> GetALL();
        public List<Khachhang> GetBySDT(string SDT);
        public bool Create(Khachhang khachhang);
        public bool Update(Khachhang khachhang);
        public bool Remove(string SDT);
        public bool Luu(Khachhang khachhang);
    }
}
