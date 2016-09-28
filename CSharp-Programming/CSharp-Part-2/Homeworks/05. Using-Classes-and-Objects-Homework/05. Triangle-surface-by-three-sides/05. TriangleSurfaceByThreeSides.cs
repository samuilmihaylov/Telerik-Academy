namespace _05.Triangle_surface_by_three_sides
{
    using System;

    class Triangle
    {
        public double SideA;

        public double SideB;

        public double SideC;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Triangle myTriangle = new Triangle();

            myTriangle.SideA = double.Parse(Console.ReadLine());
            myTriangle.SideB = double.Parse(Console.ReadLine());
            myTriangle.SideC = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:F2}", Surface(FindSemiPerimeter(myTriangle.SideA, myTriangle.SideB, myTriangle.SideC), myTriangle.SideA, myTriangle.SideB, myTriangle.SideC));
        }

        static double FindSemiPerimeter(double sideA, double sideB, double sideC)
        {
            double semiPerimeter = 0;
            semiPerimeter = (sideA + sideB + sideC) / 2.0;

            return semiPerimeter;
        }

        static double Surface(double semiPerimeter, double sideA, double sideB, double sideC)
        {
            double surface = 0;
            surface = Math.Sqrt((semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC)));

            return surface;
        }
    }
}
