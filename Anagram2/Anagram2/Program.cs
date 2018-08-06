using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstWord = Console.ReadLine();
            string seconWord = Console.ReadLine();

            Console.WriteLine(IsAnagram(firstWord, seconWord));

            Console.ReadLine();
            

      
        }

        public static bool IsAnagram(string firstWord, string seconWord)
        {
            if (firstWord != seconWord)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < firstWord.Length; i++)
                {
                    if (!Checked (firstWord[i], seconWord))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private static bool Checked(char v, string seconWord)
        {
            for (int i = 0; i < seconWord.Length; i++)
            {
                if (seconWord[i]==v)
                {
                    return true;
                }
            }
            return false;
        }
        
    }
}