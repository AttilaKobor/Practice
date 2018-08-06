using System;
using System.Collections.Generic;

namespace MadMa3x
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 1, 1, 2, 3, 3, 4, 4, 4, 5, 6, 7, 7, 8 };

            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();

            numbers = Unique(numbers);

            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.ReadLine();
        }

        public static int[] Unique(int[] numbers)
        {
            int j = 0;
            int[] uniqueNumbers = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!IsInArray(uniqueNumbers, numbers[i]))
                {
                    uniqueNumbers[j] = numbers[i];
                    j++;
                }
            }

            return uniqueNumbers;
        }

        public static bool IsInArray(int[] numbers, int v)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == v)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
