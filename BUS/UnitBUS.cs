using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class UnitBUS
    {
        private static UnitBUS instance;

        public UnitBUS()
        {
        }

        public static UnitBUS Intance
        {
            get { if (instance == null) instance = new UnitBUS(); return instance; }
            set => instance = value;
        }

        public UnitDTO getDataById(string id)
        {
            return UnitDAO.Intance.getDataById(id);
        }
    }
}
