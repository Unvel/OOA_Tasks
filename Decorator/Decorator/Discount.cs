namespace Decorator
{
    public class Discount : DishCoffeeDecorator
    {
        public Discount(Coffee coffee) : base(coffee, (coffee.Price() * -0.15), " + скидка")
        {
        
        }
    }
}
