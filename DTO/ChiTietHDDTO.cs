using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietHDDTO
    {
        private string maHD, maHang;
        private int soLuong, donGia;

        public ChiTietHDDTO(string maHD, string maHang, int soLuong, int donGia)
        {
            this.MaHD = maHD;
            this.MaHang = maHang;
            this.SoLuong = soLuong;
            this.DonGia = donGia;
        }

        public string MaHD { get => maHD; set => maHD = value; }
        public string MaHang { get => maHang; set => maHang = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int DonGia { get => donGia; set => donGia = value; }
    }
}

