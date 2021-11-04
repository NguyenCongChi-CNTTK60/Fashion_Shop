using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace DTO
{
    public class UnitDTO
    {
        private string maDVTinh;
        private string tenDVTinh;
        public UnitDTO(string maDVTinh, string tenDVTinh)
        {
            this.maDVTinh = maDVTinh;
            this.tenDVTinh = tenDVTinh;
        }

        public UnitDTO()
        {

        }
        public string MaDVTinh { get => maDVTinh; set => maDVTinh = value; }
        public string TenDVTinh { get => tenDVTinh; set => tenDVTinh = value; }

        public UnitDTO(DataRow row)
        {
            this.MaDVTinh = row["MaDVT"].ToString();
            this.TenDVTinh = row["TenDVT"].ToString();
        }
    }
}



