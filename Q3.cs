using System;
using System.Linq;
using System.Text.RegularExpressions;
namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] testCases = { "amamd", "pamamd", "ferre" };
            foreach (string text in testCases)
            {
                Console.WriteLine($"Text: {text}\n{palindrome(text)}\n");
            }
        }
        public static bool palindrome(string text)
        {
            return Regex.Replace(string.Concat(text.OrderBy(x => x)), @"([a-z])\1{1}", "").Length <= 1;
        }
    }
}
