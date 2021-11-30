using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    class HoaDonDAO
    {
        private static HoaDonDAO instance;

        public HoaDonDAO()
        {
        }

        public static HoaDonDAO Intance
        {
            get { if (instance == null) instance = new HoaDonDAO(); return instance; }
            set => instance = value;
        }

        public string LoadMaDHMoi()
        {
            string madh = "";

            madh = "DH" + DateTime.Now.Day.ToString("00") + DateTime.Now.Month.ToString("00") + DateTime.Now.Year.ToString("0000");

            string query = String.Format("SELECT dbo.fn_Get_MaDonHang_Next( @MaHD )");

            object madh_next = DataProvider.Instance.ExecuteScalar(query, new object[] { madh });

            if (madh_next.ToString() == "")
            {
                madh_next = madh + "001";
            }
            return madh_next.ToString();
        }

        public bool LuuDonHang(HoaDonDTO dh)
        {
            // Convert datetime to date SQL Server 
            string query = String.Format("insert into HoaDon values('{0}','{1}','{2}','{3}','{4}')", dh.MaHD, dh.MaKH, dh.NgayTao, dh.MaNV, dh.TongTien);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

    }
}
