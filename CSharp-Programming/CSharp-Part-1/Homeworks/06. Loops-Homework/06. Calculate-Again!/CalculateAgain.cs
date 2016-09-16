namespace _06.Calculate_Again_
{
    using System;
    using System.Numerics;

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
        }
    }
}
