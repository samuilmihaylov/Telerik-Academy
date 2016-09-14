using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Threading.Tasks;
using _10.Point__Circle__Rectangle;

namespace _10.Point__Circle__Rectangle
{
    class PointCircleRectangle
    {
        static void Main(string[] args)
        {
            double x = Double.Parse(Console.ReadLine());
            double y = Double.Parse(Console.ReadLine());

            //K({1, 1}, 1.5)
            bool insideCircle = Math.Pow((x - 1), 2) + Math.Pow((y - 1), 2) <= Math.Pow(1.5, 2);

            //R(top=1, left=-1, width=6, height=2)
            // (x >= rLeft) && (x <= (rLeft + rWidth)) && (y <= rTop) && (y >= (rTop - rHeight)) = true за да е inside
            bool insideRectangle = (x >= -1) && (x <= (-1 + 6)) && (y <= 1) && (y >= (1 - 2));

            if (insideCircle == true && insideRectangle == true)
            {
                Console.WriteLine("inside circle inside rectangle");
            }
            else if (insideCircle == true && insideRectangle == false)
            {
                Console.WriteLine("inside circle outside rectangle");
            }
            else if (insideCircle == false && insideRectangle == true)
            {
                Console.WriteLine("outside circle inside rectangle");
            }
            else if (insideCircle == false && insideRectangle == false)
            {
                Console.WriteLine("outside circle outside rectangle");
            }
        }
    }
}
