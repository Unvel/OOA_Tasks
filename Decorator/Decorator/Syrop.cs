using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Syrop : DishCoffeeDecorator
    {
        public Syrop(Coffee coffee) : base(coffee, 2, " + сироп")
        { }
    }
}
