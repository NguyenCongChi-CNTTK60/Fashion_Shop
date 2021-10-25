using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CommodityDTO
    {
        private string maHang, tenHang, donVi;
        private int soLuong, giaBan, giaGoc;

        public CommodityDTO()
        {

        }
        public CommodityDTO(DataRow row)
        {
            this.MaHang = row["MaHang"].ToString();
            this.TenHang = row["TenHang"].ToString();
            this.SoLuong = (int)row["SoLuong"];
            this.GiaBan = int.Parse(row["GiaBan"].ToString());
            this.DonVi = row["DonVi"].ToString();
            this.GiaGoc = int.Parse(row["GiaGoc"].ToString());
        }

        public string MaHang { get => maHang; set => maHang = value; }
        public string TenHang { get => tenHang; set => tenHang = value; }
        public string DonVi { get => donVi; set => donVi = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int GiaBan { get => giaBan; set => giaBan = value; }
        public int GiaGoc { get => giaGoc; set => giaGoc = value; }
    }
}
