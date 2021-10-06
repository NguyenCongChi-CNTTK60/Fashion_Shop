using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class CommodityBUS
    {
        private static CommodityBUS instance;

        public CommodityBUS()
        {
        }

        public static CommodityBUS Intance
        {
            get { if (instance == null) instance = new CommodityBUS(); return instance; }
            set => instance = value;
        }
    }
}

