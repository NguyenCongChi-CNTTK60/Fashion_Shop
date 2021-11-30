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
    public class KhachHangBUS
    {
        private static KhachHangBUS instance;

        public KhachHangBUS()
        {
        }

        public static KhachHangBUS Intance
        {
            get { if (instance == null) instance = new KhachHangBUS(); return instance; }
            set => instance = value;
        }

        public DataTable getListKH()
        {
            return KhachHangDAO.Intance.getListKH();
        }

        public bool themKH(string maKH, string tenKH, string DiaChi, string SDT, string email, string maHang, string matKhau)
        {
            return KhachHangDAO.Intance.themKH(maKH, tenKH, DiaChi, SDT, email, maHang, matKhau);
        }

        public bool suaKH(string maKH, string tenKH, string DiaChi, string SDT, string email, string maHang)
        {
            return KhachHangDAO.Intance.suaKH(maKH, tenKH, DiaChi, SDT, email, maHang);
        }

        public bool xoaKH(string maKH)
        {
            return KhachHangDAO.Intance.xoaKH(maKH);
        }

        public DataTable TimKiemKH(string name)
        {
            return KhachHangDAO.Intance.TimKiemKH(name);
        }

        public string loadMaKH()
        {
            return KhachHangDAO.Intance.loadMaKH();
        }

        public KhachHangDTO GetTenBySDT(string id)
        {
            return KhachHangDAO.Intance.GetTenBySDT(id);
        }

        public bool Login(string username, string pass)
        {
            return KhachHangDAO.Intance.Login(username, pass);
        }

        public KhachHangDTO getDataByID(string id)
        {
            return KhachHangDAO.Intance.getDataByID(id);
        }

        public bool doiMatKhau(string maKH, string matKhauMoi)
        {
            return KhachHangDAO.Intance.doiMatKhau(maKH, matKhauMoi);
        }
    }
}
