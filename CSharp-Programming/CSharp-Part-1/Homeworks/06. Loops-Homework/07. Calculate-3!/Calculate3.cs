using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _07.Calculate_3_
{
    class Calculate3
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());

            BigInteger factorialN = 1;
            BigInteger factorialK = 1;
            BigInteger factorialNK = 1;

            //N! / (K!*(N - K)!)

            // loop for (N - K)!
            for (BigInteger n = 2; n <= (N - K); n++)
            {
                factorialNK *= n;
            }

            // loop for K! and N!
            for (BigInteger i = 2, j = 2; i <= N || j <= K; i++, j++)
            {
                if (j <= K && i <= N)
                {
                    factorialN *= i;
                    factorialK *= j;
                }
                else if (j > K)
                {
                    factorialN *= i;
                }
                else if (i > K)
                {
                    factorialK *= j;
                }
            }
            Console.WriteLine(factorialN / (factorialK * factorialNK));
        }
    }
}

