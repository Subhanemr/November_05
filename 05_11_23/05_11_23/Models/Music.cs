using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_11_23.Models
{
    internal class Music
    {
        public int MusicId { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public int CategoryId { get; set; }
    }
}
