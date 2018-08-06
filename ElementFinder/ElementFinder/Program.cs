using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 8, 9, 10,};

            Console.WriteLine(ContainsSeven(numbers));
            Console.ReadLine();
        }

        public static bool ContainsSeven(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 7)
                {
                    return true;
                }
            }
            return false;
        }

    
    }
}
