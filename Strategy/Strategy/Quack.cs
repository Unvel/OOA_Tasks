using System;

namespace Strategy
{
    public class Quack : IQuack
    {
        public void Execute()
        {
            Console.WriteLine("Утка крякает");
        }
    }
}
