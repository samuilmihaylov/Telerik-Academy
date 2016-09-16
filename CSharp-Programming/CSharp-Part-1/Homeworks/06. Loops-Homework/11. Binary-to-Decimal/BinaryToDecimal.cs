namespace _11.Binary_to_Decimal
{
    using System;

    class BinaryToDecimal
    {
        static void Main(string[] args)
        {
            string binaryInput = Console.ReadLine();
            int binaryInputLength = binaryInput.Length;
            int[] binaryArr = new int[binaryInputLength];

            for (int i = 0; i < binaryInputLength; i++)
            {
                int value = 0;
                value = (int)Char.GetNumericValue(binaryInput[i]);
                binaryArr[i] = value;
            }

            Array.Reverse(binaryArr);

            long sum = 0;
            for (int j = 0; j < binaryInputLength; j++)
            {
                sum += binaryArr[j] * (long)(Math.Pow(2,j));
            }
            Console.WriteLine(sum);
        }
    }
}
