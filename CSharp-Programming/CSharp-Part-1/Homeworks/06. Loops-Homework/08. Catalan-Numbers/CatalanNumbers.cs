namespace _08.Catalan_Numbers
{
    using System;
    using System.Numerics;

    class CatalanNumbers
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            BigInteger factorialN = 1;
            BigInteger factoril2N = 1;
            BigInteger subsFactorial = 1;

            for (int i = 2; i <= inputNumber; i++)
            {
                factorialN *= i;
            }

            for (int j = 2; j <= 2 * inputNumber; j++)
            {
                factoril2N *= j;
            }

            for (int m = 2; m <= inputNumber + 1; m++)
            {
                subsFactorial *= m;
            }
            Console.WriteLine(factoril2N/(subsFactorial*factorialN));
        }
    }
}
