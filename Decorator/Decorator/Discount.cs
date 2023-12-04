using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Discount : DishCoffeeDecorator
    {
        public Discount(Coffee coffee) : base(coffee, (coffee.Price() * -0.15), " + скидка")
        {
        
        }
    }
}
