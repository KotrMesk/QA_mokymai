using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMetodai
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            DemoMetodai.Program.Pasisveikinimas();
            Pasisveikinimas();
            Pasisveikinimas();
            Pasisveikinimas();
            Console.WriteLine(Calculator.Sum(5, 5));

            Calculator calculator = new Calculator();
            Console.WriteLine(Calculator.Difference(5, 5)); //nestatinis metodas
     
            Console.WriteLine();
            Calculator.DivisionByTwoUntilZero(20);
        }

        internal static void Pasisveikinimas()
        {
            Console.WriteLine("Hello World!");
        }

    }
}
