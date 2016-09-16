namespace _09.Print_Sequence
{
    using System;

    class PrintSequence
    {
        static void Main(string[] args)
        {
            for (int number = 2; number <= 11; number++)
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
