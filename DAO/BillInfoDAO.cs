using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;

        public BillInfoDAO()
        {
        }

        public static BillInfoDAO Intance
        {
            get { if (instance == null) instance = new BillInfoDAO(); return instance; }
            set => instance = value;
        }
    }
}
