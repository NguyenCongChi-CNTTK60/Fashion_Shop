using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CaLamViecDTO
    {
        string maclv, ca;

        public CaLamViecDTO(DataRow row)
        {

            this.Maclv = row["MaCLV"].ToString();
            this.Ca = row["Ca"].ToString();
            
        }


     
        public string Maclv { get => maclv; set => maclv = value; }
        public string Ca { get => ca; set => ca = value; }
    }
}
