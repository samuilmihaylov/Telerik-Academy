using System;
using System.Linq;

namespace _02.Get_largest_number
{
    class GetLargestNumber
    {
        static int GetMaximumValue(int[] input, int maxValue)
        {
            maxValue = input.Max();

            return maxValue;
        }

        static void Main(string[] args)
        {
            string[] values = Console.ReadLine().Split(' ');
            int maximumValue = 0;

            int[] array = new int[values.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(values[i]);
            }

            maximumValue = GetMaximumValue(array, maximumValue);
            
            Console.WriteLine(maximumValue);
        }
    }
}
