using System;

namespace Strategy
{
    public class Swim : ISwim
    {
        public void Execute()
        {
            Console.WriteLine("Утка умеет плавать");
        }
    }
}
