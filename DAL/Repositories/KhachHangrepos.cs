using DAL.IRepositories;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class KhachHangrepos : IKhachHangRepos
    {
        DUAN1_QL_BANQUANAOContext _context = new DUAN1_QL_BANQUANAOContext();

        public KhachHangrepos()
        {
        }



        public List<Khachhang> GetALL()
        {
            return _context.Khachhangs.ToList();
        }

        public List<Khachhang> GetBySDT(string SDT)
        {
            return _context.Khachhangs.Where(p => p.SoDienThoai.Contains(SDT)).ToList();
        }
        public bool Create(Khachhang khachhang)
        {
            _context.Khachhangs.Add(khachhang);
            _context.SaveChanges();
            return true;
        }
        public bool Update(Khachhang khachhang)
        {
            var updatekh = _context.Khachhangs.Find(khachhang.SoDienThoai);
            updatekh.SoDienThoai = khachhang.SoDienThoai;
            updatekh.HoVaTen = khachhang.HoVaTen;
            updatekh.GioiTinh = khachhang.GioiTinh;
            updatekh.DiaChi = khachhang.DiaChi;
            updatekh.NgaySinh = khachhang.NgaySinh;
            updatekh.Email = khachhang.Email;
            _context.Khachhangs.Update(updatekh);
            _context.SaveChanges();
            return true;
        }
        public bool Remove(string SDT)
        {
            try
            {
                var deletekh = _context.Khachhangs.Find(SDT);
                _context.Khachhangs.Remove(deletekh);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Luu(Khachhang khachhang)
        {
            throw new NotImplementedException();
        }



    }
}
