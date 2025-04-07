using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plik_2_zadanie_9___warunki_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dana jest funkcja kwadratowa f(x)=ax^2+bx+c. Napisać program wczytujący współczynniki 
            //  funkcji kwadratowej(a, b, c) i wypisujący na ekranie jej miejsca zerowe lub informację o ich braku.
            // Wskazówka: Zbadaj deltę, wyznacz miejsca zerowe.
            double a, b, c, delta;
            Console.Write("Podaj współczynnik a=");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj współczynnik b=");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj współczynnik c=");
            c = Convert.ToDouble(Console.ReadLine());
            //liczenie delty
            delta = b * b - 4 * a * c;
            //ile miejsc zerowych, czy ma jakieś?
            if (delta > 0) { Console.WriteLine("miejsca zerowe to: {0} i {1}", (-b - Math.Sqrt(delta)) / (2 * a), (-b + Math.Sqrt(delta)) / (2 * a)); }
            else if (delta == 0) { Console.WriteLine("miejsce zerowe to: {0}", -b / (2 * a)); }
            else Console.WriteLine("brak miejsc zerowych");
            Console.ReadKey(true);

        }
    }
}
