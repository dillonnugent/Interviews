using System;

namespace Interviews
{
    class RunAtConsole
    {
        static void Main(string[] args)
        {
            String sentence = "Here is a sentence to use as a test case.";
            String charsToRemove = "aeiou.";

            Console.WriteLine("Sentence: " + sentence);
            Console.WriteLine("Characters to remove: " + charsToRemove);

            String result = StringManipulation.RemoveChars(sentence, charsToRemove);
            Console.WriteLine("After characters are removed: " + result);

            int count = StringManipulation.WordCount(sentence);
            Console.WriteLine("Word count: " + count);

            Console.ReadLine();
        }
    }
}