using Company.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Data.Entities
{
    public class Avdelning : IEntity
    {
        public int id { get ; set ; }

        [MaxLength(80), Required]
        public string? Name { get ; set ; }
        public int Företagid { get ; set ; }

        public virtual ICollection<Företag>? Företags { get; set; }
        public virtual ICollection<Anställd>? Anställds { get; set; }

    }
}
