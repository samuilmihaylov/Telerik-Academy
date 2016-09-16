namespace _13.Modify_Bit
{
    using System;

    class ModifyBit
    {
        static void Main(string[] args)
        {
            ulong inputNumber = ulong.Parse(Console.ReadLine());

            byte inputIndexOfBit = byte.Parse(Console.ReadLine());

            byte inputBitValue = byte.Parse(Console.ReadLine());

            if (inputIndexOfBit >= 0 && inputIndexOfBit < 64)
            {
                if (inputBitValue == 1)
                {
                    ulong mask = (ulong)1 << inputIndexOfBit;
                    ulong newNumber = inputNumber | mask;
                    Console.WriteLine(newNumber);
                }

                if (inputBitValue == 0)
                {
                    ulong mask = (ulong)~(1 << inputIndexOfBit);
                    ulong newNumber = inputNumber & mask;
                    Console.WriteLine(newNumber);
                }
            }
        }
    }
}
