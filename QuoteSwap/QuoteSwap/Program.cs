using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuoteSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            var quote = new List<string> { "What", "I", "do", "create,", "I", "cannot", "not", "understand." };
            QuoteSwap(quote);
            foreach (var item in quote)
            {
                Console.Write(item + " ");
            }
            Console.ReadLine();
        }

        private static List<string> QuoteSwap(List<string> quote)
        {
            quote[2] = "Cannot";
            quote[5] = "do";

            

            return quote;
        }
    }
}
