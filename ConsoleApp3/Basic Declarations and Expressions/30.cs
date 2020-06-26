using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Basic_Declarations_and_Expressions
{
    class _30
    {

         //Write a C# program to check if a string starts with a specified word. Go to the editor
         //Note: Suppose the sentence starts with "Hello"
         //Sample Data: string1 = "Hello how are you?"
         //Result: Hello.
         //Sample Output:
         //Input a string : Hello how are you?
         //True


        public static void Main(string [] args)
        {
            Console.WriteLine("\n Input your string: ");
            string str = Console.ReadLine();
            Console.WriteLine((str.Length < 6 && str.Equals("Hello")) || (str.StartsWith("Hello") && str[5] == ' '));
            Console.ReadKey();

        }

} }
