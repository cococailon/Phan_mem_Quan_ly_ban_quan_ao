using DAL.Models;
using DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class NhanVienrepos : INhanVienrepos
    {
        public List<Nhanvien> GetAll()
        {
            using (DUAN1_QL_BANQUANAOContext db = new DUAN1_QL_BANQUANAOContext())
            {
                return db.Nhanviens.ToList();
            }
        }
        public Nhanvien Insert(Nhanvien nhanvien)
        {
            using (DUAN1_QL_BANQUANAOContext db = new DUAN1_QL_BANQUANAOContext())
            {
                db.Nhanviens.Add(nhanvien);
                db.SaveChanges();
                return nhanvien;
            }
        }
        public List<Nhanvien> GetByID(String Find)
        {
            using (DUAN1_QL_BANQUANAOContext db = new DUAN1_QL_BANQUANAOContext())
            {
                Find = Find.ToLower();
                List<Nhanvien> nvFound = db.Nhanviens.Where(nv => nv.MaNhanVien == Find || nv.TenNhanVien == Find).ToList();
                return nvFound;
            }
        }
        public void Update(Nhanvien nhanvien)
        {
            using (DUAN1_QL_BANQUANAOContext db = new DUAN1_QL_BANQUANAOContext())
            {
                db.Nhanviens.Attach(nhanvien);
                db.Nhanviens.Update(nhanvien);
                db.SaveChanges();
            }
        }
        public void Delete(Nhanvien nhanvien)
        {
            using (DUAN1_QL_BANQUANAOContext db = new DUAN1_QL_BANQUANAOContext())
            {
                db.Nhanviens.Remove(nhanvien);
                db.SaveChanges();
            }
        }
        public List<Nhanvien> GetLstObjectByCV(String cv)
        {
            using (DUAN1_QL_BANQUANAOContext db = new DUAN1_QL_BANQUANAOContext())
            {
                List<Nhanvien> lstFound = db.Nhanviens.Where(nv => nv.TenChucVu == cv).ToList();
                return lstFound;
            }
        }

        public Nhanvien GetNvForLogin(string username, string passworld)
        {
            using (DUAN1_QL_BANQUANAOContext db = new DUAN1_QL_BANQUANAOContext())
            {
                Nhanvien taikhoan = db.Nhanviens.FirstOrDefault(t => t.TenDangNhap == username && t.MatKhau == passworld);
                return taikhoan;
            }
        }
    }
}
