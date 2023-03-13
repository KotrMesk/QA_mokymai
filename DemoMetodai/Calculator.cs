using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMetodai
{
    internal class Calculator
    {
        internal static int Sum(int num1, int num2)
        {
           return num1 + num2;
        }

        internal int Difference(int num1, int num2)
        {
            return num1 - num2;
        }

        //rekursinis metodas (kviecia pats save)
        internal static void DivisionByTwoUntilZero (int number)
        {
            Console.WriteLine(number);
            //svarbu tureti isejimo salyga
            if (number != 0)
            {
                int numberDivided = number/ 2;
                DivisionByTwoUntilZero(numberDivided);
            }
        }
    }
}
