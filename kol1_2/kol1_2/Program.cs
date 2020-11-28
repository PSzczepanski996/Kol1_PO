using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kol1_2
{
    class Program
    {
        static int findMinArray(int [,] table)
        {
            return table.Cast<int>().Min();
        }

        static void Main(string[] args)
        {
            uint x = 0;
            uint y = 0;
            x = Convert.ToUInt32(Console.ReadLine());
            y = Convert.ToUInt32(Console.ReadLine());
            if (x > 10 || y > 10)
            {
                Console.WriteLine("Liczby sa za duze.");
                return;
            }
            int[,] table = new int[x, y];
            for(int i=0; i<x; i++)
            {
                for(int j=0; j<y; j++)
                {
                    table[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Najmniejsza wartosc to: ");
            Console.WriteLine(findMinArray(table));
            Console.ReadKey();
        }
    }
}
