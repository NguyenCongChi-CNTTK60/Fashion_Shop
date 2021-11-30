using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuNhapDTO
    {
        private string maPN, maNCC, tenDangNhap;
        DateTime ngayNhap;

        public PhieuNhapDTO()
        {

        }
        public string MaPN { get => maPN; set => maPN = value; }
        public string MaNCC { get => maNCC; set => maNCC = value; }
        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        public DateTime NgayNhap { get => ngayNhap; set => ngayNhap = value; }
    }
}