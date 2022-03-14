using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace LD2
{
    internal class Class1
    {

        public void MyMethod()
        {

            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            Thread.Sleep(5000);

            double a = 1;
            double b = 2;
            double c = 0;

            while (c <= Math.Pow(10, 15))
            {
                c = a * b;
                b = a;
                a = c;

            }
            Console.WriteLine("Paskutine reiksme: " + c);
            stopwatch.Stop();

            TimeSpan ts = stopwatch.Elapsed;

            Console.WriteLine("Elapsed Time is {0:00}:{1:00}:{2:00}.{3}",
            ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);

        }
        public void SekosNr()
        {
            double a = 1;
            double b = 2;
            double c = 0;
            int d = 0;

            while (c <= Math.Pow(10, 15))
            {
                c = a * b;
                b = a;
                a = c;
                d = d + 1;
            }
            Console.WriteLine("Sekos nr: " + d);
        }

    }

}
    


