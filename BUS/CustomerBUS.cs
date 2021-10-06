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
    public class CustomerBUS
    {
        private static CustomerBUS instance;

        public CustomerBUS()
        {
        }

        public static CustomerBUS Intance
        {
            get { if (instance == null) instance = new CustomerBUS(); return instance; }
            set => instance = value;
        }
    }
}
