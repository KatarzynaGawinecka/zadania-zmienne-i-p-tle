using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plik_3_zadanie_4__for_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Wczytaj dwie liczby naturalne dodatnie n i k. Narysuj z gwiazdek na ekranie prostokąt 
            // posiadający n wierszy i k kolumn. Użyj pętli for. 
            int i, j, n, k;
            Console.Write("Podaj liczbę wierszy n=");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj liczbę kolumn k=");
            k = Convert.ToInt32(Console.ReadLine());
            for (i=1;i<=n;i++) //wiersze
            {
                for (j = 1; j <= k; j++)
                    Console.Write("*");
                Console.WriteLine("");
            }
            Console.ReadKey(true);

        }
    }
}
