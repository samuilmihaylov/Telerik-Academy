using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _10.Fibonacci_Numbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            ulong a = 0;
            ulong b = 1;
            ulong temp = 0;

            uint N = uint.Parse(Console.ReadLine());

            ulong[] fibArr = new ulong[N];

            if (N >= 1 && N <= 50)
            {
                for (int i = 1; i < N; i++)
                {
                    temp = a + b;
                    a = b;
                    b = temp;

                    fibArr[i] = (ulong)a;
                }
            }
            Console.WriteLine(string.Join(", ", fibArr));
        }
    }
}
