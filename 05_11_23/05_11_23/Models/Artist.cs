using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_11_23.Models
{
    internal class Artist
    {
        public int ArtistId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; } = "XXX";
        public DateTime? Birthday { get; set; }
        public string Gender { get; set; }
    }
}
