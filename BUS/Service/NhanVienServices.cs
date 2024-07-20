using DAL.Models;
using DAL.IRepositories;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUS.IService;

namespace BUS.Service
{
    public class NhanVienServices
    {
        static INhanVienrepos repos;
        static NhanVienServices()
        {
            repos = new NhanVienrepos();
        }
        public static List<Nhanvien> GetAll()
        {
            return repos.GetAll();
        }
        public static List<Nhanvien> GetByID(String Find)
        {
            return repos.GetByID(Find);
        }
        public static Nhanvien Insert(Nhanvien nhanvien)
        {
            return repos.Insert(nhanvien);
        }
        public static void Update(Nhanvien nhanvien)
        {
            repos.Update(nhanvien);
        }
        public static void Delete(Nhanvien nhanvien)
        {
            repos.Delete(nhanvien);
        }
        public static List<Nhanvien> GetLstObjectByCV(string cv)
        {
            return repos.GetLstObjectByCV(cv);
        }
        public  Nhanvien GetNvForLogin(string username, string passworld)
        {
            return repos.GetNvForLogin(username, passworld);
        }
    }
}
