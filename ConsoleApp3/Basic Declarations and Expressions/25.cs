using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Basic_Declarations_and_Expressions
{
    class _25
    {
        //Write a C# program to find the size of a specified file in bytes. Go to the editor
        //Sample Output:
        //Size of a file: 31

        public static void Main ()
        {
            FileInfo f = new FileInfo("/desktop/Hans.txt");
           // Console.WriteLine("\n Size of a file: " + f.Length.ToString());
            Console.WriteLine("\nSize of a file: " + f.Length.ToString());

            Console.ReadKey();
        }


    }
}
