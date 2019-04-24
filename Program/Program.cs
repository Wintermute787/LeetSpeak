using System;

namespace LeetSpeak
{
    class Program
    {
        static void Main()
        {
            LeetSpeak word = new LeetSpeak();
            Console.WriteLine("Enter a word: ");
            string userOutput = Console.ReadLine();
            string result = word.LeetSpeakTranslator(userOutput);
            Console.WriteLine(result);
            



        }
    }
}
