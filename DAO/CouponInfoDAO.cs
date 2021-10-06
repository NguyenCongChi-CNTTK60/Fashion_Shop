using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAO
{
    public class CouponInfoDAO
    {
        private static CouponInfoDAO instance;

        public CouponInfoDAO()
        {
        }

        public static CouponInfoDAO Intance
        {
            get { if (instance == null) instance = new CouponInfoDAO(); return instance; }
            set => instance = value;
        }
    }
}
