using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeruSkiResort
{
    class Skier
    {
        public string Name { get; set; }
        public char Location { get; set; }

        public Skier(int id, char location)
        {
            Name = "Skier #" + id;
            Location = location;
        }
    }
}
