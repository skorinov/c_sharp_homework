using System;

namespace C_Sharp_Homework
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            AnalyzeText();
        }
        
        // Task 3
        static void AnalyzeText()
        {
            Console.Write("Write text: ");
            string input = Console.ReadLine();
            
            Console.WriteLine($"Text \"{input}\" includes: {input.Length} symbols.");

            Console.Write("Enter a character to search: ");
            string searchInput = Console.ReadLine();
            
            if (string.IsNullOrEmpty(searchInput) || searchInput.Length != 1)
            {
                Console.WriteLine("Error: Please enter exactly one character.");
                return;
            }

            char targetChar = char.ToLower(searchInput[0]);

            int count = 0;
            foreach (char c in input)
            {
                if (char.ToLower(c) == targetChar)
                {
                    count++;
                }
            }

            Console.WriteLine($"The character '{searchInput}' was found {count} times.");
        }
    }
}