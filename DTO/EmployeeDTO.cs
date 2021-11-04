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
        private string maNV, tenNV, chucVu, sdt, tenDangNhap, matKhau, maQuyen;
        public EmployeeDTO(DataRow row)
        {
            this.MaNV = row["MaNV"].ToString();
            this.TenNV = row["TenNV"].ToString();
            this.ChucVu = row["ChucVu"].ToString();
            this.Sdt = row["Sdt"].ToString();
            this.TenDangNhap = row["TenDangNhap"].ToString();
            this.MaQuyen = row["MaQuyen"].ToString();
        }

        public string MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string MaQuyen { get => maQuyen; set => maQuyen = value; }
    }
}

