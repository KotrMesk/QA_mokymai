using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSarasai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //list:
            //List<tipas> pavadinimas = new List<int>();
            List<string> zodziai = new List<string>();
            zodziai.Add("Labas");
            Console.WriteLine(zodziai[0]);
        }
    }
}
