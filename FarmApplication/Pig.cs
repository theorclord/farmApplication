using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmApplication
{
    public class Pig : IAnimal
    {
        public int Age { get; set; }
        private int appetite = 2;
        public int FeedConsumed()
        {
            return appetite*Age;
        }

        public int SlaughterValue()
        {
            return Age * 10;
        }
    }
}
