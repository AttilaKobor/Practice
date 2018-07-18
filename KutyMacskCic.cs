using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendA2
{
    class Program
    {
        static void Main()
        {
            string[] animals = { "kuty", "macsk", "cic" };

            foreach (string i in animals)
            {
                
                Console.Write( i + "a" + ", ");
            }

            Console.ReadKey();
        }

    }
}
