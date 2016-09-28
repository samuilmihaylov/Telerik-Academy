namespace _02.Binary_to_decimal
{
    using System;
    using System.Numerics;

    class BinaryToDecimal
    {
        static void Main(string[] args)
        {
            string binaryString = Console.ReadLine();
 
            Console.WriteLine(BinaryToDecimalNumber(binaryString));
        }

        static BigInteger BinaryToDecimalNumber(string input)
        {
            char[] charArray = input.ToCharArray();
            BigInteger numberInDecimal = 0;

            Array.Reverse(charArray);
 
            for (int i = 0; i < charArray.Length; i++)
            {
                int bit = (int)Char.GetNumericValue(charArray[i]);

                if (bit == 1)
                {
                    numberInDecimal += (BigInteger)Math.Pow(2, i);
                }
            }

            return numberInDecimal;
        }
    }
}
