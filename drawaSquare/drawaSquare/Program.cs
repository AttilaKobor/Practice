using System;

namespace drawaSquare
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i <= 6; i++)
            {
                if (i == 0 || i == 6)
                {
                    Console.WriteLine("%%%%%");
                }

                else
                {
                    Console.WriteLine("%   %");
                }

            }
            Console.ReadLine();
        }
    }
}
