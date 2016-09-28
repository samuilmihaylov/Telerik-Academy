namespace _06.Triangle_surface_by_two_sides_and_an_angle
{
    using System;

    class Triangle
    {
        public double SideA;

        public double SideB;

        public double Degrees;
    }

    class TriangleSurfaceByTwoSidesAndAnAngle
    {
        static void Main(string[] args)
        {
            Triangle myTriangle = new Triangle();

            myTriangle.SideA = double.Parse(Console.ReadLine());
            myTriangle.SideB = double.Parse(Console.ReadLine());
            myTriangle.Degrees = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:F2}", Surface(CalculateSinus(myTriangle.Degrees), myTriangle.SideA, myTriangle.SideB));
        }

        static double CalculateSinus(double degrees)
        {
            double angle = Math.PI * degrees / 180.0;
            double sinAngle = Math.Sin(angle);

            return sinAngle;
        }

        static double Surface(double angleC, double sideA, double sideB)
        {
            double surface = 0;
            surface = (sideA * sideB * angleC) / 2.0;

            return surface;
        }
    }
}
