namespace _08.Maximal_sum
{
    using System;

    class MaximalSum
    {
        static void Main(string[] args)
        {
            int arraySize = int.Parse(Console.ReadLine());
            int[] arr = new int[arraySize];
            int maxSum = int.MinValue;
            int currentSum = 0;

            for (int i = 0; i < arraySize; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

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

