using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CustomerDAO
    {
        private static CustomerDAO instance;

        public CustomerDAO()
        {
        }

        public static CustomerDAO Intance
        {
            get { if (instance == null) instance = new CustomerDAO(); return instance; }
            set => instance = value;
        }
    }
}

