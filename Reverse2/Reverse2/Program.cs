using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach (int i in numbers)
            {
                Console.Write(i + ", ");
            }

            Array.Reverse(numbers);
            foreach (int i in numbers) 
                {
                    Console.WriteLine(i + ", ");
                }
            
            Console.ReadKey();
        }
    }
}
