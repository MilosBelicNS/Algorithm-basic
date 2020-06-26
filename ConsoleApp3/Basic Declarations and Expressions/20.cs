using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Basic_Declarations_and_Expressions
{
    class _20
    {
        //Write C# program to find the longest word in a string
        static void Main ()
        {
            string line = "Write a C# program to display the following pattern using the";
            string[] words = line.Split(new[] { " " }, StringSplitOptions.None);
            string word = "";
            int ctr = 0;

            foreach(String s in words)
            {
                if(s.Length > ctr)
                {
                    word = s;
                    ctr = s.Length;
                }
            }
            Console.WriteLine(word);
            Console.ReadKey();
        }

    }
}
