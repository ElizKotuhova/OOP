using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Flowers : Plants, Interface1
    {
        public override void care()
        {
            throw new NotImplementedException();
        }

        public void priming()
        {
            throw new NotImplementedException();
        }
    }
}
