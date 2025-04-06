using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plik_1_zadanie_3__zmienne_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Napisać program wczytujący z klawiatury liczbę całkowitą i wypisujący na ekranie sześcian 
            // wczytanej liczby. 
            int a;
            Console.Write("Podaj liczbę całkowitą a=");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sześcian tej liczby to={0}", a * a * a);
            Console.ReadKey(true);
        }
    }
}
