using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var planetList = new List<string> { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Uranus", "Neptune" };

            PutSaturn(planetList);

            foreach (var i in planetList)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }

        private static List <string> PutSaturn(List<string> planetList)
        {
            planetList.Insert(5, "Saturn");
            return planetList;
        }
    }
}
