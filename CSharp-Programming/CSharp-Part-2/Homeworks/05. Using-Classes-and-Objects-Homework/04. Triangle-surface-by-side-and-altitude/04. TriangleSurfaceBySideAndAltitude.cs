using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Triangle_surface_by_side_and_altitude
{
    class Triangle
    {
        public decimal side;

        public decimal altitude;
    }

    class TriangleSurfaceBySideAndAltitude
    {
        static void Main(string[] args)
        {
            Triangle myTriangle = new Triangle();

            myTriangle.side = decimal.Parse(Console.ReadLine());
            myTriangle.altitude = decimal.Parse(Console.ReadLine());

            Console.WriteLine("{0:F2}",Surface(myTriangle.side, myTriangle.altitude));
        } 

        static decimal Surface(decimal A, decimal H)
        {
            decimal surface = 0;
            surface = (A * H) / 2;
            return surface;
        }
    }
}
