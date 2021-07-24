using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace countries.Models
{
    public class country
    {
        public string countryName { get; set; }
        public string languageName { get; set; }
        public DateTime createdDate { get; set; } = DateTime.Now;
    }
}
