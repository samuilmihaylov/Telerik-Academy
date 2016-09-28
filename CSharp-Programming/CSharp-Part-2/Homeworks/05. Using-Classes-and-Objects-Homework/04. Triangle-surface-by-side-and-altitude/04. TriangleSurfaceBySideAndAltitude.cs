namespace _04.Triangle_surface_by_side_and_altitude
{
    using System;

    class Triangle
    {
        public decimal Side;

        public decimal Altitude;
    }

    class TriangleSurfaceBySideAndAltitude
    {
        static void Main(string[] args)
        {
            Triangle myTriangle = new Triangle();

            myTriangle.Side = decimal.Parse(Console.ReadLine());
            myTriangle.Altitude = decimal.Parse(Console.ReadLine());

            Console.WriteLine("{0:F2}", Surface(myTriangle.Side, myTriangle.Altitude));
        }

        static decimal Surface(decimal side, decimal height)
        {
            decimal surface = 0;
            surface = (side * height) / 2;

            return surface;
        }
    }
}
