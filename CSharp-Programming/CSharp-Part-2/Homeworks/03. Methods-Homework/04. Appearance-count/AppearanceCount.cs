namespace _04.Appearance_count
{
    using System;

    class AppearanceCount
    {
        static void Main(string[] args)
        {
            int arraySize = int.Parse(Console.ReadLine());
            string[] values = Console.ReadLine().Split(' ');

            int[] arr = new int[arraySize];
            int count = 0;

            int givenNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(values[i]);
            }

            count = Appearance_Count(arr, givenNumber, count);
            Console.WriteLine(count);
        }

        static int Appearance_Count(int[] array, int givenValue, int countAppearance)
        {
            foreach (int value in array)
            {
                if (value == givenValue)
                {
                    countAppearance++;
                }
            }

            return countAppearance;
        }
    }
}
