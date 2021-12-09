using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiHangDTO
    {
        string maLH, tenLH;

        public LoaiHangDTO(DataRow row)
        {
            this.MaLH = row["MaLH"].ToString();
            this.TenLH = row["TenLH"].ToString();
        }

        public string MaLH { get => maLH; set => maLH = value; }
        public string TenLH { get => tenLH; set => tenLH = value; }
    }
}
