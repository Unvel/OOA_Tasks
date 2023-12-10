using System;

namespace Strategy
{
    public class NoQuack : IQuack
    {
        public void Execute()
        {
            Console.WriteLine("Утка не умеет крякать");
        }
    }
}
