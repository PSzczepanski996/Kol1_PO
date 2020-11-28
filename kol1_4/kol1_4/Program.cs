using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kol1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);
            Console.WriteLine("Miesiac to: ");
            Console.WriteLine(CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(dt.Month));
            Console.ReadKey();
        }
    }
}
