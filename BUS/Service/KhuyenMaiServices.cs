using BUS.IService;
using DAL.Models;
using DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Service
{
    public class KhuyenMaiServices : IKhuyenMaiServices
    {
        private IKhuyenMairepos _repository;

        public KhuyenMaiServices(IKhuyenMairepos repository)
        {
            _repository = repository;
        }

        public List<Khuyenmai> GetAll()
        {
            return _repository.GetAll();
        }

        public void Insert(Khuyenmai khuyenmai)
        {
            _repository.Insert(khuyenmai);
        }

        public void Update(Khuyenmai khuyenmai)
        {
            _repository.Update(khuyenmai);
        }

        public void Delete(Khuyenmai khuyenmai)
        {
            _repository.Delete(khuyenmai);
        }

        public Khuyenmai GetOject(string MaKM)
        {
            return _repository.GetOject(MaKM);
        }

        public List<Khuyenmai> GetLstObjectByKKM(string KieuKM)
        {
            return _repository.GetLstObjectByKKM(KieuKM);
        }

        public List<Khuyenmai> GetLstOjectBySL(int tu, int den)
        {
            return _repository.GetLstOjectBySL(tu, den);
        }
    }
}
