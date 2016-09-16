namespace _01.Sum_of_3_numbers
{
    using System;

    class SumOf3Numbers
    {
        static void Main(string[] args)
        {
            float numberA = float.Parse(Console.ReadLine());
            float numberB = float.Parse(Console.ReadLine());
            float numberC = float.Parse(Console.ReadLine());

            float totalSum = numberA + numberB + numberC;

            Console.WriteLine(totalSum);
        }
    }
}
