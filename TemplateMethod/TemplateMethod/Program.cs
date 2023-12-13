using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Tea tea = new Tea();
            tea.Make();
            Console.ReadLine();
        }
    }
}
