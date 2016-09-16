namespace _06.Quadratic_Equation
{
    using System;

    class QuadraticEquation
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double D = Math.Pow(b, 2) - (4 * a * c);

            if (D < 0)
            {
                Console.WriteLine("no real roots");

                return;
            }

            if (D > 0)
            {
                double rootOne = (-b + Math.Sqrt(D)) / (2 * a);

                double rootTwo = (-b - Math.Sqrt(D)) / (2 * a);

                double smaller = Math.Min(rootOne, rootTwo);
                double bigger = Math.Max(rootOne, rootTwo);

                Console.WriteLine(smaller.ToString("F2"));
                Console.WriteLine(bigger.ToString("F2"));

                return;
            }

            if (D == 0)
            {
                double theOnlyOneRoot = (-b / (2 * a));

                Console.WriteLine(theOnlyOneRoot.ToString("F2"));

                return;
            }
        }
  
    }
}
