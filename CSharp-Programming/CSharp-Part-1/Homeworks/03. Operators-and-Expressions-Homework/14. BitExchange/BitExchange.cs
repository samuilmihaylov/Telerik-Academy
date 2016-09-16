namespace _14.BitExchange
{
    using System;

    class BitExchange
    {
        static void Main(string[] args)
        {
            uint inputNumber = uint.Parse(Console.ReadLine());

            for (int i = 3, j = 24; i <= 5 && j <= 26; i++, j++)
            {
                // Get the value of i bit
                uint mask = (uint)1 << i;
                int iBit = (int)(inputNumber & mask) >> i;

                // Get the value of j bit
                mask = (uint)1 << j;
                int jBit = (int)(inputNumber & mask) >> j;

                if (iBit == 0)
                {
                    // Put 0 on j position
                    mask = (uint)~(1 << j);
                    inputNumber = (uint)(inputNumber & mask);
                }

                else if (iBit == 1)
                {
                    // Put 1 on j position
                    mask = (uint)1 << j;
                    inputNumber = (uint)(inputNumber | mask);
                }

                if (jBit == 0)
                {
                    // Put 0 on i position
                    mask = (uint)~(1 << i);
                    inputNumber = (uint)(inputNumber & mask);
                }

                else if (jBit == 1)
                {
                    // Put 1 on i position
                    mask = (uint)1 << i;
                    inputNumber = (uint)(inputNumber | mask);
                }
            }
            Console.WriteLine(inputNumber);
        }
    }
}
