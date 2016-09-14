using System;
using System.Linq;

namespace _02.Get_largest_number
{
    class GetLargestNumber
    {
        static int getMax(int[] input, int maxValue)
        {
            maxValue = input.Max();
            return maxValue;
        }

        static void Main(string[] args)
        {
            string[] values = Console.ReadLine().Split(' ');
            int max = 0;

            int[] arr = new int[values.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(values[i]);
            }

            max = getMax(arr, max);
            
            Console.WriteLine(max);
        }
    }
}
