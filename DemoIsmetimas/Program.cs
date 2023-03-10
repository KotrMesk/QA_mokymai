using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoIsmetimas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var encoding = System.Text.Encoding.UTF8; // kalbos keitimas kad rasytu lietuviskas raides
            int amzius = 25;
            Console.WriteLine(amzius);

            //write isveda informacija ir palieka zymekli
            Console.WriteLine("labas ");
            Console.WriteLine("rytas");

            //tekstas + kintamasis. 1 budas:
            Console.WriteLine(13 + " metu");

            //2 budas (panasiai java daro)
            string vardas = "Kotryna";
            Console.WriteLine("Mano amzius: {0}", amzius);
            Console.WriteLine("Mano amzius: {0}, mano vardas: {1}", amzius, vardas);

            //3 budas
            Console.WriteLine($"Mano amzius: {amzius}");
            Console.WriteLine($"Mano amzius: {amzius}, mano vardas: {vardas}");

            //vietoj kintamuju galime isvesti operacijos rezultata
            Console.WriteLine($"Mano amzius: {5+5+20}");
        }
    }
}
