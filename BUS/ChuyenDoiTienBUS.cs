using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BUS
{
    public class ChuyenDoiTienBUS
    {
        private static ChuyenDoiTienBUS instance;

        public ChuyenDoiTienBUS()
        {

        }
        public static ChuyenDoiTienBUS Instance
        {
            get { if (instance == null) instance = new ChuyenDoiTienBUS(); return ChuyenDoiTienBUS.instance; }
            private set { ChuyenDoiTienBUS.instance = value; }
        }

        public string So_chu(double gnumber)
        {
            return ChuyenDoiTienDAO.Instance.So_chu(gnumber);
        }
    }
}
