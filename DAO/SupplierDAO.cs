
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class SupplierDAO
    {
        private static SupplierDAO instance;

        public SupplierDAO()
        {
        }

        public static SupplierDAO Intance
        {
            get { if (instance == null) instance = new SupplierDAO(); return instance; }
            set => instance = value;
        }
    }
}
