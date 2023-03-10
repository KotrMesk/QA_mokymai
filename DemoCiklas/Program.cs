using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCiklas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            for (string i = "a"; i != "aaaaaa"; i += "a")
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < 5;) // jei nenurodysime operacijos bus nuolatinis loopsas kuris pats nesustos
            {
                i++; // jei padesime po console gausime kitoki varianta
                Console.WriteLine(i);
            }
        }
    }
}
