using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Common.DTOs
{
    public record FöretagDTO
    {
        public int id { get; set; }
        public string? Name { get; set; }
        public int OrgNum { get; set; }
    }
}
