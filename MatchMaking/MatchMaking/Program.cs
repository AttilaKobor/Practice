using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMaking
{
    class Program
    {
        static void Main(string[] args)
        {
            var girls = new List<string> { "Eve", "Ashley", "Claire", "Kat", "Jane" };

            var boys = new List<string> { "Joe", "Fred", "Tom", "Todd", "Neef", "Jeff" };

            var mixed = MakingMatches(girls, boys);

            foreach (var a in mixed)
            {
                Console.Write(a + ", ");
            }
           

            Console.ReadLine();
            
        }

        private static List<string> MakingMatches(List<string> girls, List<string> boys)
        {
            var names = new List<string> ();
            for (int i = 0; i < girls.Count; i++)
            {

                names.Add(boys[i]);
                names.Add(girls[i]);
            }
            return names;
        }
    }
}
