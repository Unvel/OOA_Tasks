using System;

namespace Facade
{
    public class Audio
    {
        public void On()
        {
            Console.WriteLine("Аудио включено");
        }

        public void Off()
        {
            Console.WriteLine("Аудио выключено");
        }
    }
}
