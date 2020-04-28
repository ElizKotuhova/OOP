using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Plants : Attribute
    {
        public string Name { set; get; }
        public string Type;
        public int size;

        public abstract void Care();

        public void gettype()
        {
            Console.WriteLine(Type);
        }

        internal static object a(Plants arg)
        {
            throw new NotImplementedException();
        }
    }
}
