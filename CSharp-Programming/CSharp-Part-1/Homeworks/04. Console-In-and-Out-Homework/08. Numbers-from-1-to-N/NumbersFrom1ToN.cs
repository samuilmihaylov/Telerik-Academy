using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Numbers_from_1_to_n
{
    class NumbersFrom1ToN
    {
        static void Main(string[] args)
        {
            // 1 <= N < 1000

            uint N = uint.Parse(Console.ReadLine());

            if (N < 1000 && N >= 1)
            {
                for (uint i = 1; i <= N; i++)
                    Console.WriteLine(i);
            }
        }
    }
}
