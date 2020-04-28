using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Flowers : Plants, Interface1
    {
        private int v;
        private string v1;

        public Flowers(int v)
        {
            this.v = v;
        }

        public Flowers(string v1)
        {
            this.v1 = v1;
        }

        public override void Care()
        {
            throw new NotImplementedException();
        }

        public void priming()
        {
            throw new NotImplementedException();
        }
    }
}
