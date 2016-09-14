using System;
using System.Linq;
using System.Numerics;


namespace _14.Integer_calculations
{
    class IntegerCalculations
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ');
            int[] arr = new int[array.Length];
            arr = fillArray(arr, array);

            int minimum = MinimumValue(arr);
            int maximum = MaximumValue(arr);
            int sum = SumOfArray(arr);
            BigInteger product = ProductOfArray(arr);
            float average = AverageOfAray(arr, sum, arr.Length);

            Console.Write(" {0}\n {1}\n {2:F2}\n {3}\n {4}\n", minimum, maximum, average, sum, product);

        }


        static BigInteger ProductOfArray(int[] array)
        {
            BigInteger prod = 1;
            foreach (int value in array)
            {
                prod *= value;
            }
            return prod;
        }

        static int SumOfArray(int[] array)
        {
            int sum = array.Sum();
            return sum;
        }

        static int MinimumValue(int[] array)
        {
            int min = array.Min();
            return min;
        }

        static int MaximumValue(int[] array)
        {
            int max = array.Max();
            return max;
        }

        static float AverageOfAray(int[] array, int sum, int size)
        {
            float avg = sum / (float)size;
            return avg;
        }


        static int[] fillArray(int[] arrayToFill, string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                arrayToFill[i] = int.Parse(array[i]);
            }
            return arrayToFill;
        }
    }
}
