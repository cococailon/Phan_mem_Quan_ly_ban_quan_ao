using DAL.IRepositories;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class SPCTRepos : ISPCTRepos
    {

        DUAN1_QL_BANQUANAOContext _context;

        public SPCTRepos()
        {
            _context = new DUAN1_QL_BANQUANAOContext();
        }

        public List<Sanpham> GetMaSP()
        {
            return _context.Sanphams.ToList();
        }
        public List<Kichthuoc> GetMaKichthuoc()
        {
            return _context.Kichthuocs.ToList();
        }

        public List<Chatlieu> GetMaChatLieu()
        {
            return _context.Chatlieus.ToList();
        }

        public List<Mausac> GetMaMauSac()
        {
            return _context.Mausacs.ToList();
        }
        public List<Salesanpham> GetMaSale()
        {
            return _context.Salesanphams.ToList();
        }
        public bool Add(Sanphamchitiet spct)
        {
            _context.Add(spct);
            var sanPham = _context.Sanphams.FirstOrDefault(s => s.MaSanPham == spct.MaSanPham);
            if (sanPham != null)
            {
                sanPham.SoLuong += spct.SoLuong; // Increment the quantity
                _context.SaveChanges(); // Save changes to the database
            }
            _context.SaveChanges();
            return true;
        }

        public bool UpdateSanPham(Sanphamchitiet spct)
        {
            var existingSanPham = _context.Sanphamchitiets.Find(spct.MaSanPhamChiTiet);

            if (existingSanPham != null)
            {
                existingSanPham.TenSanPham = spct.TenSanPham;
                existingSanPham.MaSanPham = spct.MaSanPham;
                existingSanPham.Gia = spct.Gia;
                existingSanPham.SoLuong = spct.SoLuong;
                existingSanPham.MaKichThuoc = spct.MaKichThuoc;
                existingSanPham.MaChatLieu = spct.MaChatLieu;
                existingSanPham.MaMauSac = spct.MaMauSac;
                existingSanPham.MaSale = spct.MaSale;
                _context.SaveChanges();
                return true;
            }

            return false;
        }
        public bool DeleteCTSanPham(Sanphamchitiet spct)
        {
            var existingSanPham = _context.Sanphamchitiets.Find(spct.MaSanPhamChiTiet);

            if (existingSanPham != null)
            {
                existingSanPham.TrangThai = spct.TrangThai;
                existingSanPham.SoLuong = spct.SoLuong;

                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Sanphamchitiet> GetCTSanphams()
        {
            return _context.Sanphamchitiets.ToList();
        }

        public Sanpham GetSanPhamByMaSanPham(string maSanPham)
        {
            return _context.Sanphams.FirstOrDefault(s => s.MaSanPham == maSanPham);
        }
    }
}
