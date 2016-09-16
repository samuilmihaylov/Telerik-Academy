namespace _11._3rd_Bit
{
    using System;

    class ThirdBit
    {
        static void Main(string[] args)
        {

            uint inputNumber = UInt32.Parse(Console.ReadLine());

            int index = 3;

            // Move the bits of the numbers with the desired index, the target bit goes to the first position.
            uint nRightP = inputNumber >> index; 

            // 0 => 0 и 1 gives 0, then the last bit equals 0;
            uint bit = nRightP & 1; 

            if (bit == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine("1");
            }
        }
    }
}
