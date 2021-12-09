using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    class Chuoiketnoi
    {
        string str;
        public Chuoiketnoi()
        {
            str = @"Data Source=DESKTOP-RNOPI29;Initial Catalog=QLCuaHangThoiTrang;User ID=sa;Password=123";
        }

        public SqlConnection sqlConnection()
        {
            return new SqlConnection(str);
        }
    }
}
