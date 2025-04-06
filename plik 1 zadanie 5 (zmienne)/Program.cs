using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plik_1_zadanie_5__zmienne_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Napisać program wczytujący promień podstawy (r) i wysokość (h) stożka i wypisujący na 
            // ekranie objętość i pole całkowite tego stożka. 
            double r, h, V, Pc, l;
            Console.Write("Podaj promień podstawy r=");
            r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj wysokość stożka h=");
            h = Convert.ToDouble(Console.ReadLine());
            l = Math.Sqrt(h * h + r * r);
            V = 1.0 / 3 * r * r * h * Math.PI;
            //Pc=πr2+πrl=πr(r+l)
            Pc = Math.PI * r * r + Math.PI * r * l;
            Console.WriteLine("Objętość stożka wynosi V={0}", V);
            Console.WriteLine("Pole całkowite stożka wynosi Pc={0}", Pc);
            Console.ReadKey(true);
        }
    }
}
