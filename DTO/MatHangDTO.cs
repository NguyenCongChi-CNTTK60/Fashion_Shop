using System.Data;

namespace DTO
{
    public class MatHangDTO
    {
 
        private string maMH, tenMH, donVi;
        private int soLuong, giaBan;

        public MatHangDTO()
        {

        }
        public MatHangDTO(DataRow row)
        {
            this.MaMH = row["MaMH"].ToString();
            this.TenMH = row["TenMH"].ToString();
            this.DonVi = row["DonVi"].ToString();
            this.GiaBan = (int)row["GiaBan"];
            this.SoLuong = (int)row["SoLuong"];
        }

        public string MaMH { get => maMH; set => maMH = value; }
        public string TenMH { get => tenMH; set => tenMH = value; }
        public string DonVi { get => donVi; set => donVi = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int GiaBan { get => giaBan; set => giaBan = value; }
    }
}

