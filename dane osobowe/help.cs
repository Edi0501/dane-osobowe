using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dane_osobowe
{
    internal class help
      
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj płeć(k-kobieta,m-mężczyzna):");
            string odpowiedz = Console.ReadLine();

            if (odpowiedz == "k" || odpowiedz == "m")
            {
                Console.WriteLine("poprawna odpowiedz:+odpowiedz");
            }
            else
            {
                Console.WriteLine("Błąd Niepoprawny wybór płci.");
            }
        }

