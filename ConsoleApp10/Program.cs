using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            // wczytanie poczatku i konca przedzialu
            Console.WriteLine("Wprowadz poczatek przedzialu");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Wprowadz koniec przedzialu");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();

            // sprawdzenie czy zalozenia sa spelnione
            if ((m < 1) || (n < 1) || (m > n) || (n > 1000000000) || ((n - m) > 100000))
            {
                Console.Write("Podales nieprawidlowe dane.");
                Console.ReadKey();
                Environment.Exit(0);
            }

            bool liczba_pierwsza = true;
            int wynik = 0;
            int j;

            // dla wszystkich liczb od m do n 
            for (int i = m; i <= n; i++)
            {
                // sprawdzenie czy liczba dzieli sie nie tylko przez 1 i sama siebie
                for (j = 2; j < i; j++)
                {
                    // jezeli tak to NIE jest to liczba pierwsza
                    if (i % j == 0)
                    {
                        liczba_pierwsza = false;
                    }
                }
             
                // wypisanie wszystkich liczb pierwszych w przedziale od m do n
                // (i>1) poniewaz 1 nie jest liczba pierwsza
                if ((liczba_pierwsza == true) && (i > 1))
                {
                    Console.WriteLine("Liczba pierwsza jest:  " + i);
                    wynik++; // zliczanie ilosci liczb pierwszych
                }

                else liczba_pierwsza = true;

            }

            // wypisanie ilosci liczb pierwszych w podanym przez uzytkownika przedziale
            Console.WriteLine("Liczb pierwszych w przedziale od " + m + " do " + n + " jest: " + wynik);
            Console.ReadKey();
        }
    }
}

    

