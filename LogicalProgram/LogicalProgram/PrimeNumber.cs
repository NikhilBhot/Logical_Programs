using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class PrimeNumber
    {
        public static void primeNumber()
        {

            int number, i, m = 0, flag = 0;
            Console.Write("Enter the Number to check Prime: ");
            number = int.Parse(Console.ReadLine());
            m = number / 2;
            for (i = 2; i <= m; i++)
            {
                if (number % i == 0)
                {
                    Console.Write("Number is not Prime.");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                Console.Write("Number is Prime.");
            }
        }
    }
}
