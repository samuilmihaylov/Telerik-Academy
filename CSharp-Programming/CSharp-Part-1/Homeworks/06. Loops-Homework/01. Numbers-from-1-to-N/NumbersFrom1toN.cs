namespace _01.Numbers_from_1_to_N
{
    using System;

    class NumbersFrom1toN
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            for (int index = 1; index <= inputNumber; index++)
            {
                Console.Write(index + " ");
            }
        }
    }
}
