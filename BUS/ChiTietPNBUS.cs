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
    public class ChiTietPNBUS
    {
        private static ChiTietPNBUS instance;

        public ChiTietPNBUS()
        {
        }

        public static ChiTietPNBUS Intance
        {
            get { if (instance == null) instance = new ChiTietPNBUS(); return instance; }
            set => instance = value;
        }

        public bool saveCoupon(string maPN, string maHang, int sl, int gia)
        {
            return ChiTietPNBUS.Intance.saveCoupon(maPN, maHang, sl, gia);
        }

        public DataTable getCouponInfo(string maPN)
        {
            return ChiTietPNBUS.Intance.getCouponInfo(maPN);
        }
    }
}

