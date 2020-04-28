using NLog;
using NLog.Fluent;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Threading.Tasks.Dataflow;

namespace ConsoleApp5
{
    class Program
    {
        private static Logger NLog = LogManager.GetCurrentClassLogger();

        [Plants(Name = "Elizaveta Kotuhova")]
        static void Main(string[] args)
        {

            try
            {
                int v = int.Parse(Console.ReadLine());
            }
            catch (FormatException v)
            {
                NLog.Debug("FormatException {0}", v.Source);
            }





            //List<Seaweed> a = new List<Seaweed>();

            //Seaweed v2 = new Seaweed(10, "T1");
            //Seaweed v3 = new Seaweed(30, "T2");
            //Seaweed v4 = new Seaweed(35, "T2");

            //a.Add(v2);
            //a.Add(v3);
            //a.Add(v4);

            //var v = a.Where(x => (x.v >= 15) && (x.v1 == "T2")).Count();

            //Console.WriteLine(v);




        }
    }
}
