namespace _01.Exchange_If_Greater
{
    using System;

    class ExchangeIfGreater
    {
        static void Main(string[] args)
        {
            double numberA = double.Parse(Console.ReadLine());
            double numberB = double.Parse(Console.ReadLine());

            double temporalNumber = 0;

            if (numberA > numberB)
            {
                temporalNumber = numberB; // C = B // C = 3
                numberB = numberA; // B = А // B = 5
                numberA = temporalNumber; // A = 3

                Console.WriteLine("{0} {1}", numberA, numberB);
            }
            else
            {
                Console.WriteLine("{0} {1}", numberA, numberB);
            }
        }
    }
}
