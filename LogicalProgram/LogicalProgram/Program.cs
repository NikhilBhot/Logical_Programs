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

                PerfectNumber.isPerfectNumber();
             */

            //Program-3-Prime Number
            /*
                Just like the Perfect number, the Prime number is also a special type of number. When
                the number is divided greater than 1 and divided by 1 or itself is referred to as the Prime
                number. 0 and 1 are not counted as prime numbers. All the even numbers can be
                divided by 2, so 2 is the only even prime minister.
                
                PrimeNumber.primeNumber();
             */

            /*
             In C#, we can reverse a number either by using for loop, while loop, or using recursion.
             The simplest way to reverse a number is by using for loop or while loop. In order to
             reverse a number, we have to follow the following steps:
             a. We need to calculate the remainder of the number using the modulo
             b. After that, we need to multiply the variable reverse by 10 and add the remainder into it.
             c. We then divide the number by 10 and repeat steps until the number becomes 0.
             */

            ReverseNumber.reverseNumber();


        }
    }
}