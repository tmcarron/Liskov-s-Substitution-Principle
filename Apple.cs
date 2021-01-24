using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle
{
    class Apple : Fruit
    {
        public Apple()
        {
            OrderNumber = 1;
            Name = "Apple";
            Color = "Red";
            Price = .5;
        }
    }
}
