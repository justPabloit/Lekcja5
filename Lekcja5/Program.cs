using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja5
{
    class Program
    {
        static void Main(string[] args)
        {
            // KOMENTARZE

            // Test Test

            /*
             *Test 
             * Test
             */

            // SKRÓTY KLAWISZOWE & SNIPETY

            /*
             * Układanie kodu ctrl k ctrl d
             *
             * Komentowanie kodu Ctrl+ e c
             * Od komentowanie kodu Ctrl+ e u
             *
             * cw + 2x Tab Console.WriteLine();
             * 
             * 
             */

            //RZUTOWANIE ZMIENNYCH

            int i = int.MaxValue;
            short s = short.MaxValue;

            s = (short)i;
            Console.WriteLine(s);

            //WCZYTYWANIE DANYCH Z KONSOLI

            //Wczytywanie całej lini z konsoli jaką wprowadził użytkownik  
            Console.ReadLine();
            string k = Console.ReadLine();
            Console.WriteLine(k);

            //Wczytywanie jaki przycisk został wciśnięty  
            Console.ReadKey();
            if (Console.ReadKey().Key == ConsoleKey.D1)
                Console.WriteLine("PRAWDA");

            //KONWERSJA TYPÓW (STRING > INT, INT >STRING )

            string c = Console.ReadLine();
            int d = int.Parse(c) + 2;
            Console.WriteLine(i);

            c = d.ToString();
            Console.WriteLine(c);

            //ŁĄCZENIE TEKSTU & FORMATOWANIE "WRITELINE"

            string s1 = "Witaj";
            string s2 = "Świecie";
            Console.WriteLine(s1 + s2 + "!!!{0} \n {1}", s1, s2);

            //MODYFIKACJA KONSOLI
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(s1 + s2 + "!!!{0} \n {1}", s1, s2);
            Console.ResetColor();
            Console.WriteLine(s1 + s2 + "!!!{0} \n {1}", s1, s2);
            Console.ReadKey();
            Console.Clear();




            Console.ReadKey();
        }
    }
}
