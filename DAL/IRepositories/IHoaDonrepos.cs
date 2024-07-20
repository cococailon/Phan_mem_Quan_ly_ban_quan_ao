using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
using DAL.Repositories;

namespace DAL.IRepositories
{
    public interface IHoaDonrepos
    {
        List<Hoadon> GetAllHD();
        List<TbJoinHdctSpct> GetSPTrongHD(string MaHD);
        List<Hoadonchitiet> GetAllHdct();
        Khuyenmai GetKMByMaKM(string maKM);
        List<Sanphamchitiet> GetAllSpct();
        void InsertSpVaoHD(Hoadonchitiet hoadonchitiet);
        void UpdateHD(Hoadon hoadon);
        Sanphamchitiet GetSpctByMaSpct(string MaSpct);
        void UpdateHdct(Hoadonchitiet hoadonchitiet);
        void XoaHdct(string maHoaDonCT);
        List<Sanphamchitiet> GetSpctByMaspSpctTenSp(string tuKhoa);
        void UpdateSpctSp(Sanphamchitiet spct, Sanpham sp);
        Sanpham GetSpByMaSp(string maSpct);
        Khachhang GetKHBySDT(string SDT);
        void InsertHD(Hoadon hoadon);
        void DeleteHD(string Mahoadon);
        Hoadon GetHDByID(string MaHD);
    }
}
