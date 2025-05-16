using System;
using System.Collections.Generic;

namespace C_Sharp_Homework
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CountEvenNumbersInArray();
        }
        
        // Task 2
        static void CountEvenNumbersInArray()
        {
            Random random = new Random();
            int[] numbers = new int[30];
            List<int> eventList = new List<int>();
            
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(0, 101);
                if (numbers[i] % 2 == 0)
                {
                    eventList.Add(numbers[i]);
                }
            }

            Console.WriteLine($"Array includes {eventList.Count} even numbers.");
            Console.WriteLine(eventList.Count > 0
                ? $"It's: {string.Join(", ", eventList)}"
                : "There are no even numbers in the array.");
        }
    }
}