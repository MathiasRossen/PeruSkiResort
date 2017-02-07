using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeruSkiResort
{
    class LiftCabin
    {
        List<Skier> skierCollection;

        public List<Skier> SkierCollection { get; }
        public string Label { get; set; }
        public char Peak { get; set; }
        public char Bottom { get; set; }

        public LiftCabin(int id, char peak, char bottom)
        {
            skierCollection = new List<Skier>();
            Label = "Cabin #" + id;
            Peak = peak;
            Bottom = bottom;
        }

        public void FillCabin(List<Skier> skiersToAdd)
        {
            skierCollection = skiersToAdd;
        }

        public void EmptyCabin()
        {
            skierCollection.Clear();
        }

    }
}
