﻿using System;

namespace TemplateMethod
{
    public class Tea : Drink
    {
        protected override void Brew()
        {
            Console.WriteLine("Завариваем чай");
        }
        protected override void AddСomponents()
        {
            Console.WriteLine("Добавляем лимон");
        }
    }
}
