using BUS.IService;
using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Service
{
    public class SanPhamService : ISanPhamService
    {
        private SanPhamRepos _repos;
        public SanPhamService()
        {
            _repos = new SanPhamRepos();
        }

        public string Add(Sanpham sp)
        {
            try
            {
                _repos.Add(sp);
                return "Thêm thành công";
            }
            catch
            {
                return "Thêm thất bại";
            }


        }

        public List<Sanpham> GetSanphams()
        {
            return _repos.GetSanphams();
        }

        public List<Thuonghieu> GetThuonghieus()
        {
            return _repos.GetMaThuongHieu();
        }

        public string Update(Sanpham sanpham)
        {
            try
            {
                if (_repos.UpdateSanPham(sanpham))
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
        public void UpdateSPCT(string maSanPham, int soLuong, string trangThai)
        {
            _repos.UpdateSanphamChiTiet(maSanPham, soLuong, trangThai);
        }

        public string Delete(Sanpham sanpham)
        {
            try
            {
                if (_repos.DeleteSanPham(sanpham))
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
    }
}
