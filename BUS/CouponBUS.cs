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
    public class CouponBUS
    {
        private static CouponBUS instance;

        public CouponBUS()
        {
        }

        public static CouponBUS Intance
        {
            get { if (instance == null) instance = new CouponBUS(); return instance; }
            set => instance = value;
        }

        public DataTable GetListPN()
        {
            return CouponDAO.Intance.GetListCoupon();
        }

        public bool themPN(string maPN, string maNCC, DateTime NgayNhap, string TenDangNhap)
        {

            return CouponDAO.Intance.themPN(maPN, maNCC, NgayNhap, TenDangNhap);
        }

        public string loadMaPN()
        {
            return CouponDAO.Intance.loadMaPN();
        }

        public bool xoaPN(string maPN)
        {
            return CouponDAO.Intance.xoaPN(maPN);
        }


        public DataTable TimKiemPN(string maPN)
        {
            return CouponDAO.Intance.TimKiemPN(maPN);
        }
    }
}

