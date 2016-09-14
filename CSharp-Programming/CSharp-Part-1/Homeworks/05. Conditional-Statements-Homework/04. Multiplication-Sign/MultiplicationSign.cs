using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Multiplication_Sign
{
    class MultiplicationSign
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine());

            bool positiveA = A > 0;
            bool positiveB = B > 0;
            bool positiveC = C > 0;

            if (positiveA == true && positiveB == true && positiveC == true)
            {
                Console.WriteLine("+");
            }
            else if (A == 0 || B == 0 || C == 0)
            {
                Console.WriteLine("0");
            }
            else if ((positiveA == true && (positiveB == false && positiveC == false))
            || (positiveB == true && (positiveA == false && positiveC == false)) || ((positiveA == false && positiveB == false) && positiveC == true))
            {
                Console.WriteLine("+");
            }
            else if (positiveA == false || positiveB == false || positiveC == false)
            {
                Console.WriteLine("-");
            }
        
        }
    }
}
