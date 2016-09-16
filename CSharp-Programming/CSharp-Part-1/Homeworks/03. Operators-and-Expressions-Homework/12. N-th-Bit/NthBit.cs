namespace _12.N_th_bit
{
    using System;

    class NthBit
    {
        static void Main(string[] args)
        {

            long inputNumber = long.Parse(Console.ReadLine());

            byte inputIndexOfBit = byte.Parse(Console.ReadLine());  

            long nRightP = inputNumber >> inputIndexOfBit; 

            long bit = nRightP & 1; 

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
