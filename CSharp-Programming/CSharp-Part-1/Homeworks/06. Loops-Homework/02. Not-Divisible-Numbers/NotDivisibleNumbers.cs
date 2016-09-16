namespace _02.Not_Divisible_Numbers
{
    using System;

    class NotDivisibleNumbers
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            for (int index = 1; index <= inputNumber; index++)
            {
                if (index % 3 != 0 && index % 7 != 0)
                {
                    Console.Write(index + " ");
                }
            }
        }
    }
}
