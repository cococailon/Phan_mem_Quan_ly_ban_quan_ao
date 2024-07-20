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
    public class SanPhamRepos : ISanPhamRepos
    {
        DUAN1_QL_BANQUANAOContext _context;
        public SanPhamRepos()
        {
            _context = new DUAN1_QL_BANQUANAOContext();
        }
        public bool Add(Sanpham sp)
        {
            _context.Add(sp);
            _context.SaveChanges();
            return true;
        }

        public List<Sanpham> GetSanphams()
        {
            return _context.Sanphams.ToList();
        }
        public Sanpham GetSanphamById(string maSanPham)
        {
            return _context.Sanphams.FirstOrDefault(s => s.MaSanPham == maSanPham);
        }

        public List<Thuonghieu> GetMaThuongHieu()
        {
            return _context.Thuonghieus.ToList();
        }
        public bool UpdateSanPham(Sanpham sanpham)
        {
            var existingSanPham = _context.Sanphams.Find(sanpham.MaSanPham);

            if (existingSanPham != null)
            {
                existingSanPham.TenSanPham = sanpham.TenSanPham;
                existingSanPham.MaThuongHieu = sanpham.MaThuongHieu;
                existingSanPham.GiaBan = sanpham.GiaBan;
                existingSanPham.SoLuong = sanpham.SoLuong;

                _context.SaveChanges();
                return true;
            }

            return false;
        }
        public bool DeleteSanPham(Sanpham sanpham)
        {
            var existingSanPham = _context.Sanphams.Find(sanpham.MaSanPham);

            if (existingSanPham != null)
            {
                existingSanPham.TrangThai = sanpham.TrangThai;
                existingSanPham.SoLuong = sanpham.SoLuong;

                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public void UpdateSanphamChiTiet(string maSanPham, int soLuong, string trangThai)
        {
            var sanphamChiTiet = _context.Sanphamchitiets.SingleOrDefault(sc => sc.MaSanPham == maSanPham);

            if (sanphamChiTiet != null)
            {
                // Update the properties
                sanphamChiTiet.SoLuong = soLuong;
                sanphamChiTiet.TrangThai = trangThai;

                // Save changes to the database
                _context.SaveChanges();
            }
            // You may want to handle the case where the record is not found
        }
    }
}
