using System;
using System.Text.RegularExpressions;
public class Q6
{
        static void Main()
        {
            string input1 = "C# C# syntax is highly expressive, yet it is is also simple and easy to to learn learn.";
            int count1 = CountRepeatedWords(input1);
            Console.WriteLine($"\"{input1}\" -> {count1} matches found\n\n");
            string input2 = "Red Green Green Black Black Green.";
            int count2 = CountRepeatedWords(input2);
            Console.WriteLine($"\"{input2}\" -> {count2} matches found\n\n");
        }
        public static int CountRepeatedWords(string input)
        {
            Regex regex = new Regex(@"\b(\w+)\b(\s+\1\b)+", RegexOptions.IgnoreCase);
            MatchCollection matches = regex.Matches(input);
            int count = matches.Count;
            return count;
        }
    }
