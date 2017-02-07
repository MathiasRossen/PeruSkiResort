using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PeruSkiResort
{
    class Program
    {
        int numberOfSkiers = 300;
        List<Skier> liftQueue = new List<Skier>();
        List<LiftCabin> liftAB1 = new List<LiftCabin>();
        Slope slopeAB1 = new Slope("slopeAB1", 'A', 'B');

        Random rand = new Random();

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Run();
        }

        private void Run()
        {
            Boot();

            
        }

        private void Boot()
        {
            for(int i = 0; i < numberOfSkiers; i++)
            {
                liftQueue.Add(new Skier(i + 1, 'B'));
            }

            for(int i = 0; i < 5; i++)
            {
                liftAB1.Add(new LiftCabin(i + 1, 'A', 'B'));
            }
        }

        private void RunLift()
        {
            int currentLift = 0;

            while (true)
            {
                Console.WriteLine("{0} has been filled and is ready to go up!", liftAB1[currentLift].Label);
                liftAB1[currentLift].FillCabin(liftQueue.GetRange(0, 25));
                liftQueue.Sort();
                Thread.Sleep(2000);
                currentLift = NextLift(currentLift);
            }
        }

        private void EmptyLiftAtPeak()
        {
            int currentLift = 4;

            while (true)
            {
                Console.WriteLine("{0} has been emptied and put at: {1}", liftAB1[currentLift].Label, liftAB1[currentLift].Peak);
                slopeAB1.AddSkiersToSlope(liftAB1[currentLift].SkierCollection);
                liftAB1[currentLift].EmptyCabin();
                Thread.Sleep(2000);
                currentLift = NextLift(currentLift);
            }
        }

        private int NextLift(int currentLift)
        {
            if (currentLift > 4)
                return 0;
            return currentLift;
        }

        private void AddSkiersToQueue(List<Skier> skiers)
        {
            foreach(Skier skier in skiers)
            {
                liftQueue.Add(skier);
            }
        }
    }
}
