namespace _08.Numbers_from_1_to_n
{
    using System;

    class NumbersFrom1ToN
    {
        static void Main(string[] args)
        {
            uint inputNumber = uint.Parse(Console.ReadLine());

            if (inputNumber < 1000 && inputNumber >= 1)
            {
                for (uint i = 1; i <= inputNumber; i++)
                    Console.WriteLine(i);
            }
        }
    }
}
