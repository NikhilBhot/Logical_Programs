namespace LogicalProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Logical Programmin");

            //Program-1-FibonacciSeries
            /*
               Fibonacci series is a special type of series in which the next term is the sum of the
               previous two terms. For example, if 0 and 1 are the two previous terms in a series, then
               the next term will be 1(0+1).
             */

            FibonacciSeries.Fibonacci_Recurrsion(5);
        }
    }
}