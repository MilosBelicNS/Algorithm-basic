using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Basic_Declarations_and_Expressions
{
    class _39
    {

        //Write a C# program to check if a given string starts with "w" and immediately followed by two "ww".

        public static void Main()
        {

            Console.Write("Input a string : ");
            string str = Console.ReadLine();
            Console.WriteLine(Provera(str));
            Console.ReadKey();
        }

        public static bool Provera(string str)
        {
            var ctr = 0;
            for (var i = 0; i < str.Length - 1; i++)
            {
                if (str[i].Equals('w')) ctr++;
                if (str.Substring(i, 2).Equals("ww") && ctr > 2)
                    return true;
            }
            return false;
        }
                  //drugi nacin       
             /*  static void Main(string[] args)
               {
               Console.Write("Input a string : ");
               string str = Console.ReadLine();
               Console.WriteLine(test(str));
               }
               public static bool test(string str)
               {
               if (str[0].Equals('w') && str.Substring(1, 2).Equals("ww"))
               return true;
               return false;
               }
               }       */        

    }

}
 