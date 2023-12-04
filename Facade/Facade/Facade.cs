using System;

namespace Facade
{
    public class Facade
    {
        private DVD _dvd;
        private TV _tv;
        private Audio _audio;

        public Facade(DVD dvd, TV tv, Audio audio)
        {
            _dvd = dvd;
            _tv = tv;
            _audio = audio;
        }

        public void On()
        {
            Console.WriteLine("\nВлючение домашнего кинотеатра");
            _tv.On();
            _dvd.In();
            _audio.On();
            _dvd.Play();
        }

        public void Off()
        {
            Console.WriteLine("\nВыключение домашнего кинотеатра");
            _dvd.Out();
            _audio.Off();
            _tv.Off();
        }
    }
}
