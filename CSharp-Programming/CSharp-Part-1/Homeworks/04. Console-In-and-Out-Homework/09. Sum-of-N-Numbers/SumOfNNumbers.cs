using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Sum_of_n_Numbers
{
    class SumOfNNumbers
    {
        static void Main(string[] args)
        {
            double result = 0;

            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)

            {
                double val = double.Parse(Console.ReadLine());

                result = result + val;
            }

            Console.WriteLine(result);
        }
    }
}
