using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _16.Trailing_0_in_N_
{
    class Trailling0inN
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());

            int zeroCounter = 0;

            if (number == 5)
            {
                zeroCounter = 1;
            }

            else
            {
                for (int i = 5; number / i >= 1; i *= 5)
                {
                    zeroCounter += number / i;
                }
            }
            Console.WriteLine(zeroCounter);
        }
    }
}
