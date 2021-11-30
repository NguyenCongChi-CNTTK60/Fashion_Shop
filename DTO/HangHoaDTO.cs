using System.Data;

namespace DTO
{
    public class HangHoaDTO
    {
        private string maMH, tenMH, donVi;
        private int soLuong, giaBan, giaGoc;

        public HangHoaDTO()
        {

        }
        public HangHoaDTO(DataRow row)
        {
            this.MaMH = row["MaMH"].ToString();
            this.TenMH = row["TenMH"].ToString();
            this.SoLuong = (int)row["SoLuong"];
            this.GiaBan = int.Parse(row["GiaBan"].ToString());
            this.DonVi = row["DonVi"].ToString();
            this.GiaGoc = int.Parse(row["GiaGoc"].ToString());
        }

        public string MaMH { get => maMH; set => maMH = value; }
        public string TenMH { get => tenMH; set => tenMH = value; }
        public string DonVi { get => donVi; set => donVi = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int GiaBan { get => giaBan; set => giaBan = value; }
        public int GiaGoc { get => giaGoc; set => giaGoc = value; }
    }
}

