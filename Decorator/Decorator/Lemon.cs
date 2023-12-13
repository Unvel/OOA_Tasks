namespace Decorator
{
    public class Lemon : DishCoffeeDecorator
    {
        public Lemon(Coffee coffee) : base(coffee, 2, " + лемон")
        { 
        
        }
    }
}
