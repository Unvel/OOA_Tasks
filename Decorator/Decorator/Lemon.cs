using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Lemon : DishCoffeeDecorator
    {
        public Lemon(Coffee coffee) : base(coffee, 2, " + лемон")
        { 
        
        }
    }
}
