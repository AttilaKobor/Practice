using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());

            double sumOfNumbers = 0;
            for (int i = 0; i < n; i++)
            {
                double num = Int32.Parse(Console.ReadLine());
                sumOfNumbers += num;
            }
            Console.WriteLine("{0}",sumOfNumbers);
        }
    }
}
