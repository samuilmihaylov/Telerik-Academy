namespace _16.Long_Sequence
{
    using System;

    class LongSequence
    {
        static void Main(string[] args)
        {
            for (int number = 2; number <= 1001; number++)
            {
                if (number % 2 != 0)
                {
                    Console.WriteLine("-" + number);
                }
                else
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
