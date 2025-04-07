using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plik_2_zadanie_3__warunki_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Napisać program wczytujący trzy liczby i wypisujący na ekranie wartość najmniejszej i 
            // największej z tych liczb.
            double a, b, c;
            Console.Write("Podaj liczbę a=");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj liczbę b=");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj liczbę c=");
            c = Convert.ToDouble(Console.ReadLine());
            //SZUKANIE NAJMNIEJSZEJ 
            if (a <= b && a <= c)
                Console.WriteLine("Liczba {0} jest najmniejsza.", a);
            else if (b <= a && b <= c)
                Console.WriteLine("Liczba {0} jest najmniejsza.", b);
            else
                Console.WriteLine("Liczba {0} jest najmniejsza.", c);
            //SZUKANIE NAJWIĘKSZEJ 
            if (a >= b && a >= c)
                Console.WriteLine("Liczba {0} jest największa.", a);
            else if (b >= a && b >= c)
                Console.WriteLine("Liczba {0} jest największa.", b);
            else
                Console.WriteLine("Liczba {0} jest największa.", c);
            Console.ReadKey(true);

        }
    }
}
