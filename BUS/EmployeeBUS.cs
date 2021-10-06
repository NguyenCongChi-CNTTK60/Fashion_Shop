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
    public class EmployeeBUS
    {
        private static EmployeeBUS instance;

        public EmployeeBUS()
        {
        }

        public static EmployeeBUS Intance
        {
            get { if (instance == null) instance = new EmployeeBUS(); return instance; }
            set => instance = value;
        }

    }
}
