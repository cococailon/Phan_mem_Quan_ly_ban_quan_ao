using DAL.Models;
using DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class KhuyenMaiRepos : IKhuyenMairepos
    {
        private DUAN1_QL_BANQUANAOContext _dbContext;

        public KhuyenMaiRepos(DUAN1_QL_BANQUANAOContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Khuyenmai> GetAll()
        {
            using (_dbContext = new DUAN1_QL_BANQUANAOContext())
            {
                return _dbContext.Khuyenmais.ToList();
            }
        }

        public void Insert(Khuyenmai khuyenmai)
        {
            using (_dbContext = new DUAN1_QL_BANQUANAOContext())
            {
                _dbContext.Khuyenmais.Add(khuyenmai);
                _dbContext.SaveChanges();
            }
        }

        public void Update(Khuyenmai khuyenmai)
        {
            using (_dbContext = new DUAN1_QL_BANQUANAOContext())
            {
                _dbContext.Khuyenmais.Update(khuyenmai);
                _dbContext.SaveChanges();
            }
        }

        public void Delete(Khuyenmai khuyenmai)
        {
            using (_dbContext = new DUAN1_QL_BANQUANAOContext())
            {
                _dbContext.Khuyenmais.Attach(khuyenmai);
                _dbContext.Khuyenmais.Remove(khuyenmai);
                _dbContext.SaveChanges();
            }
        }

        public Khuyenmai GetOject(string MaKM)
        {
            using (_dbContext = new DUAN1_QL_BANQUANAOContext())
            {
                var OjectFound = _dbContext.Khuyenmais.Find(MaKM);
                return OjectFound;
            }
        }

        public List<Khuyenmai> GetLstObjectByKKM(string KieuKM)
        {
            using (_dbContext = new DUAN1_QL_BANQUANAOContext())
            {
                List<Khuyenmai> lstKMFound = _dbContext.Khuyenmais.Where(km => km.KieuKhuyenMai == "" + KieuKM).ToList();
                return lstKMFound;
            }
        }

        public List<Khuyenmai> GetLstOjectBySL(int tu, int den)
        {
            using (_dbContext = new DUAN1_QL_BANQUANAOContext())
            {
                List<Khuyenmai> lstKMFound = _dbContext.Khuyenmais.Where(km => km.SoLuong >= tu && km.SoLuong <= den).ToList();
                return lstKMFound;
            }
        }
    }
}
