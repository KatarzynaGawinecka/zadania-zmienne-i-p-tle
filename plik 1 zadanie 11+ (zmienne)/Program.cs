using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plik_1_zadanie_11___zmienne_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Napisać program wczytujący długości boków prostopadłościanu i wypisujący na ekranie jego 
            // objętość i pole całkowite.
            double a, b, H, V, Pc;
            Console.Write("Podaj długość 1. boku podstawy a=");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj długość 2. boku podstawy b= ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj wysokość prostopadłościanu H=");
            H = Convert.ToDouble(Console.ReadLine());
            V = a * b * H;
            Pc = 2 * a * b + 2 * b * H + 2 * a * H;
            Console.WriteLine("Objętość tego prostopadłościanu wynosi V={0}. Jego pole całkowite wynosi Pc={1}", V, Pc);
            Console.ReadKey(true);
            

        }
    }
}
