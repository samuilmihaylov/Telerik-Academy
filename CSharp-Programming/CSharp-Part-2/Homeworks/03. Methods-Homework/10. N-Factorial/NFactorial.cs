namespace _10.N_Factorial
{
    using System;
    using System.Numerics;

    class NFactorial
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Factorial(number);

            BigInteger factorial = Factorial(number);

            Console.WriteLine(factorial);
        }

        static BigInteger Factorial(int value)
        {
            BigInteger factorial = 1;

            for (int i = value; i > 0; i--)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
