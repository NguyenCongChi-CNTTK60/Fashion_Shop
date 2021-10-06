using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class EmployeeDAO
    {
        private static EmployeeDAO instance;

        public EmployeeDAO()
        {
        }

        public static EmployeeDAO Intance
        {
            get { if (instance == null) instance = new EmployeeDAO(); return instance; }
            set => instance = value;
        }
    }
}
