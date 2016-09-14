using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MMSA_of_N_Numbers
{
    class MMSAofNNumbers
    {
        static void Main(string[] args)
        {


            int N = int.Parse(Console.ReadLine());

            double[] arrMax = new double[N];
            double[] arrMin = new double[N];
            double value = 0;
            double sum = 0;

            for (int i = 0; i < N; i++)
            {
                value = double.Parse(Console.ReadLine());

                arrMax[i] = value;
                arrMin[i] = value;
                sum += value;
            }

            double avg = sum / N;

            Console.WriteLine("min={0}", arrMin.Min().ToString("F2"));
            Console.WriteLine("max={0}", arrMax.Max().ToString("F2"));
            Console.WriteLine("sum={0}", sum.ToString("F2"));
            Console.WriteLine("avg={0}", avg.ToString("F2"));
        }
    }
}
