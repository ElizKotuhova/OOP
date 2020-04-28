using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5 
{
    class Seaweed : Plants
    {
        public int v;
        public string v1;

        public Seaweed(int v, string v1)
        {
            this.v = v;
        }

        public Seaweed(string v1)
        {
            this.v1 = v1;
        }

        public Seaweed(int v)
        {
            this.v = v;
        }

        public override void Care()
        {
            throw new NotImplementedException();
        }
        
    }
}
