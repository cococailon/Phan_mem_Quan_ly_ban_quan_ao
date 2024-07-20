using BUS.IService;
using BUS.Service;
using DAL.Models;
using DAL.IRepositories;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Service
{
    public class HoaDonServices : IHoaDonServices
    {
        private IHoaDonrepos _repository;

        public HoaDonServices(IHoaDonrepos repository)
        {
            _repository = repository;
        }

        public List<TbJoinHdctSpct> GetSPTrongHD(string MaHD)
        {
            return _repository.GetSPTrongHD(MaHD);
        }

        public List<Hoadon> GetAllHD()
        {
            return _repository.GetAllHD();
        }

        public List<Hoadonchitiet> GetAllHdct()
        {
            return _repository.GetAllHdct();
        }

        public Khuyenmai GetKMByMaKM(string maKM)
        {
            return _repository.GetKMByMaKM(maKM);
        }

        public List<Sanphamchitiet> GetAllSpct()
        {
            return _repository.GetAllSpct();
        }

        public void InsertSpVaoHD(Hoadonchitiet hoadonchitiet)
        {
            _repository.InsertSpVaoHD(hoadonchitiet);
        }

        public void UpdateHD(Hoadon hoadon)
        {
            _repository.UpdateHD(hoadon);
        }

        public Sanphamchitiet GetSpctByMaSpct(string MaSpct)
        {
            return _repository.GetSpctByMaSpct(MaSpct);
        }

        public void UpdateHdct(Hoadonchitiet hoadonchitiet)
        {
            _repository.UpdateHdct(hoadonchitiet);
        }

        public void XoaHdct(string maHoaDonCT)
        {
            _repository.XoaHdct(maHoaDonCT);
        }

        public List<Sanphamchitiet> GetSpctByMaspSpctTenSp(string tuKhoa)
        {
            return _repository.GetSpctByMaspSpctTenSp(tuKhoa);
        }

        public Sanpham GetSpByMaSp(string maSp)
        {
            return _repository.GetSpByMaSp(maSp);
        }

        public void UpdateSpctSp(Sanphamchitiet spct, Sanpham sp)
        {
            _repository.UpdateSpctSp(spct, sp);
        }

        public Khachhang GetKHBySDT(string SDT)
        {
            return _repository.GetKHBySDT(SDT);
        }

        public void InsertHD(Hoadon hoadon)
        {
            _repository.InsertHD(hoadon);
        }

        public void DeleteHD(string Mahoadon)
        {
            _repository.DeleteHD(Mahoadon);
        }

        public Hoadon GetHDByID(string MaHD)
        {
            return _repository.GetHDByID(MaHD);
        }
    }
}
