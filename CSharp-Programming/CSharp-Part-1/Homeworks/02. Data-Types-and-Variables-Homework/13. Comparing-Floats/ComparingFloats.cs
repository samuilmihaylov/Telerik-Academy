namespace _13.Comparing_Floats
{
    using System;

    class ComparingFloats
    {
        static void Main(string[] args)
        {
            double numberA = double.Parse(Console.ReadLine());
            double numberB = double.Parse(Console.ReadLine());
            double eps = 0.000001;

            if ((Math.Abs(numberA - numberB) <= eps))
            {
                Console.WriteLine("The numbers are equal");
            }
            else
            {
                Console.WriteLine("The numbers are not equal");
            }
        }
    }
}
