namespace Decorator
{
    public class Sugar : DishCoffeeDecorator
    {
        public Sugar(Coffee coffee) : base(coffee, 1, " + сахар")
        { 
        
        }

    }
}
