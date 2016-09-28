namespace _06.First_larger_than_neighbours
{
    using System;

    class FirstLargerThanNeighbours
    {
        static void Main(string[] args)
        {
            int arraySize = int.Parse(Console.ReadLine());
            string[] values = Console.ReadLine().Split(' ');

            int[] arr = new int[arraySize];
            int position = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(values[i]);
            }

            position = FirstLargerThanTheNeighbours(arr, position);

            Console.WriteLine(position);
        }

        static int FirstLargerThanTheNeighbours(int[] array, int index)
        {
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                {
                    index = i;
                    break;
                }
                else
                {
                    index = -1;
                }
            }

            return index;
        }
    }
}
