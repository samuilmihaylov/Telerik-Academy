namespace _01.Decimal_to_binary
{
    using System;
    using System.Numerics;

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

            while (number > 0)
            {
                remainder = number % 2;
                number /= 2;
                result = remainder.ToString() + result;
            }

            return result;
        }
    }
}
