using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace ConsoleApp5
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Seaweed> a = new List<Seaweed>();

            Seaweed v2 = new Seaweed(10, "T1");
            Seaweed v3 = new Seaweed(30, "T2");
            Seaweed v4 = new Seaweed(35, "T2");

            a.Add(v2);
            a.Add(v3);
            a.Add(v4);


            int v = a.Where(x => (x.v >= 15) && (x.v1 == "T2")).Count();

            Console.WriteLine(v);




        }
    }
}
