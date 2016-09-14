using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Triangle_surface_by_two_sides_and_an_angle
{
    class Triangle
    {
        public double sideA;
        public double sideB;
        public double degrees;
    }

    class TriangleSurfaceByTwoSidesAndAnAngle
    {
        static void Main(string[] args)
        {
            Triangle myTriangle = new Triangle();

            myTriangle.sideA = double.Parse(Console.ReadLine());
            myTriangle.sideB = double.Parse(Console.ReadLine());
            myTriangle.degrees = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:F2}", Surface(CalculateSin(myTriangle.degrees), myTriangle.sideA, myTriangle.sideB));
        }

        static double CalculateSin(double deg)
        {
            double angle = Math.PI * deg / 180.0;
            double sinAngle = Math.Sin(angle);

            return sinAngle;
        }

        static double Surface(double angleC, double A, double B)
        {
            double surface = 0;
            surface = (A * B * angleC) / 2.0;

            return surface;
        }
    }
}
