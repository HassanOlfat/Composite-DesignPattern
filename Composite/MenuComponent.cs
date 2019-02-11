using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Composite
{
   public abstract  class MenuComponent
   {
       protected readonly string URL;
       protected readonly string Title;
    

       public MenuComponent(string url, string title)
        {
            URL = url;
            Title = title;
        }

       public abstract MenuComponent Add(MenuComponent menuComponent);
       public abstract MenuComponent Remove(MenuComponent menuComponent);
       public abstract void Print(int depth);

        public string GetURL()
       {
           return URL;
       }
       public string GetTitle()
       {
           return Title;
       }




   }
}
