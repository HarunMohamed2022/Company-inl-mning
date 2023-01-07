using Company.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Data.Entities
{
    public class Anställd : IEntity
    {
        public int id { get ; set ; }

        [MaxLength(80), Required]
        public string? FörNamn { get ; set ; }

        [MaxLength(80), Required]
        public string? EfterNamn { get; set; }

        public int Avdelningid { get; set ; }
        public decimal? Lön { get; set ; }

        public bool? Fackförening { get; set ; }
        public virtual ICollection<Avdelning>? Avdelnings { get; set; }
        public virtual ICollection<AnställdBefattningar>? AnställdBefattningars { get; set; }
    }
}
