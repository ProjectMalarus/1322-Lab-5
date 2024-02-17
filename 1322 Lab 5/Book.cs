using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1322_Lab_5
{
    internal class Book : Item
    {
        private int isbn_number;
        private string author;
        private string title;

        public void setISBN(int num)
        {
            isbn_number = num;
        }
        public int getISBN()
        {
            return isbn_number;
        }

        public void setAuthor(string a)
        {
            author = a;
        }

        public string getAuthor()
        {
            return author;
        }

        public Book()
        {
            isbn_number = 0000000000000;
            author = "Malachi Uzowihe";
            title = string.Empty;
        }

        public Book(int num, string name, string t)
        {
            isbn_number = num;
            author = name;
            title = t;
        }

        public override string getListing()
        {
            return "Book Name - " + title + "\n" + "Author - " + getAuthor() + "\n" + "ISBN# - " + getISBN();
        }
        
    }
}
