using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoIfSalyga
{
    internal class Program
    {
        static void Main(string[] args)
            {
        //    Console.WriteLine("Iveskite skaiciu: ");
        //    string ivedimas = Console.ReadLine();
        //    Console.WriteLine($"Ivedei tai:{ivedimas}");

        //    Console.WriteLine("Iveskite skaiciu: ");
        //    int skaicius = Convert.ToInt32(Console.ReadLine());

        //    if (skaicius > 10) 
        //    {
        //        Console.WriteLine($"Skaicius '{skaicius}' yra didesnis uz 5");
        //    }

        //    else if (skaicius > 8) 
        //    {
        //        Console.WriteLine($"Skaicius '{skaicius}' yra didesnis uz 10");
        //    }

        //    if (skaicius >= 0) 
        //    {
        //        Console.WriteLine($"Skaicius '{skaicius}' yra teigiamas");
        //    }

        //    else 
        //    {
        //        Console.WriteLine($"Skaicius '{skaicius}' yra neigiamas");
        //    }

            bool arPenktadienis = true; //klausimas

            if (!arPenktadienis) // if (arPenktadienis = true) (!arPenktadienis = false)
            {
                Console.WriteLine("Siandien yra penktadienis");
            }
            else
            {
                Console.WriteLine("Siandien nera penktadienis");
            }

            bool arKovas = true;
            if (arPenktadienis && arKovas) 
            {
                Console.WriteLine(arKovas"Kovas ir Penktadienis");
            }

            else if (!arKovas && arPenktadienis)
            {
                Console.WriteLine("Ne Kovo penktadienis");
            }
            else if (arKovas || arPenktadienis)
            {
                Console.WriteLine("Gal Kovas, gal Penktadienis, gal abu");
            }


            Console.WriteLine("Programos pabaiga");
        }
    }
}
