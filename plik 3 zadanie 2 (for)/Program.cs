﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plik_3_zadanie_2__for_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący wartość liczby naturalnej n (n>=0), obliczający wartość 2^n (2 do 
            // potęgi n) i wypisujący wynik na ekranie w formacie(np.dla n = 10) : 2 ^ 10 = 1024.Do obliczenia
            // wartości wyrażenia użyj pętli for. 
            int i, n, wynik = 1;
            Console.Write("Podaj potęge n=");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
                wynik *= 2;
            Console.WriteLine("2^{0}={1}", n, wynik);
            Console.ReadKey(true);


        }
    }
}
