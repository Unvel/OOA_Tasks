using System;

namespace Strategy
{
    public class Fly : IFly
    {
        public void Execute()
        {
            Console.WriteLine("Утка летает");
        }
    }
}
