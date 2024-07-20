using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Service
{
    public class KhachHangService
    {
        KhachHangrepos _khrepos = new KhachHangrepos();

        public KhachHangService()
        {
        }

        public KhachHangService(KhachHangrepos khrepos)
        {
            _khrepos = khrepos;
        }
        public List<Khachhang> GetALL()
        {
            return _khrepos.GetALL().ToList();

        }
        public List<Khachhang> GetBySDT(string SDT)
        {
            return _khrepos.GetBySDT(SDT).ToList();
        }
        public string Createkh(Khachhang kh)
        {
            try
            {
                _khrepos.Create(kh);
                return "thêm thành công";
            }
            catch
            {
                return "Thêm thất bại";

            }
        }
        public bool Updatekh(string SDT, string HoTen, string GioiTinh, string DiaChi, DateTime NgaySinh, string Email)
        {
            var khachHang = new Khachhang
            {
                SoDienThoai = SDT,
                HoVaTen = HoTen,
                GioiTinh = GioiTinh,
                DiaChi = DiaChi,
                NgaySinh = NgaySinh,
                Email = Email
            };
            return _khrepos.Update(khachHang);
        }
        public bool Removekh(string SDT)
        {
            return _khrepos.Remove(SDT);
        }
        public bool Luu(Khachhang khachhang)
        {
            return true;
        }
    }
}
