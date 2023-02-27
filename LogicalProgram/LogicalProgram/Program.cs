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
             
               FibonacciSeries.Fibonacci_Recurrsion(5);
            */

            //Program-2-PerfectNumber
            /*
                a. Just like the Armstrong number, the Perfect Number is also a special type of
                ositive number. When the number is equal to the sum of its positive divisors
                excluding the number, it is called a Perfect Number. For example, 28 is the perfect
                number because when we sum the divisors of 28, it will result in the same number.
                The divisors of 28 are 1, 2, 4, 7, and 14. So,
                
                b. 28 = 1+2+4+7
                c. 28 = 28
             */

            PerfectNumber.isPerfectNumber();
        }
    }
}