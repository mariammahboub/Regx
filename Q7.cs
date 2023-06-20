using System;
using System.Text.RegularExpressions;
namespace RegexTask{
class Q7
{
        static void Main()
        {
            string[] testCases = {"$10.99","10#","av10","100","103"};
            foreach (string testCase in testCases)
            {
                bool isValidCurrency = Regex.IsMatch(testCase, @"^\p{Sc}?\d+(,\d{3})*(\.\d{2})?$");
                Console.WriteLine($"{testCase} -> {isValidCurrency}");
            }
        }
}
}
