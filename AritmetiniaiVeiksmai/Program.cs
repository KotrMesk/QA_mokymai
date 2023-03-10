using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AritmetiniaiVeiksmai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // aritmetiniai veiksmai
            int skaicius1 = 5 + 5 * 2;
            int skaicius2 = (5 + 5) * 2;
            Console.WriteLine(skaicius1 + skaicius2);
            Console.WriteLine();
            // dalyba
            int dalmuo1 = 7 / 3; // grazina sveikaja dali
            int dalmuo2 = 7 % 3; // liekanos operacija
            double dalmuo3 = 7.0 / 3; //float - 8 skaiciai viso, double - daugiau skaiciu
            float dalmuo4 = 7.0f / 3; 
            double dalmuo5 = 7.0f / 3; // float dalybos rezultata galime laikyti kaip double reiksme
            double dalmuo6 = (double)7 / 3; //casting, nurodo kad kintamasis yra su trupmena
            Console.WriteLine(dalmuo1);
            Console.WriteLine(dalmuo2);
            Console.WriteLine(dalmuo3);
            Console.WriteLine(dalmuo4);
            Console.WriteLine(dalmuo5);
            Console.WriteLine(dalmuo6);
            Console.WriteLine();
            //casting
            int dalinys = 7;
            int daliklis = 3;
            double dalmuo7 = (double)dalinys / daliklis;
            Console.WriteLine(dalmuo7);
            Console.WriteLine();
            // machinacijos
            Console.WriteLine(dalinys /daliklis * 1.0);
            Console.WriteLine(dalinys * 1.0 / daliklis);
            Console.WriteLine();
            //math biblioteka
            Console.WriteLine(Math.Pow(5, 2)); //kubu
            Console.WriteLine(Math.Pow(9, 0.5)); //kvadratine saknis
            Console.WriteLine();
            //kintamojo reiksmes didinimas, mazinimas, dalinimas, daugyba
            int skaicius3 = 7;
            skaicius3 = skaicius3 + 5;
            skaicius3 += skaicius3; //trumpesne ansktesnio veiksmo israiska
            //tas pats galioja dalybai, atimciai ir daugybai
            Console.WriteLine(skaicius3);
            Console.WriteLine();
            //kintamojo reiksmezs didinimas/mazinimas vienetu
            int skaicius4 = 20;
            Console.WriteLine(skaicius4++); //pirma parasome o tada padidiname
            Console.WriteLine(skaicius4);
            
            skaicius4 = 20;
            Console.WriteLine(++skaicius4); // pirma padidiname poto parasome
            //Console.WriteLine(--skaicius4); - atimtis
         
        }
    }
}
