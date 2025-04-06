using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plik_1_zadanie_6__zmienne_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Napisać program wczytujący dwie liczby i wypisujący na ekranie ich sumę, różnicę, iloczyn i iloraz.
            double a, b, suma, roznica, iloczyn, iloraz;
            Console.Write("Podaj liczbę a=");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj liczbę b=");
            b = Convert.ToDouble(Console.ReadLine());
            suma = a + b;
            roznica = a - b;
            iloczyn = a * b;
            iloraz = a / b;
            Console.WriteLine("Suma wynosi {0}+{1}={2}", a, b, suma);
            Console.WriteLine("Różnica wynosi {0}-{1}={2}", a, b, roznica);
            Console.WriteLine("Iloczyn wynosi {0}*{1}={2}", a, b, iloczyn);
            Console.WriteLine("Iloraz wynosi {0}/{1}={2}", a, b, iloraz);

            Console.ReadKey(true);
               
           
        }
    }
}
