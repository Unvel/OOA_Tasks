using System;

namespace Strategy
{
    public class RandomDuck : Duck
    {
        public RandomDuck() : base(GetRandomFlyBehavior(), GetRandomQuackBehavior(), GetRandomSwimBehavior())
        {

        }

        private static IFly GetRandomFlyBehavior()
        {
            Random random = new Random();
            if (random.Next(2) == 0)
            {
                return new Fly();   
            }
            else
            {
                return new NoFly();
            }
        }

        private static IQuack GetRandomQuackBehavior()
        {
            Random random = new Random();
            if (random.Next(2) == 0)
            {
                return new Quack();   
            }
            else
            {
                return new NoQuack();
            }
        }

        private static ISwim GetRandomSwimBehavior()
        {
            Random random = new Random();
            if (random.Next(2) == 0)
            {
                return new Swim();   
            }
            else
            {
                return new NoSwim();
            }
        }
    }
}
