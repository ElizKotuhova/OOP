using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
   abstract class Plants
    {
        string type;
        int view;

        public abstract void care();

        public void gettype()
        {
            Console.WriteLine(type);
        }
    }
}
