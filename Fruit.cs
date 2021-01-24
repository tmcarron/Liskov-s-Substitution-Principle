using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle
{
    //abstract class defining the characteristics of fruit
    public abstract class Fruit
    {
        public int OrderNumber { get; set; }
        public string Name { get; set; }

        public string Color { get; set; }

        public double Price { get; set; }

        public string GetFruitInfo()
        {
            return $"{OrderNumber}: Name: {Name} | Color: {Color} | Price: ${Price}";
        }


    }
}
