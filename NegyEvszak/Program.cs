using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegyEvszak
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kérje be egy hónap számát, majd írja ki, hogy melyik évszakban van az adott hónap.
            string evszak = MelyikEvszakbanVan();
            Console.WriteLine($"A megadott hónap ebben az évszakban van: {evszak}");
            Console.ReadKey();
        }

        private static string MelyikEvszakbanVan()
        {
            int beHonapSorszam = SzamEgyTizenketto();
            if (beHonapSorszam >= 3 && beHonapSorszam <= 5)
            {
                return "tavasz";
            }
            else if (beHonapSorszam >= 6 && beHonapSorszam <= 8)
            {
                return "nyár";
            }
            else if (beHonapSorszam >= 9 && beHonapSorszam <= 11)
            {
                return "ősz";
            }
            else
            {
                return "tél";
            }
        }

        private static int SzamEgyTizenketto()
        {
            int kimenoErtek;
            int leptetes = 0;
            Console.Write("Add meg egy hónap sorszámát: ");
            do
            {
                if (leptetes > 0)
                {
                    Console.WriteLine("Hibás érték! Adj meg egy számot 1 és 12 között!");
                }
                leptetes++;
            } while (!int.TryParse(Console.ReadLine(), out kimenoErtek) || kimenoErtek <= 0 || kimenoErtek > 12);
            return kimenoErtek;
        }

    }
}
