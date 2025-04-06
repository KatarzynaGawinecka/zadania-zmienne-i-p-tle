using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plik_1_zadanie_8___zmienne_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dany jest ciąg arytmetyczny a(n)=3n-1. Napisać program wczytujący numer wyrazu ciągu (n) i wypisujący na ekranie jego wartość.
            int n;
            Console.Write("Podaj numer wyrazu ciągu n=");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wartość {0}-tego wyrazu ciągu wynosi 3*{0}-1={1}", n, 3 * n - 1);
            Console.ReadKey(true);
        }

    }
} 
