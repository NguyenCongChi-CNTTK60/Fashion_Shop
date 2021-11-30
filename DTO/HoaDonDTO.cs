using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonDTO
    {
        private string maHD, maKH, maNV;
        private DateTime ngayTao;
        private int tongTien;

        public HoaDonDTO()
        {

        }

        public string MaHD { get => maHD; set => maHD = value; }
        public string MaKH { get => maKH; set => maKH = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public DateTime NgayTao { get => ngayTao; set => ngayTao = value; }
        public int TongTien { get => tongTien; set => tongTien = value; }
    }
}