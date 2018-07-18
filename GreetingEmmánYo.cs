using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeting
{
    class Program
    {
        static void Main(string[] args)
        {

            string al = Greet ("Greenfox ");
           

            Console.WriteLine(al);

            Console.ReadLine();
        }

        public static string Greet (string userToGreet)
        {
                return "Greetings dear, " + userToGreet ;
        }
    }
}
