using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Coniferous : Plants, Interface1
    {
        public int v;
        public string v1;

        public Coniferous(int v)
        {
            this.v = v;
        }

        public Coniferous(string v1)
        {
            this.v1 = v1;
        }

        public void priming()
        {
            throw new NotImplementedException();
        }
        public override void Care()
        {
            throw new NotImplementedException();
        }
    }
}
