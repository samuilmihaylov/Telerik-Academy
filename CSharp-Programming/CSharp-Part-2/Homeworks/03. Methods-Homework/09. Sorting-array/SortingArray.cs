using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Sorting_array
{
    class SortingArray
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            string[] array = Console.ReadLine().Split(' ');
            int[] arr = new int[size];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(array[i]);
            }

            int[] sortedArr = new int[size];
           

            sortedArr = ArraySort(arr);
            Console.WriteLine(string.Join(" ", sortedArr));
        }

        static int[] ArraySort(int[] array)
        {
            Array.Sort(array);
            return array;
        }
    }
}
