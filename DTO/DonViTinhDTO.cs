using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace DTO
{
    public class DonViTinhDTO
    {
        private string maDVT;
        private string tenDVT;

        public DonViTinhDTO(string maDVT, string tenDVT)
        {
            this.maDVT = maDVT;
            this.tenDVT = tenDVT;
        }

        public DonViTinhDTO()
        {

        }

        public string MaDVT { get => maDVT; set => maDVT = value; }
        public string TenDVT { get => tenDVT; set => tenDVT = value; }

        public DonViTinhDTO(DataRow row)
        {
            this.MaDVT = row["MaDVT"].ToString();
            this.TenDVT = row["TenDVT"].ToString();
        }
    }
}



