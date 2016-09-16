namespace _10.Fibonacci_Numbers
{
    using System;

    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            ulong a = 0;
            ulong b = 1;
            ulong temp = 0;

            uint countOfFibonacciNumbers = uint.Parse(Console.ReadLine());

            ulong[] fibArr = new ulong[countOfFibonacciNumbers];

            if (countOfFibonacciNumbers >= 1 && countOfFibonacciNumbers <= 50)
            {
                for (int index = 1; index < countOfFibonacciNumbers; index++)
                {
                    temp = a + b;
                    a = b;
                    b = temp;

                    fibArr[index] = (ulong)a;
                }
            }
            Console.WriteLine(string.Join(", ", fibArr));
        }
    }
}
