using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Sugar : DishCoffeeDecorator
    {
        public Sugar(Coffee coffee) : base(coffee, 1, " + сахар")
        { 
        
        }

    }
}
