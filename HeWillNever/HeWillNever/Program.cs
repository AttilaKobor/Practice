using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeWillNever
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random random = new Random();

            int returnValue = random.Next(1, 101);

            Console.WriteLine(returnValue);

            int userGuess = 0;

            while (userGuess != returnValue)
            {
                int numberOfLives = 5;
                numberOfLives--;
                userGuess = Int32.Parse(Console.ReadLine());
                if (userGuess < returnValue)
                {
                    Console.WriteLine("The number is higher!You have {0} lives!", numberOfLives);
                }
                if (userGuess > returnValue)
                {
                    Console.WriteLine("The number is lower! You have {0} lives!", numberOfLives);
                }
            }
            Console.WriteLine("Good job, you got the number {0}!" , returnValue);
            Console.ReadLine();
        }
    }
}
