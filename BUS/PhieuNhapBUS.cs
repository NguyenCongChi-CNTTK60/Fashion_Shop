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
    public class PhieuNhapBUS
    {
        private static PhieuNhapBUS instance;

        public PhieuNhapBUS()
        {
        }

        public static PhieuNhapBUS Intance
        {
            get { if (instance == null) instance = new PhieuNhapBUS(); return instance; }
            set => instance = value;
        }

        public DataTable GetListCoupon()
        {
            return PhieuNhapDAO.Intance.GetListCoupon();
        }

        public bool insertCoupon(string maPN, string maNCC, DateTime NgayNhap, string TenDangNhap)
        {

            return PhieuNhapDAO.Intance.insertCoupon(maPN, maNCC, NgayNhap, TenDangNhap);
        }

        public string loadIDCoupon()
        {
            return PhieuNhapDAO.Intance.loadIDCoupon();
        }

        public bool deleteCoupon(string maPN)
        {
            return PhieuNhapDAO.Intance.deleteCoupon(maPN);
        }


        public DataTable searchCoupon(string maPN)
        {
            return PhieuNhapDAO.Intance.searchCoupon(maPN);
        }



        // CHÍ
        public DataTable TKPhieuNhap()
        {
            return PhieuNhapDAO.Intance.TKPhieuNhap();
        }


        public DataTable TimKiemPN(string tk)
        {
            return PhieuNhapDAO.Intance.TimKiemPN(tk);
        }

    }
}
