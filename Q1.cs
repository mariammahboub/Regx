using System;
using System.Text.RegularExpressions;
namespace RegexTask{
class Q1
{
        static void Main(string[] args)
        {
            string[] hexCodes = {"#CD5C5C", "#f08080","#E9967A","#EFFA07A"};
            foreach (string hexCode in hexCodes)
            {
                Console.WriteLine("Hex Code: " + hexCode + " -> " + CheckHex(hexCode));
            }
        }
        public static bool CheckHex(string hexCode)
        {
            return Regex.IsMatch(hexCode, @"[#][0-9A-Fa-f]{6}\b");
        } 
}
}
