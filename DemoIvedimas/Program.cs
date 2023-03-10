using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoIvedimas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite savo varda:");
            string ivedimas = Console.ReadLine();
            Console.WriteLine($"Ivedei tai:{ivedimas}");

            //read() bei readline()
            Console.WriteLine("Iveskite dar ka nors:");
            Console.WriteLine($"Jus ivedete tai: {Console.ReadLine()}"); //galime ir taip parasyti kad input

            Console.WriteLine("Iveskite simboli: "); //po console.read butina deti console.readline kad neskaitytu nesamoniu ir tolimesnius ivedimus nuskaitytu
            int symbolAsciiCode = Console.Read(); //nuskaito tik pirma simboli, jei ivedete daugiau simboliu ir antra karta iskviesite console.read() jis tiesiog nuskaitys antra simboli is pirmos eilutes
            Console.WriteLine($"Ivedete simboli: {((char)symbolAsciiCode)}"); // konvertavimas i char, casting
            Console.WriteLine($"Ivedi simboli: {Convert.ToChar(symbolAsciiCode)}"); //kreipimasis i console kad konvertuotu

            string skaicius = "5";
            Convert.ToUInt32(skaicius); //'5'
            int.Parse(skaicius); //'5'
        }
    }
}
