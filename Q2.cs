using System;
using System.Linq;
using System.Text.RegularExpressions;
namespace RegexTask{
class Q2
{
        static void Main(string[] args)
        {
            string[] testCases = {
            "CPP Exercises.",
            "C# syntax is highly expressive, yet it is also simple and easy to learn.",
            "C# is an elegant and type-safe object-oriented language"
        };
            foreach (string data in testCases)
            {
                Console.WriteLine($"Text: {data}\nAverage Length: {AverageSentenceLenght(data)}");
            }
        }
    static double AverageSentenceLenght(string input)
    {
        int lettersLenght = (Regex.Replace(input, @"[^A-Za-z]", "").Length);
        int countWords = Regex.Split(input, @"\W+").Count(x => !string.IsNullOrWhiteSpace(x));
        return Math.Round((double)lettersLenght / countWords, 2);
    }
    }
}
