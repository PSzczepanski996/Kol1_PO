using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kol1_1
{
    class Program
    {
        static unsafe void zamien(ref int a, ref int b)
        {
            if(b < a) {
                int buffer = b;
                b = a;
                a = buffer;
            }
        }

        static void Main(string[] args)
        {
            unsafe
            {
                int x = new int();
                int y = new int();
                x = Convert.ToInt32(Console.ReadLine());
                y = Convert.ToInt32(Console.ReadLine());
                zamien(ref x, ref y);
                Console.WriteLine("X:");
                Console.WriteLine(x);
                Console.WriteLine("Y:");
                Console.WriteLine(y);
                Console.ReadKey();
            }
        }
    }
}
