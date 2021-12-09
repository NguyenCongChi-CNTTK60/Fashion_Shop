using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GiamGiaDTO
    {
        private string maGG;
        private int phanTram;
       

        public GiamGiaDTO()
        {
        }

        public GiamGiaDTO(DataRow row)
        {
            this.MaGG = row["MaGG"].ToString();         
            this.PhanTram = (int)row["PhanTram"];
        }

        public string MaGG { get => maGG; set => maGG = value; }
        public int PhanTram { get => phanTram; set => phanTram = value; }
    }
}
