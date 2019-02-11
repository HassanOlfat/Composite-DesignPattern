using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    class MenuItem : MenuComponent
    {
        public MenuItem(string url, string title) : base(url, title)
        {
        }

        public override MenuComponent Add(MenuComponent menuComponent)
        {
            throw new NotSupportedException();
        }

        public override MenuComponent Remove(MenuComponent menuComponent)
        {
            throw new NotSupportedException();
        }

        public override void Print(int depth)
        {
           Console.WriteLine(new string('-', depth)+Title);

        }

       
    }
}
