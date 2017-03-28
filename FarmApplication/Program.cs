using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Farm SvennesFarm = new Farm(5000);
            SvennesFarm.Animals = new List<IAnimal>();
            SvennesFarm.Animals.Add(new Pig() { Age = 1 });
            SvennesFarm.Animals.Add(new Pig() { Age = 4 });
            SvennesFarm.Animals.Add(new Cow() { Type = Cow.CowType.Meat });
            SvennesFarm.Animals.Add(new Cow() { Type = Cow.CowType.Milk });

            Console.WriteLine("Number of animals alive " + SvennesFarm.NumberOfAnimals());
            Console.WriteLine("Amount of food left " + SvennesFarm.FeedAmount);
            for(int i = 0; SvennesFarm.FeedAmount> 100; i++)
            {
                SvennesFarm.FeedAnimals();
            }
            Console.WriteLine("Amount of food left " + SvennesFarm.FeedAmount);

            Console.WriteLine("Meat gained " + SvennesFarm.SlaugterAnimals());
            Console.ReadKey();
        }
    }
}
