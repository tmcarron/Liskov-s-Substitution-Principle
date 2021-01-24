using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle
{
    class Banana : Fruit
    {
        public Banana()
        {
            OrderNumber = 2;
            Name = "Banana";
            Color = "Yellow";
            Price = .6;
        }
    }
}
