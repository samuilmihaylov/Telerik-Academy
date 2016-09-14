using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Interval
{
    class Interval
    {
        static void Main(string[] args)
        {
            uint N = uint.Parse(Console.ReadLine());
            uint M = uint.Parse(Console.ReadLine());

            int count = 0;

            if (N >= 0 && M >= N && M <= 2000)
            {
                for (uint i = N + 1; i < M; i++)
                {
                    uint number = i % 5;

                    if (number == 0)
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);

            }

        }
    }
}
