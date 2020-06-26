using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Basic_Declarations_and_Expressions
{
    class _24
    {
        //Write a C# program to reverse the words of a sentence. Go to the editor
        //Sample Output:
        //Original String: Display the pattern like pyramid using the alphabet.
        //Reverse String: alphabet.the using pyramid like pattern the Display

        public static void Main ()
        {
            string line = "Display the pattern like pyramid using the alphabet. ";
                Console.WriteLine("\n Original String : " + line);
            string result = "";
            List<string> wordsList = new List<string>();
            string[] words = line.Split(new []
            { " "

            }, StringSplitOptions.None);
            for(int i = words.Length - 1; i >= 0; i--)
            {
                result += words[i] + " ";
            }
            wordsList.Add(result);
            foreach(String s in wordsList)
            {
                Console.WriteLine("\n Reverse String: " + s);
                Console.ReadKey();
            }

        }
    }
}
