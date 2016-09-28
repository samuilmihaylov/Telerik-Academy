namespace _05._1.HexadecimalToBinary
{
    using System;
    using System.Collections.Generic;

    class HexadecimalToBinary
    {
        static Dictionary<char, string> HexBin = new Dictionary<char, string>()
        {
            {'0', "0000"},
            {'1', "0001"},
            {'2', "0010"},
            {'3', "0011"},
            {'4', "0100"},
            {'5', "0101"},
            {'6', "0110"},
            {'7', "0111"},
            {'8', "1000"},
            {'9', "1001"},
            {'A', "1010"},
            {'B', "1011"},
            {'C', "1100"},
            {'D', "1101"},
            {'E', "1110"},
            {'F', "1111"}
        };

        static string HexToBinary(string hex)
        {
            // Simply replace hex digits by their binary equivalent
            string[] result = new string[hex.Length];

            for (int i = 0; i < hex.Length; i++)
            {
                result[i] = HexBin[hex[i]];
            }

            return string.Join(string.Empty, result);
        }

        static void Main()
        {
            string hexValue = Console.ReadLine();

            foreach (var hex in hexValue)
            {
                Console.WriteLine("{0,16}", HexToBinary(hexValue));
            }
        }
    }
}
