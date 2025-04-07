using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plik_2_zadanie_1__warunki_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący liczbę całkowitą i wypisujący na ekranie informację czy jest to 
            //liczba parzysta, czy też nieparzysta.
            int a;
            Console.Write("Podaj liczbę całkowitą a=");
            a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
                Console.WriteLine("Liczba {0} jest parzysta", a);
            else
                Console.WriteLine("Liczba {0} nie jest parzysta", a);
            Console.ReadKey(true);
        }
    }
}
