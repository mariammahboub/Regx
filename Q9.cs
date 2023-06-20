using System;
using System.Text.RegularExpressions;
namespace RegexTask{
class Q9
{
    static void Main()
    {
        Console.WriteLine("Enter the Search word :");
        string word = Console.ReadLine();
        Console.WriteLine("Enter the Text for Search : ");
        string text = Console.ReadLine();
        Console.WriteLine("The Word : " + (Regex.IsMatch(text, Regex.Escape(word)) ? "Exists" : "Doesn't Exist"));
    }
}
}
