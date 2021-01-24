﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle
{
    class Grapefruit : Fruit
    {
        public Grapefruit()
        {
            OrderNumber = 3;
            Name = "Grapefruit";
            Color = "Pink";
            Price = 1;
        }
    }
}
