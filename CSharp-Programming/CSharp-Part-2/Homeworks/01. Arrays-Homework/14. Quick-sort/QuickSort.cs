namespace _14.Quick_sort
{
    using System;

    public class QuickSort
    {
        public static void Main()
        {
            int arraySize = int.Parse(Console.ReadLine());
            int[] arr = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                arr[i] = int.Parse(Console.ReadLine()); 
            }

            QuicSortAlgorithm(arr, 0, arraySize - 1); 

            for (int i = 0; i < arraySize; i++) 
            {
                Console.WriteLine(arr[i]);
            }
        }

        public static void QuicSortAlgorithm(int[] arr, int left, int right)
        {

            int pivotIndex = (left + right) / 2;
            int leftIndex = left;
            int rightindex = right;
            int pivot = arr[pivotIndex]; 

            while (leftIndex <= rightindex)
            {
                while (arr[leftIndex] < pivot)
                {
                    leftIndex++;
                }

                while (arr[rightindex] > pivot)
                {
                    rightindex--;
                }

                if (leftIndex <= rightindex)
                {
                    int temp = arr[leftIndex];
                    arr[leftIndex] = arr[rightindex];
                    arr[rightindex] = temp;
                    leftIndex++;
                    rightindex--;
                }

                if (left < rightindex)
                {
                    QuicSortAlgorithm(arr, left, rightindex);
                }

                if (leftIndex < right)
                {
                    QuicSortAlgorithm(arr, leftIndex, right);
                }
            }
        }
    }
}
