using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _06.Calculate_Again_
{
    class CalculateAgain
    {
        static void Main(string[] args)
        {
            BigInteger N = BigInteger.Parse(Console.ReadLine());
            BigInteger K = BigInteger.Parse(Console.ReadLine());

            BigInteger factorial = 1;

            while (1 < K && K < N)
            {
                for (BigInteger i = N; i > K; i--)
                {
                    factorial *= i;
                }

                Console.WriteLine(factorial);
                return;
            }

            //BigInteger N = BigInteger.Parse(Console.ReadLine());
            //BigInteger K = BigInteger.Parse(Console.ReadLine());

            //BigInteger factorialN = 1;
            //BigInteger factorialK = 1;

            //while (1 < K && K < N)
            //{
            //    for (BigInteger i = 2, j = 2; i <= N || j <= K; i++, j++)
            //    {
            //        if (j <= K && i <= N)
            //        {
            //            factorialN *= i;
            //            factorialK *= j;
            //        }
            //        else if (j > K)
            //        {
            //            factorialN *= i;
            //        }
            //        else if (i > K)
            //        {
            //            factorialK *= j;
            //        }
            //    }

            //    Console.WriteLine((factorialN / factorialK));
            //    return;
            //}

        }
    }
}
