using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class FibonacciSeries
    {
        public static void Fibonacci_Recurrsion(int len)
        {
            int previousToPrevious = 0, previous = 1, next = 0;
            Console.Write("{0} {1}", previousToPrevious, previous);
            for (int i = 2; i < len; i++)
            {
                next = previousToPrevious + previous;
                Console.Write(" {0}", next);
                previousToPrevious = previous;
                previous = next;
            }
        }
    }
}
