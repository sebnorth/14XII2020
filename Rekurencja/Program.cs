using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekurencja
{
    class Program
    {

        static int NaszaFunkcja(int n) {

            if (n < 1) return n;
            else if (n == 1) return 1;
            else return 2 * NaszaFunkcja(n - 1) + 1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(NaszaFunkcja(n)); //7

            Console.WriteLine(NaszaFunkcja(NaszaFunkcja(n))); //127

            Console.ReadKey();
        }
    }
}
