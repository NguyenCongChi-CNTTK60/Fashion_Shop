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
    public class BillInfoBUS
    {
        private static BillInfoBUS instance;

        public BillInfoBUS()
        {
        }

        public static BillInfoBUS Intance
        {
            get { if (instance == null) instance = new BillInfoBUS(); return instance; }
            set => instance = value;
        }

        public bool saveBill(string madh, string masp, int sl, int gia)
        {
            return BillInfoDAO.Intance.saveBill(madh, masp, sl, gia);
        }

        public DataTable getBillInfo(string maHD)
        {

            return BillInfoDAO.Intance.getBillInfo(maHD);
        }
    }
}