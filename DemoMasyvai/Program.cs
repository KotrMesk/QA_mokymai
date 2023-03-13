using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMasyvai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //masyvai
            // masyvas is konkreciu reiksmiu
            int[] skaiciaiKonkretus = { 7, 6, 7, 32, 9, 3, 18, 25 };
            //masyvas konkretaus dydzio su default pagal tipa reiksmemis
            int[] skaiciaiTusti = new int[5];
            string[] zodziaiTusti = { "kate", "suo" };

            foreach (int skaicius in skaiciaiTusti)
            {
                Console.WriteLine(skaicius);
            }
            foreach (string zodziai in zodziaiTusti)
            {
                Console.WriteLine(zodziai);
            }

            // spausdiname masyvo reiksmes pagal indeksa
            Console.WriteLine(skaiciaiTusti[0]);

            //irasome masyvo reiksmes pagal indeksa
            skaiciaiTusti[0] = 5; //negali buti string nes jau nustatytas tipas apibreziant masyva, dydis taip pat yra nustatytas, papildomu reiksmiu negalima deti

            foreach (int skaicius in skaiciaiTusti)
            {
                // skaicius = 7; // su foreach to padaryti neimanoma
            }

            for (int i = 0; i < skaiciaiTusti.Length; i++)
            {
                Console.WriteLine(i);
            }

            //min/max
            int min = int.MaxValue;
            for (int i = 0; i <skaiciaiKonkretus.Length; i++)
            {
                if (skaiciaiKonkretus[i] < min)
                {
                    min = skaiciaiKonkretus[i];
                }
            }

            if (min != int.MaxValue)
            {
                //viskas gerai, min algoritmas ivyko
            }
            else
            {
                // liko numatytoji neaglima reiksme, kazkas kazkur ivyko blogai
            }
            Console.WriteLine($"Maziausia reiksme: {min}");
            foreach (int skaicius in skaiciaiKonkretus)
            {
                Console.Write($"{skaicius}, ");
            }
            Console.WriteLine();
        }
    }
}
