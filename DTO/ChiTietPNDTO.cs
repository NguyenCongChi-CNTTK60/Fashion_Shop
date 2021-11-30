using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietPNDTO
    {
        private string maPN, maHang;
        private int soLuong, donGia;

        public ChiTietPNDTO(string maPN, string maHang, int soLuong, int donGia)
        {
            this.MaPN = maPN;
            this.MaHang = maHang;
            this.SoLuong = soLuong;
            this.DonGia = donGia;
        }

        public string MaPN { get => maPN; set => maPN = value; }
        public string MaHang { get => maHang; set => maHang = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int DonGia { get => donGia; set => donGia = value; }
    }
}

