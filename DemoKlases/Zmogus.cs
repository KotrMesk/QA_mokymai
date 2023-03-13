using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKlases
{
    internal class Zmogus
    {
        internal string vardas { get; }
        internal int amzius { get; }
        internal double ugis { get; }
        
        public Zmogus(string vardas, int amzius, double ugis)
        {
            this.vardas = vardas;
            this.amzius = amzius;
            this.ugis = ugis;
        }

        public Zmogus()
        {

        }

        public Zmogus(string vardas)
        {
            this.vardas = vardas;
        }

        internal void Prisistatymas()
        {
   
            Console.WriteLine($"Sveiki, mano vardas yra {vardas}");
        }

        internal void Atsisveikinimas()
        {
            Console.WriteLine("Viso gero");
        }

        internal void Atsisveikinimas(Zmogus kitasZmogus)
        {
            Console.WriteLine($"Ate {kitasZmogus.vardas}");
        }
    }
}
