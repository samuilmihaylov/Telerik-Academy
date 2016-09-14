using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Calculate_
{
    class Calculate
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double factorial = 1;
            double S = 1 + 1 / x;

            for (int i = 2; i <= N; i++)
            {
                factorial *= i;
                double pow = Math.Pow(x, i);
                S += (factorial / pow);
            }

            Console.WriteLine("{0:F5}", S);
        }
    }
}
