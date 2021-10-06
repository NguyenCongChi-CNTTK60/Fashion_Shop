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
    public class CommodityDAO
    {
        private static CommodityDAO instance;

        public CommodityDAO()
        {
        }

        public static CommodityDAO Intance
        {
            get { if (instance == null) instance = new CommodityDAO(); return instance; }
            set => instance = value;
        }
    }
}
