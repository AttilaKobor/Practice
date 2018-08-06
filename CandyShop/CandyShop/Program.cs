using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string> { "Cupcake", "2", "Brownie", "false" };
            Sweets(list);

            foreach (var niamm in list)
            {
                Console.WriteLine(niamm);
            }
            Console.ReadLine();
        }

        private static List<string> Sweets(List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == "2")
                {
                    list[i] = "Croissant";
                }
                else if (list[i] == "false")
                {
                    list[i] = "Ice Cream";
                }
                
            }

            return list;


        }
    }
}
