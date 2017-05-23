using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interviews
{
    class RunAtConsole
    {
        public const String testString = "";

        static void Main(string[] args)
        {
            String testRemoveChars = StringManipulation.RemoveChars(testString, "aeiou");
            Console.WriteLine(testRemoveChars);

            int testWordCount = StringManipulation.WordCount(testString);
            Console.WriteLine(testWordCount);

            Console.ReadLine();
        }
    }
}
