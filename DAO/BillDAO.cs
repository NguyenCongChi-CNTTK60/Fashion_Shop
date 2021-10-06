using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        public BillDAO()
        {
        }

        public static BillDAO Intance
        {
            get { if (instance == null) instance = new BillDAO(); return instance; }
            set => instance = value;
        }
    }
}
