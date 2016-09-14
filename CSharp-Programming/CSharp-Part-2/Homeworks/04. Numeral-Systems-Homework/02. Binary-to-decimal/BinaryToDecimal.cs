using System;
using System.Numerics;


namespace _02.Binary_to_decimal
{
    class BinaryToDecimal
    {
        static void Main(string[] args)
        {
            string binaryString = Console.ReadLine(); // entering the binary number
 
            Console.WriteLine(BinaryToDecimalNumber(binaryString));
        }

        static BigInteger BinaryToDecimalNumber(string input)
        {
            char[] charArray = input.ToCharArray(); // creating an array of chars because we want to reverse it 
            Array.Reverse(charArray);
            BigInteger numberInDecimal = 0;

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
