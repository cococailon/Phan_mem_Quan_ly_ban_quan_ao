using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CHATLIEU",
                columns: table => new
                {
                    MaChatLieu = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Ten = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    TrangThai = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CHATLIEU__453995BCE5B106D4", x => x.MaChatLieu);
                });

            migrationBuilder.CreateTable(
                name: "KHACHHANG",
                columns: table => new
                {
                    SoDienThoai = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: false),
                    HoVaTen = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    GioiTinh = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime", nullable: false),
                    Email = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__KHACHHAN__0389B7BC50DA20DF", x => x.SoDienThoai);
                });

            migrationBuilder.CreateTable(
                name: "KHUYENMAI",
                columns: table => new
                {
                    MaKhuyenMai = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime", nullable: false),
                    NgayHetHan = table.Column<DateTime>(type: "datetime", nullable: false),
                    KieuKhuyenMai = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    MucGiam = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__KHUYENMA__6F56B3BD55C473B5", x => x.MaKhuyenMai);
                });

            migrationBuilder.CreateTable(
                name: "KICHTHUOC",
                columns: table => new
                {
                    MaKichThuoc = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Ten = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    TrangThai = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__KICHTHUO__22BFD6640728F522", x => x.MaKichThuoc);
                });

            migrationBuilder.CreateTable(
                name: "MAUSAC",
                columns: table => new
                {
                    MaMauSac = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Ten = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    TrangThai = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__MAUSAC__B9A91162318CD7E1", x => x.MaMauSac);
                });

            migrationBuilder.CreateTable(
                name: "NHANVIEN",
                columns: table => new
                {
                    MaNhanVien = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    TenNhanVien = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    SoDienThoai = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: false),
                    GioiTinh = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    NamSinh = table.Column<DateTime>(type: "datetime", nullable: false),
                    TrangThai = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    NgayVaoLam = table.Column<DateTime>(type: "datetime", nullable: false),
                    TenDangNhap = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    MatKhau = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    TenChucVu = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__NHANVIEN__77B2CA47A8736C5A", x => x.MaNhanVien);
                });

            migrationBuilder.CreateTable(
                name: "SALESANPHAM",
                columns: table => new
                {
                    MaSale = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    GiaTri = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    NgayBatDau = table.Column<DateTime>(type: "datetime", nullable: false),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SALESANP__B234B7A71DA7C800", x => x.MaSale);
                });

            migrationBuilder.CreateTable(
                name: "THUONGHIEU",
                columns: table => new
                {
                    MaThuongHieu = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    TenThuongHieu = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Email = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    SoDienThoai = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__THUONGHI__A3733E2CA6329A27", x => x.MaThuongHieu);
                });

            migrationBuilder.CreateTable(
                name: "HOADON",
                columns: table => new
                {
                    MaHoaDon = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    SoDienThoai = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: false),
                    MaNhanVien = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    MaKhuyenMai = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    NgayLap = table.Column<DateTime>(type: "datetime", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    TongTien = table.Column<double>(type: "float", nullable: false),
                    NgayThanhToan = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__HOADON__835ED13B8199D526", x => x.MaHoaDon);
                    table.ForeignKey(
                        name: "FK__HOADON__MaKhuyen__49C3F6B7",
                        column: x => x.MaKhuyenMai,
                        principalTable: "KHUYENMAI",
                        principalColumn: "MaKhuyenMai");
                    table.ForeignKey(
                        name: "FK__HOADON__MaNhanVi__68487DD7",
                        column: x => x.MaNhanVien,
                        principalTable: "NHANVIEN",
                        principalColumn: "MaNhanVien");
                    table.ForeignKey(
                        name: "FK__HOADON__SoDienTh__4BAC3F29",
                        column: x => x.SoDienThoai,
                        principalTable: "KHACHHANG",
                        principalColumn: "SoDienThoai");
                });

            migrationBuilder.CreateTable(
                name: "SANPHAM",
                columns: table => new
                {
                    MaSanPham = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    TenSanPham = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    GiaBan = table.Column<double>(type: "float", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    MaThuongHieu = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SANPHAM__FAC7442D65F77FA7", x => x.MaSanPham);
                    table.ForeignKey(
                        name: "FK__SANPHAM__MaThuon__4E88ABD4",
                        column: x => x.MaThuongHieu,
                        principalTable: "THUONGHIEU",
                        principalColumn: "MaThuongHieu");
                });

            migrationBuilder.CreateTable(
                name: "SANPHAMCHITIET",
                columns: table => new
                {
                    MaSanPhamChiTiet = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    TenSanPham = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Gia = table.Column<double>(type: "float", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    MaKichThuoc = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    MaChatLieu = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    MaMauSac = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    MaSale = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    MaSanPham = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SANPHAMC__0409209EAE7F1332", x => x.MaSanPhamChiTiet);
                    table.ForeignKey(
                        name: "FK__SANPHAMCH__MaCha__4F7CD00D",
                        column: x => x.MaChatLieu,
                        principalTable: "CHATLIEU",
                        principalColumn: "MaChatLieu");
                    table.ForeignKey(
                        name: "FK__SANPHAMCH__MaKic__5070F446",
                        column: x => x.MaKichThuoc,
                        principalTable: "KICHTHUOC",
                        principalColumn: "MaKichThuoc");
                    table.ForeignKey(
                        name: "FK__SANPHAMCH__MaMau__5165187F",
                        column: x => x.MaMauSac,
                        principalTable: "MAUSAC",
                        principalColumn: "MaMauSac");
                    table.ForeignKey(
                        name: "FK__SANPHAMCH__MaSal__52593CB8",
                        column: x => x.MaSale,
                        principalTable: "SALESANPHAM",
                        principalColumn: "MaSale");
                    table.ForeignKey(
                        name: "FK__SANPHAMCH__MaSan__534D60F1",
                        column: x => x.MaSanPham,
                        principalTable: "SANPHAM",
                        principalColumn: "MaSanPham");
                });

            migrationBuilder.CreateTable(
                name: "HOADONCHITIET",
                columns: table => new
                {
                    MaHoaDonChiTiet = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    MaHoaDon = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    MaSanPhamChiTiet = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    DonGia = table.Column<double>(type: "float", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__HOADONCH__6C2FD0CE8DB9FB9E", x => x.MaHoaDonChiTiet);
                    table.ForeignKey(
                        name: "FK__HOADONCHI__MaHoa__4CA06362",
                        column: x => x.MaHoaDon,
                        principalTable: "HOADON",
                        principalColumn: "MaHoaDon");
                    table.ForeignKey(
                        name: "FK__HOADONCHI__MaSan__4D94879B",
                        column: x => x.MaSanPhamChiTiet,
                        principalTable: "SANPHAMCHITIET",
                        principalColumn: "MaSanPhamChiTiet");
                });

            migrationBuilder.CreateIndex(
                name: "IX_HOADON_MaKhuyenMai",
                table: "HOADON",
                column: "MaKhuyenMai");

            migrationBuilder.CreateIndex(
                name: "IX_HOADON_MaNhanVien",
                table: "HOADON",
                column: "MaNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_HOADON_SoDienThoai",
                table: "HOADON",
                column: "SoDienThoai");

            migrationBuilder.CreateIndex(
                name: "IX_HOADONCHITIET_MaHoaDon",
                table: "HOADONCHITIET",
                column: "MaHoaDon");

            migrationBuilder.CreateIndex(
                name: "IX_HOADONCHITIET_MaSanPhamChiTiet",
                table: "HOADONCHITIET",
                column: "MaSanPhamChiTiet");

            migrationBuilder.CreateIndex(
                name: "IX_SANPHAM_MaThuongHieu",
                table: "SANPHAM",
                column: "MaThuongHieu");

            migrationBuilder.CreateIndex(
                name: "IX_SANPHAMCHITIET_MaChatLieu",
                table: "SANPHAMCHITIET",
                column: "MaChatLieu");

            migrationBuilder.CreateIndex(
                name: "IX_SANPHAMCHITIET_MaKichThuoc",
                table: "SANPHAMCHITIET",
                column: "MaKichThuoc");

            migrationBuilder.CreateIndex(
                name: "IX_SANPHAMCHITIET_MaMauSac",
                table: "SANPHAMCHITIET",
                column: "MaMauSac");

            migrationBuilder.CreateIndex(
                name: "IX_SANPHAMCHITIET_MaSale",
                table: "SANPHAMCHITIET",
                column: "MaSale");

            migrationBuilder.CreateIndex(
                name: "IX_SANPHAMCHITIET_MaSanPham",
                table: "SANPHAMCHITIET",
                column: "MaSanPham");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HOADONCHITIET");

            migrationBuilder.DropTable(
                name: "HOADON");

            migrationBuilder.DropTable(
                name: "SANPHAMCHITIET");

            migrationBuilder.DropTable(
                name: "KHUYENMAI");

            migrationBuilder.DropTable(
                name: "NHANVIEN");

            migrationBuilder.DropTable(
                name: "KHACHHANG");

            migrationBuilder.DropTable(
                name: "CHATLIEU");

            migrationBuilder.DropTable(
                name: "KICHTHUOC");

            migrationBuilder.DropTable(
                name: "MAUSAC");

            migrationBuilder.DropTable(
                name: "SALESANPHAM");

            migrationBuilder.DropTable(
                name: "SANPHAM");

            migrationBuilder.DropTable(
                name: "THUONGHIEU");
        }
    }
}
