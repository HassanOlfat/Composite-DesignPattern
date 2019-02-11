using System;
using System.Collections.Generic;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu root = new Menu("\\root", "root",
                new List<MenuComponent>
            {
                new MenuItem("\\menu 1", "menu 1"),
                new MenuItem("\\menu 2", "menu 2"),

                new Menu("\\product", "product",new List<MenuComponent>()
                {
                    new MenuItem("\\Software", "Software"),
                    new MenuItem("\\Hardware", "Hardware")
                }),
                new Menu("\\About", "About"),
                
                
            });
            root.Print(1);
           
            Console.ReadKey();

        }
    }
}
