using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmApplication
{
    public class Cow : IAnimal
    {
        public enum CowType
        {
            Milk, Meat
        }

        public CowType Type { get; set; }

        public int FeedConsumed()
        {
            switch (Type)
            {
                case CowType.Meat:
                    return 15;
                case CowType.Milk:
                    return 10;
                default:
                    return 0;
            }
        }

        public int SlaughterValue()
        {
            if(Type == CowType.Meat)
            {
                return 200;
            }else
            {
                return 50;
            }
        }
    }
}
