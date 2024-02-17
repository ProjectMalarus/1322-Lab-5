using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1322_Lab_5
{
    internal abstract class Item
    {
        private string title;

        public Item()
        {
            title = string.Empty;
        }

        public Item(string t)
        {
            title = t;
        }
        public string getTitle()
        {
            return title; 
        }

        public void setTitle(string t)
        {
            title = t;
        }

        public abstract string getListing();

        public override string ToString()
        {
            return getTitle();
        }
    }
}
