

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class ConvertMoneyBUS
    {
        private static ConvertMoneyBUS instance;

        public ConvertMoneyBUS()
        {

        }
        public static ConvertMoneyBUS Instance
        {
            get { if (instance == null) instance = new ConvertMoneyBUS(); return ConvertMoneyBUS.instance; }
            private set { ConvertMoneyBUS.instance = value; }
        }

        public string chuyenDoi(double gnumber)
        {
            return ConvertMoneyDAO.Instance.So_chu(gnumber);
        }
    }
}
