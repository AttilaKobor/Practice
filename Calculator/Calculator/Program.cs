using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = Int32.Parse(Console.ReadLine());
            
            int numberTwo = Int32.Parse(Console.ReadLine());

            Console.WriteLine(Calculating(numberOne, numberTwo));
            
            Console.ReadLine();
        }

        private static int Calculating(int numberOne, int numberTwo)
        {
            int result = 0;
            string operand = Console.ReadLine();
            if (operand == "/")
            {
                result = numberOne / numberTwo;
                
            }
            if (operand == "*")
            {
                result = numberOne * numberTwo;
            }
            if (operand == "+")
            {
                result = numberOne + numberTwo;
            }
            if (operand == "-")
            {
                result = numberOne - numberTwo;
            }
            if (operand == "%")
            {
               result = (numberOne / 100) * numberTwo;
            }
            return result;
        }
    }
}
