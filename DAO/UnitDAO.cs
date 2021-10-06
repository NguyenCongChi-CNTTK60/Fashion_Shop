using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class UnitDAO
    {
        private static UnitDAO instance;

        public UnitDAO()
        {
        }

        public static UnitDAO Intance
        {
            get { if (instance == null) instance = new UnitDAO(); return instance; }
            set => instance = value;
        }
    }
}
