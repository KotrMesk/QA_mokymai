using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKlases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zmogus zmogusPetras = new Zmogus("Petras", 45, 1.80);
            Zmogus zmogusSetras = new Zmogus("Saulius");

            Console.WriteLine(zmogusPetras.vardas);
            Console.WriteLine(zmogusPetras.ugis);
            Console.WriteLine(zmogusPetras.amzius);
            Console.WriteLine(zmogusSetras.vardas);
            Console.WriteLine(zmogusSetras.ugis);
            Console.WriteLine(zmogusSetras.amzius);

            zmogusPetras.Prisistatymas();
            zmogusSetras.Atsisveikinimas();
            zmogusSetras.Atsisveikinimas(zmogusPetras);
        }
    }
}
