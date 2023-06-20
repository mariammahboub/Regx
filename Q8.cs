using System;
using System.Text.RegularExpressions;
namespace RegexTask{
class Q8
{
    static void Main()
    {
        string[] testCases = {
            "AA@%^&CC",
            "Python",
            "google.com"
        };
        foreach (string text in testCases)
        {
            string updatedText = Regex.Replace(text, @"[^a-zA-Z0-9 _-]", "");
            Console.WriteLine($"{text} -> {updatedText}");
        }
    }
}
}
