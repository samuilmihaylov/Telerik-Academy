namespace _04.Multiplication_Sign
{
    using System;

    class MultiplicationSign
    {
        static void Main(string[] args)
        {
            double numberA = double.Parse(Console.ReadLine());
            double numberB = double.Parse(Console.ReadLine());
            double numberC = double.Parse(Console.ReadLine());

            bool isPositiveA = numberA > 0;
            bool isPositiveB = numberB > 0;
            bool isPositiveC = numberC > 0;

            if (isPositiveA && isPositiveB && isPositiveC)
            {
                Console.WriteLine("+");
            }
            else if (numberA == 0 || numberB == 0 || numberC == 0)
            {
                Console.WriteLine("0");
            }
            else if ((isPositiveA && (!isPositiveB && !isPositiveC)) ||
                (isPositiveB && (!isPositiveA && !isPositiveC)) ||
                ((!isPositiveA && !isPositiveB) && isPositiveC))
            {
                Console.WriteLine("+");
            }
            else if (!isPositiveA || !isPositiveB || !isPositiveC)
            {
                Console.WriteLine("-");
            }
        }
    }
}
