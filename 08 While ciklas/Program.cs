using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_While_ciklas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // gana daznas while panaudojimas, galime daryti neribota kieki kartu
            while (true)
            {    // veiksmai:
                if (true == true) //kazkokia salyga
                {
                    break; //continue tes cikla
                }
            }

            Console.InputEncoding = Encoding.UTF8;

            //ivedimas su duomenu tipo apsauga
            int skaicius = int.MinValue;

            while (skaicius == int.MaxValue)
            {
                try
                {
                    Console.Write("Įveskite sveikąjį skaičių: ");
                    skaicius = Convert.ToInt32(Console.ReadLine());
                    //break; // siuo atveju nereikalingas, nes is while iseisim pasikeitus skaicius reiksmei
                    // break reikalingas jei musu ciklas butu while (true)
                }
                catch (FormatException ex)
                {
                    //Console.WriteLine($"Klaida: {ex.Message}");
                    //Console.WriteLine($"Stack Trace: {ex.StackTrace}");
                    Console.WriteLine($"Įvedėte ne skaičių, bandykite dar kartą");
                }
                catch (Exception ex) 
                {
                    throw ex;
                }
            }
            //Console.Write("Įveskite sveikąjį skaičių: ");
            //int skaicius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Ivedete toki skaiciu:{skaicius}");

        }
    }
}
