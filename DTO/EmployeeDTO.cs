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
        private string tenDangNhap, matKhau, tenNguoiDung, Quyen;
        public EmployeeDTO(DataRow row)
        {
            this.TenDangNhap = row["TenDangNhap"].ToString();
            this.MatKhau = row["MatKhau"].ToString();
            this.TenNguoiDung = row["TenNguoiDung"].ToString();
            this.Quyen1 = row["Quyen"].ToString();
        }

        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string TenNguoiDung { get => tenNguoiDung; set => tenNguoiDung = value; }
        public string Quyen1 { get => Quyen; set => Quyen = value; }
    }
}
