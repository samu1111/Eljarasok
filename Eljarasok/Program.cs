using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eljarasok
{
    class Program
    {
        static void Main(string[] args)
        {

            Uzenet("Kérek egy egész számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());

            OsztokKiirasa(szam);

            Uzenet("Egy másik egész számot: ");
            szam = Convert.ToInt32(Console.ReadLine());

            OsztokKiirasa(szam);






            Console.ReadKey();
        }

        static void Uzenet(string szoveg)
        {
            Console.Write($"{szoveg} ");
        }

        static void OsztokKiirasa(int number)
        {
            Console.WriteLine($"{number} osztói: ");
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
