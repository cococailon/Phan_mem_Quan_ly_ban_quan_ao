using BUS.IService;
using BUS.Service;
using DAL.Models;
using DAL.IRepositories;
using DAL.Repositories;
using PRL.Forms;

namespace PRL
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new QLHoaDon(new HoaDonServices(new HoaDonRepos(new DUAN1_QL_BANQUANAOContext()))));
            //Application.Run(new quanLiMaGiamGia(new KhuyenMaiServices(new KhuyenMaiRepos(new DUAN1_QL_BANQUANAOContext()))));
            //Application.Run(new FormQLTong());
            //Application.Run(new QLNhanVien());
            //Application.Run(new TrangChu());
            //Application.Run(new QLKhachHang());
            Application.Run(new Login());

        }
    } 
}