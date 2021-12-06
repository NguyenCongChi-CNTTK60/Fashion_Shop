using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp;

namespace DAO
{
    public class ChiTietHDDAO
    {
        private static ChiTietHDDAO instance;

        public ChiTietHDDAO()
        {
        }

        public static ChiTietHDDAO Intance
        {
            get { if (instance == null) instance = new ChiTietHDDAO(); return instance; }
            set => instance = value;
        }

        public bool LuuDonHang(string madh, string masp, int sl, int gia)
        {

            string query = String.Format("insert into ChiTietHD values('{0}','{1}','{2}','{3}')", madh, masp, sl, gia);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public DataTable getCTDN(string maHD)
        {
            string query = String.Format("select MatHang.MaMH, TenMH, ChiTietHD.SoLuong, DonGia, DonGia * ChiTietHD.SoLuong As 'TongTien' from ChiTietHD, MatHang where MaHD = '{0}'and ChiTietHD.MaMH = H.MaMH", maHD);

            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
