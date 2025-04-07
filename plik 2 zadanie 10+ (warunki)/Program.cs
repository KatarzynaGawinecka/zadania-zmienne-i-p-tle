using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plik_2_zadanie_10___warunki_
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Napisać program wypisujący na ekranie kolejne liczby całkowite od 11 do 33. Użyj pętli for.
            for (int i = 11; i <= 33; i++)
                Console.Write("{0}, ", i);
            Console.ReadKey(true);
        }
    }
}
