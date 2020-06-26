using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Basic_Declarations_and_Expressions
{
    class _34
    {
        //Write a C# program to get a new string of two characters from a given string. The first and second character of the given string must be "P" and "H", so PHP will be "PH". Go to the editor
        //Test Data: PHP
        //Sample Output:
        //PH

        public static void Main (string [] args)
        {
            //string str = "PkP Tutorial";
            //Console.WriteLine((str.Substring(0, 1).Equals("P") || str.Substring(1, 1).Equals("H") ? str.Substring(0,2) : str));
            //Console.ReadKey();

            //Console.ReadKey();

            string str1 = "PHP Tutorial";
            var result = "";

            if (str1.Length >= 1 && str1[0] == 'P')
                result += str1[0]; // na svaki string kada dodajemo jedan karakter mora da pise +, sa plusom mi dodajemo taj karakter
            if (str1.Length >= 2 && str1[1] == 'H')
                result += str1[1];
            Console.WriteLine(result);
            Console.ReadKey();
        }

    }
}
