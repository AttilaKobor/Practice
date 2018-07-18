using System;

namespace ParametricAvarage2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey give me a number!");

            double num = Int32.Parse(Console.ReadLine());
            double sum = 0;
            // kérek egy számot (pl.3). A fornak addig kell pörögnie, amíg ezt a 3 számot meg nem kapja. Ezután ezeket kell összeadnia
            // és átlagot vonnia belőle
            

            for (int i = 0; i < num; ++i)
            {
                int numi = Int32.Parse(Console.ReadLine());

                sum += numi;



            }
            double avarage = sum / num;

            Console.WriteLine("The sum of your numbers is: {0}, and the avarage is: {1}", sum, avarage);



            Console.ReadLine();
        }
    }
}
