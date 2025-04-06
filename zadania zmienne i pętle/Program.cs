using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadania_zmienne_i_pętle
{
    class Program
    {
        static void Main(string[] args)
        {
            //plik 1 zadanie 2. Napisać program wczytujący imię użytkownika i wypisujący na ekranie tekst "Witaj imię!". 
            string imie;
            Console.Write("Podaj swoje imię:");
            imie = Console.ReadLine();
            Console.WriteLine("Witaj {0}!", imie);
            Console.ReadKey(true);
            
        }
    }
}
