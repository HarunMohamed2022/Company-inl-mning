using Company.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Data.Entities
{
    public class AnställdBefattningar : IReferenceEntity
    {
        public int Anställdid { get ; set ; }
        public int Befattningid { get; set; }

        public virtual ICollection<Anställd>? Anställds { get; set; }
        public virtual ICollection<Beffatning>? Beffatnings { get; set; }



    }
}
