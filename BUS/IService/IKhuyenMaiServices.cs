using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IService
{
    public interface IKhuyenMaiServices
    {
        List<Khuyenmai> GetAll();
        void Insert(Khuyenmai khuyenmai);
        void Update(Khuyenmai khuyenmai);
        void Delete(Khuyenmai khuyenmai);
        Khuyenmai GetOject(string MaKM);
        List<Khuyenmai> GetLstObjectByKKM(string KieuKM);
        List<Khuyenmai> GetLstOjectBySL(int tu, int den);
    }
}
