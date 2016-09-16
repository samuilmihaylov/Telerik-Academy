namespace _16.Trailing_0_in_N_
{
    using System;

    class Trailling0inN
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            int zeroCounter = 0;

            if (inputNumber == 5)
            {
                zeroCounter = 1;
            }
            else
            {
                for (int index = 5; inputNumber / index >= 1; index *= 5)
                {
                    zeroCounter += inputNumber / index;
                }
            }
            Console.WriteLine(zeroCounter);
        }
    }
}
