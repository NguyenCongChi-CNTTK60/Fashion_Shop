using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class HoaDonBUS
    {
        private static HoaDonBUS instance;

        public HoaDonBUS()
        {
        }

        public static HoaDonBUS Intance
        {
            get { if (instance == null) instance = new HoaDonBUS(); return instance; }
            set => instance = value;
        }

        public string LoadMaDHMoi()
        {
            return HoaDonDAO.Intance.LoadMaDHMoi();
        }

        public bool LuuDonHang(HoaDonDTO dh)
        {
            return HoaDonDAO.Intance.LuuDonHang(dh);
        }

        public DataTable LoadDanhSachDonHangTheoKH(string MaKH)
        {
            return HoaDonDAO.Intance.LoadDanhSachDonHangTheoKH(MaKH);
        }


        // CHÍ
        public DataTable TKHoaDon(DateTime ngaybd, DateTime ngaykt)
        {
            return HoaDonDAO.Intance.TKHoaDon(ngaybd, ngaykt);
        }


        public DataTable TongTienHoaDon()
        {
            return HoaDonDAO.Intance.TongTienHoaDon();
        }


        public DataTable TongTienTheoNgay(DateTime ngaybd, DateTime ngaykt)
        {
            return HoaDonDAO.Intance.TongTienTheoNgay(ngaybd,ngaykt);
        }
    }
}