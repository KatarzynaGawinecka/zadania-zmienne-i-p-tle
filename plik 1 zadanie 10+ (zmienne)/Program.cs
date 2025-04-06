using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plik_1_zadanie_10___zmienne_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący promień koła i wypisujący na ekranie jego pole i obwód.
            // WZORY: P = π * (promień)^2
            // Obwód L = 2π* promień.
            double r, pole, obwod;
            Console.Write("Podaj długość promienia koła r=");
            r = Convert.ToDouble(Console.ReadLine());
            pole = Math.PI * r * r;
            obwod = 2 * Math.PI * r;
            Console.WriteLine("Pole koła o takim r wynosi P={0} a obwód L={1}", pole, obwod);
            Console.ReadKey(true);


        }
    }
}
