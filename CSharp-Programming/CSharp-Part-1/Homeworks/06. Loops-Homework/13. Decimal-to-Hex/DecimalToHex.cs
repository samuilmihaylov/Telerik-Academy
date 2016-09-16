namespace _13.Decimal_to_Hex
{
    using System;

    class DecimalToHex
    {
        static void Main(string[] args)
        {
            long deciamlInputNumber = long.Parse(Console.ReadLine());

            if (deciamlInputNumber == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                string hexadecimalNumberAsString = "";

                while (deciamlInputNumber > 0)
                {
                    long checkRemainder = deciamlInputNumber % 16;
                    string remainder = "";

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
                    hexadecimalNumberAsString = remainder + hexadecimalNumberAsString;
                    deciamlInputNumber /= 16;
                }

                Console.WriteLine(hexadecimalNumberAsString);
            }
        }
    }
}
