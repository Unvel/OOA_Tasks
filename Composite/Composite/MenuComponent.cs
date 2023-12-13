using System;

namespace Composite
{
    internal abstract class MenuComponent
    {
        protected string name;

        public MenuComponent(string name)
        {
            this.name = name;
        }

        public virtual void Add(MenuComponent component) {

        }

        public virtual void Remove(MenuComponent component) {
        
        }

        public virtual void Print()
        {
            Console.WriteLine(name);
        }
    }
}


