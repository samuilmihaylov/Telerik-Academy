using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Decimal_to_Hex
{
    class DecimalToHex
    {
        static void Main(string[] args)
        {
            long decNum = long.Parse(Console.ReadLine());

            if (decNum == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                string hexNum = "";

                while (decNum > 0)
                {
                    long checkRemainder = decNum % 16;
                    string remainder = "";

                    switch (checkRemainder)
                    {
                        case 10: remainder = "A"; break;
                        case 11: remainder = "B"; break;
                        case 12: remainder = "C"; break;
                        case 13: remainder = "D"; break;
                        case 14: remainder = "E"; break;
                        case 15: remainder = "F"; break;
                        default: remainder = checkRemainder.ToString(); break;
                    }
                    hexNum = remainder + hexNum;
                    decNum /= 16;
                }

                Console.WriteLine(hexNum);
            }
        }

    }
}
