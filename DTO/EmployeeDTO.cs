using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DTO
{
    public class EmployeeDTO
    {
        private string userName, passWord, employeeName, authorization;
        public EmployeeDTO(DataRow row)
        {
            this.TenDangNhap = row["TenDangNhap"].ToString();
            this.MatKhau = row["MatKhau"].ToString();
            this.TenNguoiDung = row["TenNguoiDung"].ToString();
            this.Quyen1 = row["Quyen"].ToString();
        }

        public string TenDangNhap { get => userName; set => userName = value; }
        public string MatKhau { get => passWord; set => passWord = value; }
        public string TenNguoiDung { get => employeeName; set => employeeName = value; }
        public string Quyen1 { get => authorization; set => authorization = value; }
    }
}
