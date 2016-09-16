namespace _11.Interval
{
    using System;

    class Interval
    {
        static void Main(string[] args)
        {
            uint intervalStartNumber = uint.Parse(Console.ReadLine());
            uint intervalEndNumber = uint.Parse(Console.ReadLine());

            int numbersCount = 0;

            if (intervalStartNumber >= 0 && intervalEndNumber >= intervalStartNumber && intervalEndNumber <= 2000)
            {
                for (uint i = intervalStartNumber + 1; i < intervalEndNumber; i++)
                {
                    uint number = i % 5;

                    if (number == 0)
                    {
                        numbersCount++;
                    }
                }

                Console.WriteLine(numbersCount);
            }

        }
    }
}
