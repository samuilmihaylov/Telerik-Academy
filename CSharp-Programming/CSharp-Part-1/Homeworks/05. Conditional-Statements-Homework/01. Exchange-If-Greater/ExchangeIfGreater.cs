using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Exchange_If_Greater
{
    class ExchangeIfGreater
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C = 0;

            if (A > B)
            {
                C = B; // C = B // C = 3
                B = A; // B = А // B = 5
                A = C; // A = 3

                Console.WriteLine("{0} {1}", A, B);
            }

            else
            {
                Console.WriteLine("{0} {1}", A, B);
            }

        }
    }
}
