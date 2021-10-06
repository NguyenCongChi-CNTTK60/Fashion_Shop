using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
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

