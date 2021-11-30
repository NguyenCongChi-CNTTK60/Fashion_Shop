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
    public class ChiTietHDBUS
    {
        private static ChiTietHDBUS instance;

        public ChiTietHDBUS()
        {
        }

        public static ChiTietHDBUS Intance
        {
            get { if (instance == null) instance = new ChiTietHDBUS(); return instance; }
            set => instance = value;
        }

        public bool LuuDonHang(string madh, string masp, int sl, int gia)
        {
            return ChiTietHDDAO.Intance.LuuDonHang(madh, masp, sl, gia);
        }

        public DataTable getCTDN(string maHD)
        {

            return ChiTietHDDAO.Intance.getCTDN(maHD);
        }
    }
}
