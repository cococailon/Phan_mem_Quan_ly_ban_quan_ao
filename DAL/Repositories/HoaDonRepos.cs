using DAL.Models;
using DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL.Repositories
{
    public class HoaDonRepos : IHoaDonrepos
    {
        private DUAN1_QL_BANQUANAOContext _dbContext;

        public HoaDonRepos(DUAN1_QL_BANQUANAOContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Hoadon> GetAllHD()
        {
            using (_dbContext = new DUAN1_QL_BANQUANAOContext())
            {
                return _dbContext.Hoadons.ToList();
            }
        }

        public List<Hoadonchitiet> GetAllHdct()
        {
            using (_dbContext = new DUAN1_QL_BANQUANAOContext())
            {
                return _dbContext.Hoadonchitiets.ToList();
            }
        }

        public List<TbJoinHdctSpct> GetSPTrongHD(string MaHD)
        {
            using (_dbContext = new DUAN1_QL_BANQUANAOContext())
            {
                var query = from tb1 in _dbContext.Hoadonchitiets
                            join
                            tb2 in _dbContext.Sanphamchitiets on tb1.MaSanPhamChiTiet equals tb2.MaSanPhamChiTiet
                            join
                            tb3 in _dbContext.Salesanphams on tb2.MaSale equals tb3.MaSale
                            join
                            tb4 in _dbContext.Hoadons on tb1.MaHoaDon equals tb4.MaHoaDon
                            join
                            tb5 in _dbContext.Khuyenmais on tb4.MaKhuyenMai equals tb5.MaKhuyenMai
                            select new TbJoinHdctSpct
                            {
                                MaHoaDon = tb1.MaHoaDon,
                                MaHoaDonCT = tb1.MaHoaDonChiTiet,
                                MaSanPham = tb2.MaSanPham,
                                MaSanPhamChiTiet = tb1.MaSanPhamChiTiet,
                                TenSanPham = tb2.TenSanPham,
                                DonGia = tb1.DonGia,
                                SoLuong = tb1.SoLuong,
                                Sale = tb3.GiaTri,
                                NgayHetHanS = tb3.NgayKetThuc,
                                GhiChu = tb1.GhiChu
                            };

                List<TbJoinHdctSpct> tbJoinRet = query.Where(j => j.MaHoaDon == MaHD).ToList();

                return tbJoinRet;
            }
        }

        public Khuyenmai GetKMByMaKM(string maKM)
        {
            using (_dbContext = new DUAN1_QL_BANQUANAOContext())
            {
                return _dbContext.Khuyenmais.Find(maKM);
            }
        }

        public List<Sanphamchitiet> GetAllSpct()
        {
            using (_dbContext = new DUAN1_QL_BANQUANAOContext())
            {
                return _dbContext.Sanphamchitiets.Where(spct => spct.TrangThai == "Đang bán").ToList();
            }
        }

        public void InsertSpVaoHD(Hoadonchitiet hoadonchitiet)
        {
            using (_dbContext = new DUAN1_QL_BANQUANAOContext())
            {
                _dbContext.Hoadonchitiets.Add(hoadonchitiet);
                _dbContext.SaveChanges();
            }
        }

        public void UpdateHD(Hoadon hoadon)
        {
            using (_dbContext = new DUAN1_QL_BANQUANAOContext())
            {
                _dbContext.Hoadons.Update(hoadon);
                _dbContext.SaveChanges();
            }
        }

        public Sanphamchitiet GetSpctByMaSpct(string MaSpct)
        {
            using (_dbContext = new DUAN1_QL_BANQUANAOContext())
            {
                return _dbContext.Sanphamchitiets.Find(MaSpct);
            }
        }

        public void UpdateHdct(Hoadonchitiet hoadonchitiet)
        {
            using (_dbContext = new DUAN1_QL_BANQUANAOContext())
            {
                _dbContext.Hoadonchitiets.Update(hoadonchitiet);
                _dbContext.SaveChanges();
            }
        }

        public void XoaHdct(string maHoaDonCT)
        {
            using (_dbContext = new DUAN1_QL_BANQUANAOContext())
            {
                Hoadonchitiet hdct = _dbContext.Hoadonchitiets.Find(maHoaDonCT);
                _dbContext.Hoadonchitiets.Remove(hdct);
                _dbContext.SaveChanges();
            }
        }

        public List<Sanphamchitiet> GetSpctByMaspSpctTenSp(string tuKhoa)
        {
            using (_dbContext = new DUAN1_QL_BANQUANAOContext())
            {
                return _dbContext.Sanphamchitiets.Where(spct => spct.MaSanPham == tuKhoa
                || spct.MaSanPhamChiTiet == tuKhoa || spct.TenSanPham == tuKhoa).ToList();
            }
        }

        public void UpdateSpctSp(Sanphamchitiet spct, Sanpham sp)
        {
            using (_dbContext = new DUAN1_QL_BANQUANAOContext())
            {
                _dbContext.Sanphamchitiets.Update(spct);
                _dbContext.Sanphams.Update(sp);
                _dbContext.SaveChanges();
            }
        }

        public Sanpham GetSpByMaSp(string maSp)
        {
            using (_dbContext = new DUAN1_QL_BANQUANAOContext())
            {
                return _dbContext.Sanphams.Find(maSp);
            }
        }

        public Khachhang GetKHBySDT(string SDT)
        {
            using (_dbContext = new DUAN1_QL_BANQUANAOContext())
            {
                return _dbContext.Khachhangs.Find(SDT);
            }
        }

        public void InsertHD(Hoadon hoadon)
        {
            using (_dbContext = new DUAN1_QL_BANQUANAOContext())
            {
                _dbContext.Hoadons.Add(hoadon);
                _dbContext.SaveChanges();
            }
        }

        public void DeleteHD(string Mahoadon)
        {
            using (_dbContext = new DUAN1_QL_BANQUANAOContext())
            {
                Hoadon hd = _dbContext.Hoadons.Find(Mahoadon);
                _dbContext.Hoadons.Remove(hd);
                _dbContext.SaveChanges();
            }
        }

        public Hoadon GetHDByID(string MaHD)
        {
            using (_dbContext = new DUAN1_QL_BANQUANAOContext())
            {
                return _dbContext.Hoadons.Find(MaHD);
            }
        }
    }
}
