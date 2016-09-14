using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Moon_Gravity
{
    class MoonGravity
    {
        static void Main(string[] args)
        {
            double W = Convert.ToDouble(Console.ReadLine()); // вкарваме променливата Weight

            double weightOnMoon = W * 17 / 100;

            Console.WriteLine(weightOnMoon.ToString("N3"));
        }
    }
}
