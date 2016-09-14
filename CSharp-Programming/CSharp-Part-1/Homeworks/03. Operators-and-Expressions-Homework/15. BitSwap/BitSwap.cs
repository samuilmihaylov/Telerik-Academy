using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.BitSwap
{
    class BitSwap
    {
        static void Main(string[] args)
        {
            uint N = uint.Parse(Console.ReadLine()); // input for number n

            int p = int.Parse(Console.ReadLine()); // position of first bit
            int q = int.Parse(Console.ReadLine()); // position of second bit
            int k = int.Parse(Console.ReadLine()); // end bit
            int countBit = 0;

            for (int i = p; i < p + k; i++)
            {
                // get the value of i bit
                uint mask = (uint)1 << i;
                int iBit = (int)(N & mask) >> i;

                // get the value of j bit
                mask = (uint)1 << q + countBit;
                int jBit = (int)(N & mask) >> q + countBit;

                if (iBit == 0)
                {
                    // put 0 on j position
                    mask = (uint)~(1 << q + countBit);
                    N = (uint)(N & mask);
                }

                else if (iBit == 1)
                {
                    // put 1 on j position
                    mask = (uint)1 << q + countBit;
                    N = (uint)(N | mask);
                }

                if (jBit == 0)
                {
                    // put 0 on i position
                    mask = (uint)~(1 << i);
                    N = (uint)(N & mask);
                }

                else if (jBit == 1)
                {
                    // put 1 on i position
                    mask = (uint)1 << i;
                    N = (uint)(N | mask);
                }
                countBit++;
            }
            Console.WriteLine(N);
            return;
        }
    }
}
