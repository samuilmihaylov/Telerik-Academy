using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Maximal_sum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] arr = new int[N];
            int maxSum = int.MinValue;
            int currentSum = 0;

            for (int i = 0; i < N; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

                //int val = arr[i];

                currentSum += arr[i];

                if (currentSum < arr[i])
                {
                    currentSum = arr[i];
                }

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                }
            }
            Console.WriteLine(maxSum);
        }
    }
}

