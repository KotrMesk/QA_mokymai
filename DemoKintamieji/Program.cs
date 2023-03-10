using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKintamieji
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");
            Console.WriteLine("Hello world!");
            Console.WriteLine("Hello world!");

            //komentaras

            /* komentaras 
             * per kelias
             * eilutes*/
            int amzius = 7;

            // Deklaracija ir inicializacija atskirais veiksmais
            string tekstoKintamasis;
            tekstoKintamasis = "Labas";
            Console.WriteLine();

            //paprastiems tipams rekomenduojama nenaudoti var

            char simbolis = 'k';
            // char suma duoda ascii verciu suma
            Console.WriteLine(simbolis);

            //trukmeniniai skaiciai
            float skaicius0 = 0;
            float skaicius1 = 0.0f; // lfoat gal reikia nurodyti 'f'
            double skaicius2 = 0.0d; //double - 'd'
            double skaicius3 = 0.0;
            decimal skaicius4 = 0;
            decimal skaicius5 = 0.0; //decimal - 'm'
            
        }
    }
}
