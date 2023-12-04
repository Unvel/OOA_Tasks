using System;

namespace Facade
{
    public class TV
    {
        public void On()
        {
            Console.WriteLine("Телевизор включен");
        }

        public void Off()
        {
            Console.WriteLine("Телевизо выключен");
        }

        public void Mode()
        {
            Console.WriteLine("Канал переключен");
        }
    }
}
