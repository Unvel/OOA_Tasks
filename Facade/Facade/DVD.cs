using System;

namespace Facade
{
    public class DVD
    {
        public void In()
        {
            Console.WriteLine("Диск вставлен");
        }

        public void Out()
        {
            Console.WriteLine("Диск извлечен");
        }

        public void Play()
        {
            Console.WriteLine("Диск проигрывается");
        }
    }
}
