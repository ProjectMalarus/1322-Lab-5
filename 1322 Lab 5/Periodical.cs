using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _1322_Lab_5
{
    internal class Periodical : Item
    {
        private int issNum;
        private string title;

        public Periodical()
        {
            issNum = 0;
            title = string.Empty;
        }

        public Periodical(int num, string t)
        {
            issNum = num;
            title = t;
        }

        public int getIssNum()
        {
            return issNum;
        }

        public void setIssNum(int num)
        {
            issNum = num;
        }

        public override string getListing()
        {
            return "Periodical Title - " + title + "\n" + "Issue Number - " + getIssNum();
        }


    }
}
