namespace _05.Numbers_Comparer
{
    using System;

    class NumbersComparer
    {
        static void Main(string[] args)
        {
            double numberA = double.Parse(Console.ReadLine());
            double numberB = double.Parse(Console.ReadLine());

            double biggerNumber = Math.Max(numberA, numberB);
            Console.WriteLine(biggerNumber);         
        }
    }
}
