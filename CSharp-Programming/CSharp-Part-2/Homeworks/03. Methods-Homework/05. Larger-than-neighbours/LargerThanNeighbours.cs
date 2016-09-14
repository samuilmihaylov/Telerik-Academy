using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Larger_than_neighbours
{
    class LargerThanNeighbours
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            int count = 0;
            string[] values = Console.ReadLine().Split(' ');

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(values[i]);
            }
            count = LargerThanTheNeighbours(arr, count);
            Console.WriteLine(count);
        }

        static int LargerThanTheNeighbours(int[] array, int neighboursCount)
        {
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                {
                    neighboursCount++;
                }
            }

            return neighboursCount;
        }
    }
}
