using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlurlExample.API.Models
{
    public class NamedAPIResourceList
    {
        public int Count { get; set; }
        public string Next { get; set; }
        public string Previous { get; set; }
        public NamedAPIResource[] Results { get; set; }
    }
}
