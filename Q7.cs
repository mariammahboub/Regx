using System;
using System.Text.RegularExpressions;
namespace RegexTask{
class Q7
{
        static void Main()
        {
            string[] testCases = {
            "$10.99",
            "€15.50",
            "£25",
            "100.00",
            "CAD 50.75",
            "12.345.67",
            "abc",
            "USD 20.50$",
            "$ 50",
            "€-10.99"
        };

            foreach (string testCase in testCases)
            {
                bool isValidCurrency = Regex.IsMatch(testCase, @"^([A-Z]{3}\s*)?(-?\$|€|£)?\d{1,3}(,\d{3})*(\.\d{2})?$");
                Console.WriteLine($"{testCase} -> {isValidCurrency}");
            }
        }
}
}
