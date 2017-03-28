using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmApplication
{
    public class Farm
    {
        public int FeedAmount { get; set; }
        public List<IAnimal> Animals { get; set; }
        public int Meat { get; set; }

        public Farm(int feed)
        {
            FeedAmount = feed;
        }

        public int NumberOfAnimals()
        {
            return Animals.Count;
        }

        public void FeedAnimals()
        {
            foreach (IAnimal animal in Animals)
            {
                FeedAmount -= animal.FeedConsumed();
            }
        }

        public int SlaugterAnimals()
        {
            int meatGained = 0;
            for(int i = 0; i<Animals.Count; i++)
            {
                meatGained += Animals[i].SlaughterValue();
            }
            Animals.Clear();
            return meatGained;
        }
    }
}
