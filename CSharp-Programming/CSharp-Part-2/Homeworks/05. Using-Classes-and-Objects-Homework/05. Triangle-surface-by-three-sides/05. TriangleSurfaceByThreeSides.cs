using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Triangle_surface_by_three_sides
{

    class Triangle
    {
        public double sideA;
        public double sideB;
        public double sideC;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Triangle myTriangle = new Triangle();

            myTriangle.sideA = double.Parse(Console.ReadLine());
            myTriangle.sideB = double.Parse(Console.ReadLine());
            myTriangle.sideC = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:F2}", Surface(semiPerimeter(myTriangle.sideA, myTriangle.sideB, myTriangle.sideC), myTriangle.sideA, myTriangle.sideB, myTriangle.sideC));
        }

        static double semiPerimeter(double A, double B, double C)
        {
            double semiPerimeter = 0;
            semiPerimeter = (A + B + C) / 2.0;

            return semiPerimeter;
        }

        static double Surface(double semiP, double A, double B, double C)
        {
            double surface = 0;
            surface = Math.Sqrt((semiP*(semiP - A)* (semiP - B)* (semiP - C)));
            return surface;
        }
    }
}
