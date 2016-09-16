namespace _01.Odd_or_Even
{
    using System;

    class OddOrEven
    {
        static void Main(string[] args)
        {
            int inputNumber = Convert.ToInt32(Console.ReadLine());

            if ((inputNumber % 2) == 0)
            {
                Console.WriteLine("even {0}", inputNumber);
            }
            else
            {
                Console.WriteLine("odd {0}", inputNumber);
            }
        }
    }
}
