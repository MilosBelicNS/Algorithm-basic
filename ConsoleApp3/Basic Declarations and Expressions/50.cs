using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Basic_Declarations_and_Expressions
{
    class _50
    {
        //Write a C# program to get the century from a year.

            public static int Godina(int year)
        {
            return (int)(year / 100) + ((year % 100 == 0) ? 0 : 1);
        }


        public static void Main()
        {
            //Console.WriteLine(Godina(1799) == 18);
            //Console.WriteLine(Godina(1900) == 19);
            //Console.WriteLine(Godina(1901) == 19);
            //Console.WriteLine(Godina(1901) == 20);
            //Console.WriteLine(Godina(1806) == 19);
            //Console.WriteLine(Godina(1568) == 20);
            //Console.WriteLine(Godina(2010) == 21);
            //Console.ReadKey();

            //drugi nacin sa klasom Math daleko brzi
            Console.WriteLine("Enter a year");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Ceiling(a / 100));
            Console.ReadKey();
        }
    }
}
