using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            var far = new List<string> { "bo", "anacond", "koal", "pand", "zebr" };

            AppendA(far);
            
            foreach (var word in far)
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();
      
        }

        private static List<string> AppendA(List<string> far)
        {           
            for (int i = 0; i < far.Count; i++)
            {
                far[i] += "a";
                
            }
            return far;
        }
        
    }
}
