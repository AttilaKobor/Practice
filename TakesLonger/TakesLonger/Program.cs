using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakesLonger
{
    class Program
    {
        static void Main(string[] args)
        {
            string quote = "Hofstadter's Law: It you expect, even when you take into account Hofstadter's Law.";
            string add = "always takes longer than";
            StringBuilder LongQuote = new StringBuilder(quote);
            
            LongQuote.Insert(20, " always takes longer than");
            quote = LongQuote.ToString();
            Console.WriteLine(quote);
            Console.ReadLine();
        }
    }
}
