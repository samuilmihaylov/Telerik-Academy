namespace _04.Hexadecimal_to_decimal
{
    using System;
    using System.Numerics;

    class HexadecimalToDecimal
    {
        static void Main(string[] args)
        {
            string hexadecimalNumber = Console.ReadLine();

            Console.WriteLine(HexadecimalToDecimalNumber(ReverseArray(hexadecimalNumber)));
        }

        static char[] ReverseArray(string arrayToReverse)
        {
            char[] reversedArray = arrayToReverse.ToCharArray(); 

            Array.Reverse(reversedArray);

            return reversedArray;
        }

        static BigInteger HexadecimalToDecimalNumber(char[] hex)
        {
            BigInteger numberInDecimal = 0;

            for (int i = 0; i < hex.Length; i++)
            {
                int valueInDecimal;
                switch (hex[i])
                {
                    case 'A': valueInDecimal = 10; break;
                    case 'B': valueInDecimal = 11; break;
                    case 'C': valueInDecimal = 12; break;
                    case 'D': valueInDecimal = 13; break;
                    case 'E': valueInDecimal = 14; break;
                    case 'F': valueInDecimal = 15; break;
                    default: valueInDecimal = int.Parse(hex[i].ToString()); break;
                }
                numberInDecimal += valueInDecimal * (BigInteger)Math.Pow(16, i);
            }

            return numberInDecimal;
        }
    }
}
