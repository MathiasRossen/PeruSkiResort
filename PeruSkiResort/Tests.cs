using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PeruSkiResort
{
    [TestClass]
    public class Tests
    {
        int numberOfSkiers = 300;

        List<Skier> liftQueue;
        List<LiftCabin> liftAB1;
        Slope slopeAB1;

        [TestInitialize]
        public void Setup()
        {
            liftQueue = new List<Skier>();
            liftAB1 = new List<LiftCabin>();
            slopeAB1 = new Slope("SlopeAB1", 'A', 'B');
            
            for(int i = 0; i < numberOfSkiers; i++)
            {
                liftQueue.Add(new Skier(i + 1, 'B'));
            }

            for(int y = 0; y < 5; y++)
            {
                liftAB1.Add(new LiftCabin(y + 1, 'A', 'B'));
            }
        }
    }
}
