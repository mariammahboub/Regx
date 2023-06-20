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
                Console.WriteLine($"Text: {data}\nAverage Length: {CalculateAverageLength(data)}");
            }
        }
        public static double CalculateAverageLength(string data)
        {
            return Math.Round(Regex.Replace(data, "[^A-Za-z ]", "")
                                    .Split(' ')
                                    .Select(word => word.Length)
                                    .Average(), 2);
        }
    }
}
