using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Quick_sort
{
    public class QuickSort
    {
        public static void Main()
        {
            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine()); // enter the elements in the array
            }

            QuicSortAlgorithm(arr, 0, length - 1); // calling the algorithm

            for (int i = 0; i < length; i++) // printing the sorted array
            {
                Console.WriteLine(arr[i]);
            }
        }

        public static void QuicSortAlgorithm(int[] arr, int left, int right)
        {

            int pivotIndex = (left + right) / 2; // setting the index of pivot element from the array
            int leftIndex = left; // 0
            int rightindex = right; // length - 1
            int pivot = arr[pivotIndex]; // the pivot element

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
