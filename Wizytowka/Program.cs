using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wizytowka
{

    struct Osoba {

        public string imie;
        public string nazwisko;
        public string adres;
        public string telefon;
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Osoba os;
            Console.WriteLine("Podaj imię: ");
            os.imie = Console.ReadLine();

            Console.WriteLine("Podaj nazwisko: ");
            os.nazwisko = Console.ReadLine();

            Console.WriteLine("Podaj adres: ");
            os.adres = Console.ReadLine();

            Console.WriteLine("Podaj telefon: xxx-xxx-xxx ");
            os.telefon = Console.ReadLine();

            Console.WriteLine("Wizytówka: ");

            for (int i = 0; i < 30; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
            Console.Write("{0} {1}", os.imie, os.nazwisko);
            Console.Write("\n adres e-mail: {0}", os.adres);
            Console.Write("\n telefon: {0}\n", os.telefon);
            for (int i = 0; i < 30; i++)
            {
                Console.Write("*");
            }

            Console.ReadKey();
        }
    }
}
