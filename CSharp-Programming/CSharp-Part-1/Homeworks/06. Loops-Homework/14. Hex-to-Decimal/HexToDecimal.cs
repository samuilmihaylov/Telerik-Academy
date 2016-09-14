using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Hex_to_Decimal
{
    class HexToDecimal
    {
        static void Main(string[] args)
        {
            string hexNum = Console.ReadLine();

            long decNum = 0;

            for (int i = 0; i < hexNum.Length; i++)
            {
                int multiplier;

                    switch (hexNum[hexNum.Length - i - 1])
                    {
                        case 'A':
                        multiplier = 10;
                            break;
                        case 'B':
                        multiplier = 11;
                            break;
                        case 'C':
                        multiplier = 12;
                            break;
                        case 'D':
                        multiplier = 13;
                            break;
                        case 'E':
                        multiplier = 14;
                            break;
                        case 'F':
                        multiplier = 15;
                            break;
                    default:
                        multiplier = int.Parse(hexNum[hexNum.Length - i - 1].ToString());
                        break;
                }
                decNum += multiplier * (long)Math.Pow(16, i);
            }
            Console.WriteLine(decNum);
        }
    }
}

