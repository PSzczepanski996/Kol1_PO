using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kol1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadz ilosc liczb ktore chcesz wprowadzic:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] table = new int[n];
            Console.WriteLine("Wprowadz liczby:");
            for (int i = 0; i < n; i++)
            {
                table[i] = Convert.ToInt32(Console.ReadLine());
            }
            int iloscDodatnich = 0;
            int iloscUjemnych = 0;
            int iloscZer = 0;
            for (int i = 0; i < n; i++)
            {
                if (table[i] > 0) iloscDodatnich++;
                else if (table[i] < 0) iloscUjemnych++;
                else iloscZer++;
            }
            Console.WriteLine("Ilosc dodatnich elementow: " + iloscDodatnich);
            Console.WriteLine("Ilosc ujemnych elementow: " + iloscUjemnych);
            Console.WriteLine("Ilosc zerowych elementow: " + iloscZer);
            Console.ReadKey();
        }
    }
}
