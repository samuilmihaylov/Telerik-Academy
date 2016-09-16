namespace _05.Biggest_of_3
{
    using System;

    class BiggestOf3
    {
        static void Main(string[] args)
        {
            double numberA = double.Parse(Console.ReadLine());
            double numberB = double.Parse(Console.ReadLine());
            double numberC = double.Parse(Console.ReadLine());

            double biggestAB = Math.Max(numberA, numberB);
            double biggestAC = Math.Max(numberA, numberC);

            if (biggestAB > biggestAC)
            {
                Console.WriteLine(biggestAB);
            }
            else
            {
                Console.WriteLine(biggestAC);
            }
        }
    }
}
