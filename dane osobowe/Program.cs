using System;
using System.ComponentModel.Design;
using System.Net.NetworkInformation;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace DaneOsobowe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Uzupełnij formularz");
            Console.WriteLine("Imię");
            {
                String imię = "imię";
                Console.ReadLine();

            }
            Console.WriteLine("Nazwisko");
            {
                string nazwisko = "nazwisko";
                Console.ReadLine();
                 
            }
            Console.WriteLine("Wiek");
            {
                string wiek = Console.ReadLine();

            }
            
            Console.WriteLine("Płeć, wybierz: k- kobieta, m-mężczyzna");
            //Console.WriteLine("Wybierz 'k' - gdy jestes kobietą");
            //Console.WriteLine("Wybierz 'm' - gdy jesteś mężczyzną");
            //Console.WriteLine("Wybrałeś k-jesteś kobietą, wybrałeś m-jesteś mężczyzną");

            char płeć1 = 'k';
            char płeć2 = 'm';
            Console.WriteLine("płeć1, płeć2");
            Console.ReadLine();

            Console.WriteLine("numerPESEL");
            {
                string numerPesel = "88022305987";
                Console.WriteLine(numerPesel);
            }
            
            
            Console.WriteLine("Numer pracownika");
            {
                string numerPracownika = "56597452";

                Console.WriteLine(numerPracownika);

                Console.ReadLine();
            }
        }
    }
}