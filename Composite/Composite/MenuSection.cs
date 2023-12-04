using System;
using System.Collections.Generic;

namespace Composite
{
    internal class MenuSection : MenuComponent
    {
        private List<MenuComponent> _menuComponents = new List<MenuComponent>();

        public MenuSection(string name)
            : base(name)
        { }

        public override void Add(MenuComponent component)
        {
            if (component == null)
            {
                throw new ArgumentNullException(nameof(component), "Ошибка null ");
            }
            _menuComponents.Add(component);
        }

        public override void Remove(MenuComponent component)
        {
            if (component == null)
            {
                throw new ArgumentNullException(nameof(component), "Ошибка null ");
            }
                
            _menuComponents.Remove(component);
        }

        public override void Print()
        {
            Console.WriteLine(name);

            foreach (MenuComponent component in _menuComponents)
            {
                component.Print();
            }
        }
    }
}
