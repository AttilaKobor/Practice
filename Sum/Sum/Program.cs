using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummingDroids
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tell me, how many droids are you looking for");
            int numbers = Int32.Parse(Console.ReadLine());
            int answer = Sum(numbers);
            Console.WriteLine("The droids you are looking for:" + answer);


            Console.ReadLine();

        }
        public static int Sum(int n)
        {

            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int userInput = Int32.Parse(Console.ReadLine());

                sum += userInput;

                Console.WriteLine("This is not the droids you are looking for");

            }
            return sum;
        }
    }
}
