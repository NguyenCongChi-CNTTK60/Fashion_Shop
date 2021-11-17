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

        public bool insertCoupon(string maPN, string maNCC, DateTime NgayNhap, string TenDangNhap)
        {

            return CouponDAO.Intance.insertCoupon(maPN, maNCC, NgayNhap, TenDangNhap);
        }

        public string loadID()
        {
            return CouponDAO.Intance.loadID();
        }

        public bool deleteCoupon(string maPN)
        {
            return CouponDAO.Intance.deleteCoupon(maPN);
        }


        public DataTable searchCoupon(string maPN)
        {
            return CouponDAO.Intance.searchCoupon(maPN);
        }
    }
}
