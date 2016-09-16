namespace _15.BitSwap
{
    using System;

    class BitSwap
    {
        static void Main(string[] args)
        {
            uint inputNumber = uint.Parse(Console.ReadLine());
            int indexOfTheFirstBit = int.Parse(Console.ReadLine());
            int indexOfTheSecondBit = int.Parse(Console.ReadLine());
            int endBit = int.Parse(Console.ReadLine());

            int bitCount = 0;

            for (int i = indexOfTheFirstBit; i < indexOfTheFirstBit + endBit; i++)
            {
                // Get the value of i bit
                uint mask = (uint)1 << i;
                int iBit = (int)(inputNumber & mask) >> i;

                // Get the value of j bit
                mask = (uint)1 << indexOfTheSecondBit + bitCount;
                int jBit = (int)(inputNumber & mask) >> indexOfTheSecondBit + bitCount;

                if (iBit == 0)
                {
                    // Put 0 on j position
                    mask = (uint)~(1 << indexOfTheSecondBit + bitCount);
                    inputNumber = (uint)(inputNumber & mask);
                }

                else if (iBit == 1)
                {
                    // Put 1 on j position
                    mask = (uint)1 << indexOfTheSecondBit + bitCount;
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
                bitCount++;
            }
            Console.WriteLine(inputNumber);

            return;
        }
    }
}
