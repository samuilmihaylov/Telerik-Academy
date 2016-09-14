using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _08.Catalan_Numbers
{
    class CatalanNumbers
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            BigInteger factorialN = 1;
            BigInteger factoril2N = 1;
            BigInteger subsFactorial = 1;

            for (int i = 2; i <= N; i++)
            {
                factorialN *= i;
            }

            for (int j = 2; j <= 2 * N; j++)
            {
                factoril2N *= j;
            }

            for (int m = 2; m <= N + 1; m++)
            {
                subsFactorial *= m;
            }
            Console.WriteLine(factoril2N/(subsFactorial*factorialN));
        }
    }
}
