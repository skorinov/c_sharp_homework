using System;

namespace C_Sharp_Homework
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            PrintAlphabetAscii();
        }
        
        // Task 4
        static void PrintAlphabetAscii()
        {
            int alphabetLength = 26; // a-z
            char[] letters = new char[alphabetLength];

            for (int i = 0; i < alphabetLength; i++)
            {
                letters[i] = (char)('a' + i);
            }

            foreach (char c in letters)
            {
                Console.WriteLine($"Character: {c}  |  ASCII code: {(int)c}");
            }
        }
    }
}