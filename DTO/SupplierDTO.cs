using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SupplierDTO
    {
        private string maNCC, tenNCC, email, diaChi;
        private int sDT;

        public SupplierDTO()
        {
        }

        public SupplierDTO(DataRow row)
        {
            this.MaNCC = row["MaNCC"].ToString();
            this.TenNCC = row["TenNCC"].ToString();
            this.SDT = (int)row["SDT"];
            this.Email = row["Email"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
        }

        public string MaNCC { get => maNCC; set => maNCC = value; }
        public string TenNCC { get => tenNCC; set => tenNCC = value; }
        public string Email { get => email; set => email = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public int SDT { get => sDT; set => sDT = value; }
    }
}





