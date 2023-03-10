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
            Console.WriteLine($"Jus ivedete tai: {Console.ReadLine()}"); //galime ir taip parasyti kad input, bet sunkiai ji skaito

            Console.WriteLine("Iveskite simboli: "); 
            int symbolAsciiCode = Console.Read(); //nuskaito tik pirma simboli, jei ivedete daugiau simboliu ir antra karta iskviesite console.read() jis tiesiog nuskaitys antra simboli is pirmos eilutes
            Console.WriteLine($"Ivedete simboli: {((char)symbolAsciiCode)}"); // konvertavimas i char, casting
            Console.WriteLine($"Ivedi simboli: {Convert.ToChar(symbolAsciiCode)}"); //kreipimasis i console kad konvertuotu

            Console.ReadLine(); //po console.read butina deti console.readline kad neskaitytu nesamoniu ir tolimesnius ivedimus nuskaitytu
            Console.WriteLine();

            //string skaicius = "5";
            //Convert.ToUInt32(skaicius); //'5'
            //int.Parse(skaicius); //'5'

            // Ivedimo i console problemos
            Console.WriteLine("Iveskite sveikaji skaiciu: ");
            int skaicius = Convert.ToInt32( Console.ReadLine() );
            Console.WriteLine($"Ivedete toki skaiciu:{skaicius}");

            

        }
    }
}
