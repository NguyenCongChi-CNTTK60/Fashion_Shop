using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DTO
{
    public class NhanVienDTO
    {
        private string maNV, tenHienThi, sdt,diaChi ,tenDangNhap, matKhau, quyen;

        public NhanVienDTO(DataRow row)
        {
            this.MaNV = row["MaNV"].ToString();
            this.TenHienThi = row["TenHienThi"].ToString();
            this.Sdt = row["SDT"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
            this.TenDangNhap = row["TenDangNhap"].ToString();
            this.MatKhau = row["MatKhau"].ToString();
            this.Quyen = row["Quyen"].ToString();
        }

        public string MaNV { get => maNV; set => maNV = value; }
        public string TenHienThi { get => tenHienThi; set => tenHienThi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string Quyen { get => quyen; set => quyen = value; }

    }
}

