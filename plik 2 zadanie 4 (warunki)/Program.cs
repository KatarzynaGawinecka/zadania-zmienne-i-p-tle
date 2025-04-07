using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plik_2_zadanie_4__warunki_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący pięć liczb i wypisujący na ekranie wartość najmniejszej 
            // największej z tych liczb. 
            double a, b, c, d, e, MIN, MAX;
            Console.Write("Podaj liczbę a=");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj liczbę b=");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj liczbę c=");
            c = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj liczbę d=");
            d = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj liczbę e=");
            e = Convert.ToDouble(Console.ReadLine());
            //NAJMNIEJSZA
            MIN = a;
            if (b < MIN) MIN = b;
            if (c < MIN) MIN = c;
            if (d < MIN) MIN = d;
            if (e < MIN) MIN = e;
            Console.WriteLine("{0} jest najmniejszą liczbą w tym zbiorze.", MIN);
            //NAJWIĘKSZA
            MAX = a;
            if (b > MAX) MAX = b;
            if (c > MAX) MAX = c;
            if (d > MAX) MAX = d;
            if (e > MAX) MAX = e;
            Console.WriteLine("{0} jest największą liczbą w tym zbiorze.", MAX);
            Console.ReadKey(true);


        }
    }
}
