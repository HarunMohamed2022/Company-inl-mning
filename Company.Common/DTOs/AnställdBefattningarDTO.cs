using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Common.DTOs
{
    public  record AnställdBefattningarDTO
    {
        public int Anställdid { get; set; }
        public int Befattningid { get; set; }
        public AnställdBefattningarDTO(int anställdid, int befattningid)
        {
            Anställdid = anställdid;
            Befattningid = befattningid;
        }
    }
}
