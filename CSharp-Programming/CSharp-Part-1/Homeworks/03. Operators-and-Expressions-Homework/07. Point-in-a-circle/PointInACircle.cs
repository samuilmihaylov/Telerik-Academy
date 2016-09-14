using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Point_in_a_circle
{
    class PointInACircle
    {
        static void Main(string[] args)
        {
            double x = Double.Parse(Console.ReadLine());
            double y = Double.Parse(Console.ReadLine());

            double distance = Math.Sqrt(Math.Pow((x), 2) + Math.Pow((y), 2));

            bool check = Math.Pow((x - 0), 2) + Math.Pow((y - 0), 2) <= Math.Pow(2, 2);

            if (check)
            {
                Console.WriteLine("yes {0:0.00}", distance);
            }
            else
            {
                Console.WriteLine("no {0:0.00}", distance);
            }
        }
    }
}
