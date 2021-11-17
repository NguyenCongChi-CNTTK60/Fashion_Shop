using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAO
{
    public class CouponInfoDAO
    {
        private static CouponInfoDAO instance;

        public CouponInfoDAO()
        {
        }

        public static CouponInfoDAO Intance
        {
            get { if (instance == null) instance = new CouponInfoDAO(); return instance; }
            set => instance = value;
        }

        public bool saveCoupon(string maPN, string maHang, int sl, int gia)
        {
            string query = String.Format("insert into CTPN values('{0}','{1}',{2},{3})", maPN, maHang, sl, gia);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public DataTable getCouponInfo(string maPN)
        {
            string query = "exec getCTPN @maPN";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { maPN });
        }
    }
}
