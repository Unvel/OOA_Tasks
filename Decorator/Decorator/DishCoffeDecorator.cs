using System;

namespace Decorator
{
    public class DishCoffeeDecorator : Coffee
    {
        private Coffee _coffee;


        public DishCoffeeDecorator(Coffee coffee, double adishPrice, string adishExtra)
            : base(adishPrice, adishExtra)
        {
            if (coffee == null)
            {
                throw new ArgumentNullException(nameof(coffee), "Ошибка null ");
            }
                
            _coffee = coffee;
        }

        public override double Price()
        {
            return _coffee.Price() + base.Price();
        }

    }
}
