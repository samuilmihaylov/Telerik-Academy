using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.BitExchange
{
    class BitExchange
    {
        static void Main(string[] args)
        {
            uint N = uint.Parse(Console.ReadLine());

            for (int i = 3, j = 24; i<= 5 && j <= 26; i++, j++ )
            {
                    // get the value of i bit
                    uint mask = (uint)1 << i;
                    int iBit = (int)(N & mask) >> i;

                    // get the value of j bit
                    mask = (uint)1 << j;
                    int jBit = (int)(N & mask) >> j;

                    if (iBit == 0)
                    {
                        // put 0 on j position
                        mask = (uint)~(1 << j);
                        N = (uint)(N & mask);
                    }

                    else if (iBit == 1)
                    {
                        // put 1 on j position
                        mask = (uint)1 << j;
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
            }
            Console.WriteLine(N);
        }
    }
}
