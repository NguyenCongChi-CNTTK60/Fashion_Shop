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
    public class CouponInfoBUS
    {
        private static CouponInfoBUS instance;

        public CouponInfoBUS()
        {
        }

        public static CouponInfoBUS Intance
        {
            get { if (instance == null) instance = new CouponInfoBUS(); return instance; }
            set => instance = value;
        }
    }
}
