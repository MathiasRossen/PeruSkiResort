using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PeruSkiResort
{
    class Slope
    {

        public string Name { get; set; }
        List<Skier> skiersOnSlope;

        public List<Skier> SkiersOnSlope
        {
            get
            {
                return skiersOnSlope;
            }
            set
            {
                skiersOnSlope = value;
            }
        }

        public char Peak { get; set; }
        public char Bottom { get; set; }

        public Slope(string name, char peak, char bottom)
        {
            Name = name;
            skiersOnSlope = new List<Skier>();
            Peak = peak;
            Bottom = bottom;
        }

        public void Run()
        {
            while (true)
            {

            }
        }

        public void AddSkiersToSlope(List<Skier> skiersToAdd)
        {
            foreach(Skier skier in skiersToAdd)
            {
                skier.Location = Peak;
                skiersOnSlope.Add(skier);
            }
        }
    }
}
