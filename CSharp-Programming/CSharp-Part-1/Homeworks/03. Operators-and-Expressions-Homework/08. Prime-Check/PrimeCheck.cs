namespace _08.Prime_Check
{
    using System;

    class PrimeCheck
    {
        static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine());

            if (inputNumber < 0 || inputNumber == 0 || inputNumber == 1)
            {
                Console.WriteLine("false");
            }
            else
            {
                for (int index = 2; index <= inputNumber / 2; index++)
                {
                    if (inputNumber % index == 0)
                    {
                        Console.WriteLine("false");
                        return;
                    }
                }
                Console.WriteLine("true");
            }
        }
    }
}
