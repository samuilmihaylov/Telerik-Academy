using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Biggest_of_5
{
    class BiggestOf5
    {
        static void Main(string[] args)
        {
            double val;
            double[] arr = new double[5];

            for (int i = 0; i < 5; i++)
            {
               val = double.Parse(Console.ReadLine());

                if (val <= 200 && val >= -200)
                {
                    arr[i] = val;
                }

            }
            double max = arr.Max();
            Console.WriteLine(max);
        }
    }
}
