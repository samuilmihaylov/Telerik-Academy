using System;
using System.Numerics;

namespace _01.Decimal_to_binary
{
    class DeciamlToBinary
    {
        static void Main(string[] args)
        {
            BigInteger decimalNumber = BigInteger.Parse(Console.ReadLine()); // entering the decimal numbers

            string binary = DecimalToBinaryConverter(decimalNumber); // calling the method

            Console.WriteLine(binary);
        }

        static string DecimalToBinaryConverter(BigInteger number)
        {
            BigInteger remainder = 0;
            string result = "";

            while (number > 0) // 1 / 2 = 0, while number = 1
            {
                remainder = number % 2; // 1 % 2 = 1, 1 left as remainder
                number /= 2;
                result = remainder.ToString() + result;
            }

            return result;
        }
    }
}
