using System;
        static void Main(string[] args)
        {
            string[] testCases = { "Suuu$21g@", "W#1g@", "a&&g@", "sdsd723#$Amid", "sdsd723#$Amidkiouy" };
            foreach (string text in testCases)
                Console.WriteLine($"Original string: {text} is a valid password? {PasswordCheck(text)}\n");
        }
        public static bool PasswordCheck(string text) =>
            text.Length >= 7 && text.Length <= 16 &&
            Regex.IsMatch(text, "[A-Z]") &&
            Regex.IsMatch(text, "[a-z]") &&
            Regex.IsMatch(text, @"\d") &&
            Regex.IsMatch(text, @"[!-/:-@\[-_{-~]") &&
            !Regex.IsMatch(text, @"[^\dA-Za-z!-/:-@\[-_{-~]");
    }
