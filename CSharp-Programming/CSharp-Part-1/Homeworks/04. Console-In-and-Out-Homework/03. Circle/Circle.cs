using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _03.Circle
{
    class Circle
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            double circleArea = Math.PI * Math.Pow(r, 2);
            double circlePerimeter = 2 * Math.PI * r;

            Console.WriteLine(circlePerimeter.ToString("F2", CultureInfo.InvariantCulture) + " " + circleArea.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
