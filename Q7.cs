using System;
using System.Text.RegularExpressions;
namespace RegexTask{
class Q7
{
        static void Main()
        {
            string[] testCases = {"$10.99","10#","av10","100","£103"};
            foreach (string testCase in testCases)
            {
                bool isValidCurrency = Regex.IsMatch(testCase, @"^[\d,\d]+[\p{Sc}]");//\p{Sc} is a Unicode category that represents currency symbol
                Console.WriteLine($"{testCase} -> {isValidCurrency}");
            }
        }
}
}
