using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class CouponDTO
    {
        private static CouponDTO instance;

        public CouponDTO()
        {
        }

        public static CouponDTO Intance
        {
            get { if (instance == null) instance = new CouponDTO(); return instance; }
            set => instance = value;
        }

    }
}
