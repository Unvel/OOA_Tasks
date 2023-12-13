namespace Decorator
{
    public class Syrop : DishCoffeeDecorator
    {
        public Syrop(Coffee coffee) : base(coffee, 2, " + сироп")
        { }
    }
}
