using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepositories
{
    public interface INhanVienrepos
    {
        List<Nhanvien> GetAll();
        void Delete(Nhanvien nhanvien);
        Nhanvien Insert(Nhanvien nhanvien);
        void Update(Nhanvien nhanvien);
        List<Nhanvien> GetByID(String Found);
        List<Nhanvien> GetLstObjectByCV(String cv);
       public Nhanvien GetNvForLogin(String username, string passworld);
    }
}
