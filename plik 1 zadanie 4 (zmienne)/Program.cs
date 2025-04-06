using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plik_1_zadanie_4__zmienne_
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Napisać program wczytujący boki prostokąta i wypisujący na ekranie jego pole i obwód.
            double a, b;
            Console.Write("Podaj bok a=");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj bok b=");
            b = Convert.ToDouble(Console.ReadLine());
            // przyjęto zmienne, ostateczne obliczenia 
            Console.WriteLine("Pole tego prostokąta wynosi= {0}", a * b);
            Console.WriteLine("Obwód tego prostokąta wynosi= {0}", 2 * a + 2 * b);
            Console.ReadKey(true);
                
        }
    }
}
