using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string reversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";

            

            Console.WriteLine(ReverseString(reversed));



            Console.ReadLine();
        

  
            
        }

        private static string ReverseString(string reversed)
        {
            
            string returnSentence = " "; 

            for (int i = reversed.Length-1; i >= 0; i--)
            {
                returnSentence += reversed[i];
            }
            return returnSentence;

        }
    }
}
