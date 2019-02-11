using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    class Menu : MenuComponent
    {
        protected List<MenuComponent> Children = new List<MenuComponent>();
        public Menu(string url, string title) : base(url, title)
        {
        }
        public Menu(string url, string title ,IEnumerable<MenuComponent> components) : base(url, title)
        {
            foreach (var item in components)
            {
                Add(item);
            }
        }
        public sealed override MenuComponent Add(MenuComponent menuComponent)
        {
            Children.Add(menuComponent);
            return this;
        }
        public override MenuComponent Remove(MenuComponent menuComponent)
        {
            Children.Remove(menuComponent);
            return this;
        }

        public override void Print(int depth)
        {
            Console.WriteLine(new string('-',depth) + Title);
            foreach (var item in Children)
            {
                item.Print(depth+2);
            }
        }

       
    }
}
