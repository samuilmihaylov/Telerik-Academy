namespace _06.Binary_to_hexadecimal
{
    using System;
    using System.Numerics;

    class BinaryToHexadecimal
    {
        static void Main(string[] args)
        {
            string binaryInput = Console.ReadLine();

            BigInteger numberInDecimal = 0;
            char[] charArray = binaryInput.ToCharArray();

            Array.Reverse(charArray);

            for (int i = 0; i < charArray.Length; i++)
            {
                int bit = (int)Char.GetNumericValue(charArray[i]);

                if (bit == 1)
                {
                    numberInDecimal += (BigInteger)Math.Pow(2, i);
                }
            }

            string hexValue = "";
            while (numberInDecimal > 0)
            {
                string remainder = "";
                long checkRemainder = (long)numberInDecimal % 16;

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

                hexValue = remainder.ToString() + hexValue;
                numberInDecimal /= 16;
            }
            Console.WriteLine(hexValue);
        }
    }
}
