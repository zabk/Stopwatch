using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch
{

    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine(stopwatch.Stop().Seconds);

            stopwatch.Start();
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine(stopwatch.Stop().Seconds);

            stopwatch.Start();
            stopwatch.Start();
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine(stopwatch.Stop().Seconds);

        }
    }
}
