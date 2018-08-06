using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URLFixer
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https//www.reddit.com/r/nevertellmethebots";
            url = url.Replace("bots", "odds");
            Console.WriteLine(url);
            Console.ReadLine();
        }
    }
}
