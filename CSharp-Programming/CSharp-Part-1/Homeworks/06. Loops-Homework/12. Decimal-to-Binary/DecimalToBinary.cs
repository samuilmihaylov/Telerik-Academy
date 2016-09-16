namespace _12.Decimal_to_Binary
{
    using System;

    class DecimalToBinary
    {
        static void Main(string[] args)
        {
            long decimalInputNumber = long.Parse(Console.ReadLine());

            string binaryString = "";

            if (decimalInputNumber == 0)
            {
                binaryString += '0';
            }

            while (decimalInputNumber > 0)
            {
                if (decimalInputNumber % 2 == 1)
                {
                    binaryString += '1';
                }
                else if (decimalInputNumber % 2 == 0)
                {
                    binaryString += '0';
                }
                decimalInputNumber = decimalInputNumber / 2;
            }
            char[] charArray = binaryString.ToCharArray();
            Array.Reverse(charArray);
            
            Console.WriteLine(charArray);
        }
    }
}
