namespace _08.Binary_short
{
    using System;

    class BinaryShort
    {
        static void Main(string[] args)
        {
            short decimalValue = short.Parse(Console.ReadLine());

            string binary = "";

            for (int i = 15; i >= 0; i--)
            {
                binary = ((decimalValue % 2) & 1) + binary;
                decimalValue >>= 1;
            }

            Console.WriteLine(binary.PadLeft(16, '0'));
        }
    }
}
