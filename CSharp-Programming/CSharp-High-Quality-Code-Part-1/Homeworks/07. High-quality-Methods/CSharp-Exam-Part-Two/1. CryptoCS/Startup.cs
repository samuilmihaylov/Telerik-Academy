namespace _1.CryptoCS
{
    using System;
    using System.Numerics;

    public class Startup
    {
        public static void Main()
        {
            string numberIn26BaseSystem = Console.ReadLine();
            string operand = Console.ReadLine();
            string numberIn7BaseSystem = Console.ReadLine();

            BigInteger base26ToDecimal = 0;

            foreach (var digit in numberIn26BaseSystem)
            {
                base26ToDecimal = (digit - 'a') + (base26ToDecimal * 26); 
            }

            BigInteger base7ToDecimal = 0;

            foreach (var digit in numberIn7BaseSystem)
            {
                base7ToDecimal = (digit - '0') + (base7ToDecimal * 7); 
            }

            BigInteger totalDecimalNumber = 0;

            if (operand == "+")
            {
                totalDecimalNumber = base26ToDecimal + base7ToDecimal;
            }
            else if (operand == "-")
            {
                totalDecimalNumber = base26ToDecimal - base7ToDecimal;
            }

            byte digitIn9BaseSystem = 0;

            string numberIn9BaseSystem = string.Empty;

            do
            {
                digitIn9BaseSystem = (byte) (totalDecimalNumber % 9);
                numberIn9BaseSystem = digitIn9BaseSystem + numberIn9BaseSystem;
                totalDecimalNumber /= 9;
            }
            while (totalDecimalNumber > 0);

            Console.WriteLine(numberIn9BaseSystem);
        }
    }
}
