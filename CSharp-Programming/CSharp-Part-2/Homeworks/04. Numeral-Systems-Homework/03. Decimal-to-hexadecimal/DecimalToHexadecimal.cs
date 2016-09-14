using System;
using System.Numerics;

namespace _03.Decimal_to_hexadecimal
{
    class DecimalToHexadecimal
    {
        static void Main(string[] args)
        {
            BigInteger decimalNumber = BigInteger.Parse(Console.ReadLine()); // entering a decimal number
           
            Console.WriteLine(DecimalToHexadecimalNumber(decimalNumber));
        }

        static string DecimalToHexadecimalNumber(BigInteger dec) 
        {
            string hexValue = "";

            while (dec > 0)
            {
                string remainder = "";
                long checkRemainder = (long)dec % 16;

                switch (checkRemainder) // taking the remainder to form the hexadecimal
                {
                    case 10: remainder = "A"; break;
                    case 11: remainder = "B"; break;
                    case 12: remainder = "C"; break;
                    case 13: remainder = "D"; break;
                    case 14: remainder = "E"; break;
                    case 15: remainder = "F"; break;
                    default: remainder = checkRemainder.ToString(); break; // if you enter any other number {1 , 2 .. 9}, you convert it in string
                }

                hexValue = remainder + hexValue;
                dec /= 16;
            }
            return hexValue;
        }
    }
}
