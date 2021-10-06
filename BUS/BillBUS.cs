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
    public class BillBUS
    {
        private static BillBUS instance;

        public BillBUS()
        {
        }

        public static BillBUS Intance
        {
            get { if (instance == null) instance = new BillBUS(); return instance; }
            set => instance = value;
        }
    }
}
