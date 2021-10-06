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
    }
}

