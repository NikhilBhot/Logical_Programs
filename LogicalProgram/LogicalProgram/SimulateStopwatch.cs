using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class SimulateStopwatch
    {
        public static void simulateStopwatch()
        {
            Stopwatch stopwatch = new Stopwatch();
            // Begin timing
            stopwatch.Start();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("HI");
            }
            // Stop timing
            stopwatch.Stop();
            Console.WriteLine("Time Elapsed : {0}",
                stopwatch.Elapsed);
            Console.ReadLine();
        }
    }
}
