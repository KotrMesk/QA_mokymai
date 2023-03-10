using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite gyvuno pavadinima: ");
            string gyvunas = Console.ReadLine().ToLower();
            
            switch (gyvunas)
            {
                case "kate":
                    Console.WriteLine("Ivedete gyvuna kate");
                    break;
                case "suo":
                    Console.WriteLine("Ivedete gyvuna suo");
                    break;
                case "pele":
                    Console.WriteLine("Ivedete gyvuna pele");
                    break;
                default:
                    Console.WriteLine("Ivedete gyvuna");
                    break;
            }

            //greitesnis budas su ternery operator:
            bool arDidesnis = (skaicius > 5) ? true : false;
        }
    }
}
