using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Biggest_of_3
{
    class BiggestOf3
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine());

            double biggestAB = Math.Max(A, B);
            double biggestAC = Math.Max(A, C);


            if (biggestAB > biggestAC)
            {
                Console.WriteLine(biggestAB);
            }
            else
            {
                Console.WriteLine(biggestAC);
            }

        }
    }
}
