using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    abstract class Plants
    {
        public string type;
        public int size;

        public abstract void Care();

        public void gettype()
        {
            Console.WriteLine(type);
        }

        internal static object a(Plants arg)
        {
            throw new NotImplementedException();
        }
    }
}
