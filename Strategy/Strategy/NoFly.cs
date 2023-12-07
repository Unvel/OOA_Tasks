using System;

namespace Strategy
{
    public class NoFly : IFly
    {
        public void Execute()
        {
            Console.WriteLine("Утка не летает");
        }
    }
}
