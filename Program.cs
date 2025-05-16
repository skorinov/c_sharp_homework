using System;

namespace C_Sharp_Homework
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CreateAndPrintArray();
        }
        
        // Task 1
        static void CreateAndPrintArray()
        {
            int[] numbers = new int[50];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = (i + 1) * 2;
                Console.WriteLine($"Element: {numbers[i]}");
            }
        }
    }
}