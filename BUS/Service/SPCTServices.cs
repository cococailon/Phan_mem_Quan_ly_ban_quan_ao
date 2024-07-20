using BUS.IService;
using DAL.Models;
using DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Service
{
    public class SPCTServices : ISPCTService
    {
        private SPCTRepos _repos;

        public SPCTServices()
        {
            _repos = new SPCTRepos();
        }

        public List<Sanpham> GetMaSanphams()
        {
            return _repos.GetMaSP();
        }
        public List<Kichthuoc> GetMaKichthuoc()
        {
            return _repos.GetMaKichthuoc();
        }
        public List<Chatlieu> GetMaChatLieu()
        {
            return _repos.GetMaChatLieu();
        }
        public List<Mausac> GetMaMauSac()
        {
            return _repos.GetMaMauSac();
        }
        public List<Salesanpham> GetMaSale()
        {
            return _repos.GetMaSale();
        }

        public string GetTenSanPhamByMaSP(string maSP)
        {
            using (var context = new DUAN1_QL_BANQUANAOContext())
            {
                // Thực hiện truy vấn để lấy tên sản phẩm dựa trên mã sản phẩm
                var tenSanPham = context.Sanphams
                    .Where(sp => sp.MaSanPham == maSP)
                    .Select(sp => sp.TenSanPham)
                    .FirstOrDefault();

                return tenSanPham;
            }
        }
        public string Add(Sanphamchitiet spct)
        {
            try
            {
                _repos.Add(spct);
                return "Thêm thành công";
            }
            catch
            {
                return "Thêm thất bại";
            }


        }

        public string Update(Sanphamchitiet spct)
        {
            try
            {
                if (_repos.UpdateSanPham(spct))
                {
                    return "Sửa thành công!";
                }
                else
                {
                    return "Không thể sửa dữ liệu.";
                }
            }
            catch (Exception ex)
            {
                return $"Lỗi: {ex.Message}";
            }
        }

        public string Delete(Sanphamchitiet CTSanPham)
        {
            try
            {
                if (_repos.DeleteCTSanPham(CTSanPham))
                {
                    return "Xóa thành công!";
                }
                else
                {
                    return "Không thể xóa dữ liệu.";
                }
            }
            catch (Exception ex)
            {
                return $"Lỗi: {ex.Message}";
            }
        }



        public List<Sanphamchitiet> GetCTSanphams()
        {
            return _repos.GetCTSanphams();
        }

        public Sanpham GetSanPhamByMaSanPham(string maSanPham)
        {
            return _repos.GetSanPhamByMaSanPham(maSanPham);
        }
    }
}
