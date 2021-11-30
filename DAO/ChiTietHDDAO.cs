using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    class ChiTietHDDAO
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
    }
}
