using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;

        public BillInfoDAO()
        {
        }

        public static BillInfoDAO Intance
        {
            get { if (instance == null) instance = new BillInfoDAO(); return instance; }
            set => instance = value;
        }
        public bool LuuDonHang(string madh, string masp, int sl, int gia)
        {

            string query = String.Format("insert into CTHD values('{0}','{1}','{2}','{3}')", madh, masp, sl, gia);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public DataTable getCTDN(string maHD)
        {
            string query = String.Format("select MATHANG.MaHang, TenHang, CTHD.SoLuong, DonGia, DonGia * CTHD.SoLuong As 'TongTien' from CTHD, MATHANG where MaHD = '{0}'and CTHD.MaHang = MATHANG.MaHang", maHD);

            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
