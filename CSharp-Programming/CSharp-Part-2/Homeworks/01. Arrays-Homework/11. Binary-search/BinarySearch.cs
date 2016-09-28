namespace _11.Binary_search
{
    using System;

    class BinarySearch
    {
        static void Main(string[] args)
        {
            int arraySize = int.Parse(Console.ReadLine());
            int[] numbers = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                // enter the values in the array
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int x = int.Parse(Console.ReadLine());

            int stepBrS = arraySize / 2;

            int possition = stepBrS;

            if (numbers[0] == x)
            {
                possition = 0;
            }

            else
            {
                while (stepBrS >= 1)
                {
                    stepBrS /= 2;

                    if (numbers[possition] == x) 
                    {
                        // the middle element
                        break;
                    }
                    else if (numbers[possition] < x)
                    {
                        // if the number is lower than x, index moves to the right
                        possition += stepBrS;
                    }
                    else
                    {
                        // if the number is greater than x, the index moves to the left
                        possition -= stepBrS;
                    }
                }
            }
            Console.WriteLine(numbers[possition] != x ? "-1" : "{0}", possition);
        }
    }
}