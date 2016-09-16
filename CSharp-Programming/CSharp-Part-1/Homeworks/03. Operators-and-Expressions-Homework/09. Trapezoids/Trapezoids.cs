namespace _09.Trapezoids
{
    using System;

    class Trapezoids
    {
        static void Main(string[] args)
        {
            double trapezoidSideA = double.Parse(Console.ReadLine());
            double trapezoidSideB = double.Parse(Console.ReadLine());
            double trapezoidHeight = double.Parse(Console.ReadLine());

            double area = ((trapezoidSideA + trapezoidSideB) * trapezoidHeight) / 2;

            Console.WriteLine(area.ToString("F7"));
        }
    }
}
