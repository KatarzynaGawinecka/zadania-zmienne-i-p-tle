using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plik_2_zadanie_8__warunki_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący trzy długości odcinków i wypisujący na ekranie informację czy 
            // da się z tych odcinków zbudować trójkąt, czy też nie.
            // Wskazówka: Z trzech odcinków można zbudować trójkąt, jeżeli suma długości dowolnych
            // dwóch odcinków jest większa od długości trzeciego odcinka. 
            int a, b, c;
            Console.Write("Podaj długość odcinka a=");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj długość odcinka b=");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj długość odcinka c=");
            c = Convert.ToInt32(Console.ReadLine());
            if (a + b > c) { Console.WriteLine("Można zbudować trójkąt"); }
            else if (a + c > b) { Console.WriteLine("Można zbudować trójkąt"); }
            else if (b + c > a) { Console.WriteLine("Można zbudować trójkąt"); }
            else Console.WriteLine("Nie możńa zbudować trójkąta z boków o takich długościach");
            Console.ReadKey(true);




        }
    }
}
