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
    public class SupplierBUS
    {
        private static SupplierBUS instance;

        public SupplierBUS()
        {
        }

        public static SupplierBUS Intance
        {
            get { if (instance == null) instance = new SupplierBUS(); return instance; }
            set => instance = value;
        }
    }
}
