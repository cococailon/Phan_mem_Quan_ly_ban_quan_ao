using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IService
{
    public interface INhanVienServices
    {
        List<Nhanvien> GetAll();
        void Delete(Nhanvien nhanvien);
        Nhanvien Insert(Nhanvien nhanvien);
        void Update(Nhanvien nhanvien);
        List<Nhanvien> GetByID(String Found);
        List<Nhanvien> GetLstObjectByCV(string cv);
        Nhanvien GetNvForLogin(String username, string passworld);
    }
}
