using System;

namespace Strategy
{
    public class NoSwim : ISwim
    {
        public void Execute()
        {
            Console.WriteLine("Утка не плавает");
        }
    }
}
