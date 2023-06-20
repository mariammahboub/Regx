using System;
using System.Text.RegularExpressions;
public class Q5{
        static void Main()
        {
            Console.WriteLine("Sample Data:");
            Console.WriteLine("(\"AACC\", \"PPRR\") -> " + ArePatternsEqual("AACC", "PPRR"));
            Console.WriteLine("(\"FFGG\", \"ADAD\") -> " + ArePatternsEqual("FFGG", "ADAD"));
        }
        public static bool ArePatternsEqual(string str1, string str2)
        {
            string pattern1 = GeneratePattern(str1);
            string pattern2 = GeneratePattern(str2);
            return pattern1 == pattern2;
        }
        public static string GeneratePattern(string str)
        {
            string pattern = Regex.Replace(str, @"(.)\1+", "$1");
            return pattern.Length.ToString();
        }
    }
