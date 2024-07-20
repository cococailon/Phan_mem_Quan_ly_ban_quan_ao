namespace DAL.Models
{
    public partial class TbJoinHdctSpct
    {
        public string MaHoaDon { get; set; }
        public string MaSanPham { get; set; }
        public string MaSanPhamChiTiet { get; set; }
        public string TenSanPham { get; set; }
        public double DonGia { get; set; }
        public int SoLuong { get; set; }
        public string Sale { get; internal set; }
        public DateTime NgayHetHanS { get; internal set; }
        public string GhiChu { get; set; }
        public string MaHoaDonCT { get; internal set; }
    }
}