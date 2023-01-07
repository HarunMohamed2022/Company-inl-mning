using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Common.DTOs
{
    public record AnställdDTO
    {
        public int id { get; set; }
        public string? FörNamn { get; set; }

        
        public string? EfterNamn { get; set; }

        public int Avdelningid { get; set; }
        public decimal? Lön { get; set; }

        public bool? Fackförening { get; set; }
    }
}
