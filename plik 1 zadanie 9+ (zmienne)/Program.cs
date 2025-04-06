using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plik_1_zadanie_9___zmienne_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Napisać program wczytujący dwie liczby całkowite i wypisujący na ekranie sumę kwadratów wczytanych liczb.
            int a, b;
            Console.Write("Podaj liczbę całkowitą a=");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj liczbę całkowitą b=");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Suma kwadratów podanych liczb wynosi {0}^2+{1}^2={2}", a, b, a * a + b * b);
            Console.ReadKey(true);
           
        }
    }
}
