using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Binary_to_Decimal
{
    class BinaryToDecimal
    {
        static void Main(string[] args)
        {
            string binaryInput = Console.ReadLine();
            int length = binaryInput.Length;
            int val = 0;
            long sum = 0;
            int[] binaryArr = new int[length];

            for (int i = 0; i < length; i++)
            {
                val = (int)Char.GetNumericValue(binaryInput[i]);
                binaryArr[i] = val;
            }

            Array.Reverse(binaryArr);

            for (int j = 0; j < length; j++)
            {
                sum += binaryArr[j] * (long)(Math.Pow(2,j));
            }
            Console.WriteLine(sum);
        }
    }
}
