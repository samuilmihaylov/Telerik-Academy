namespace _03.Decimal_to_hexadecimal
{
    using System;
    using System.Numerics;

    class DecimalToHexadecimal
    {
        static void Main(string[] args)
        {
            BigInteger decimalNumber = BigInteger.Parse(Console.ReadLine()); // entering a decimal number
           
            Console.WriteLine(DecimalToHexadecimalNumber(decimalNumber));
        }

        static string DecimalToHexadecimalNumber(BigInteger decimalNumber) 
        {
            string hexValue = "";

            while (decimalNumber > 0)
            {
                string remainder = "";
                long checkRemainder = (long)decimalNumber % 16;

                // taking the remainder to form the hexadecimal
                switch (checkRemainder) 
                {
                    case 10: remainder = "A"; break;
                    case 11: remainder = "B"; break;
                    case 12: remainder = "C"; break;
                    case 13: remainder = "D"; break;
                    case 14: remainder = "E"; break;
                    case 15: remainder = "F"; break;
                    // if you enter any other number {1 , 2 .. 9}, you convert it in string
                    default: remainder = checkRemainder.ToString(); break; 
                }

                hexValue = remainder + hexValue;
                decimalNumber /= 16;
            }

            return hexValue;
        }
    }
}
