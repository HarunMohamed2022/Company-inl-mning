using Company.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Data.Entities
{
    public class Företag : IEntity
    {
        public int id { get ; set ; }
        [MaxLength(80), Required]
        public string? Name { get; set; }
        public int OrgNum { get; set; }
        public virtual ICollection<Avdelning>? Avdelningar { get; set; }
    }
}
