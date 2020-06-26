using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Basic_Declarations_and_Expressions
{
    class _22
    {

        //Write a C# program to compute the sum of the first 500 prime numbers
         //Sample Output:
         //Sum of the first 500 prime numbers:
         //3682913
        public static void Main ()
        {
            Console.WriteLine("\n Sum of the first 500 prime numbers: ");
            long sum = 0;
            int ctr = 0;
            int n = 2; ;

            while(ctr < 500)
            {
                if(isPrime(n))
                {
                    sum += n;
                    ctr++;
                }

                n++;
            }
            Console.WriteLine(sum.ToString());
            Console.ReadKey();



        }
        public static bool isPrime(int n)
        {
            int x = (int)Math.Floor(Math.Sqrt(n));

            if (n == 1) return false;
            if (n == 2) return true;

            for(int i = 2; i <= x; ++i)
            {
                if (n % i == 0) return false;

            }
            return true;
        }
    }
}
