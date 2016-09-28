namespace _14.Integer_calculations
{
    using System;
    using System.Linq;
    using System.Numerics;

    class IntegerCalculations
    {
        static void Main(string[] args)
        {
            string[] inputStringArray = Console.ReadLine().Split(' ');

            int[] array = new int[inputStringArray.Length];
            array = fillArray(array, inputStringArray);

            int minimum = FindMinimumValue(array);
            int maximum = FindMaximumValue(array);

            int sum = SumOfArray(array);

            BigInteger product = ProductOfArray(array);

            float average = AverageValueOfArray(array, sum, array.Length);

            Console.Write(" {0}\n {1}\n {2:F2}\n {3}\n {4}\n", minimum, maximum, average, sum, product);
        }

        static BigInteger ProductOfArray(int[] array)
        {
            BigInteger product = 1;

            foreach (int value in array)
            {
                product *= value;
            }

            return product;
        }

        static int SumOfArray(int[] array)
        {
            int sum = array.Sum();

            return sum;
        }

        static int FindMinimumValue(int[] array)
        {
            int minimumValue = array.Min();

            return minimumValue;
        }

        static int FindMaximumValue(int[] array)
        {
            int maximumValue = array.Max();

            return maximumValue;
        }

        static float AverageValueOfArray(int[] array, int sum, int length)
        {
            float averageValue = sum / (float)length;

            return averageValue;
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
