using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Binary_search
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int[] numbers = new int[length];

            for (int i = 0; i < length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine()); // enter the values in the array
            }

            int x = int.Parse(Console.ReadLine()); // enter the value of desired index 

            int stepBrS = length / 2;

            int possition = stepBrS;

            if (numbers[0] == x) // if it's the first element
            {
                possition = 0;
            }

            else
            {
                while (stepBrS >= 1)
                {
                    stepBrS /= 2;

                    if (numbers[possition] == x) // the middle element
                    {
                        break;
                    }
                    else if (numbers[possition] < x) // if the number is lower than x, index moves to the right
                    {
                        possition += stepBrS;
                    }
                    else                             // if the number is greater than x, the index moves to the left
                    {
                        possition -= stepBrS;
                    }
                }
            }
            Console.WriteLine(numbers[possition] != x ? "-1" : "{0}", possition);
        }
    }
}


    //static void Main(string[] args)
    //{
    //    int arraySize = int.Parse(Console.ReadLine());
    //    int[] arr = new int[arraySize];

    //    int index = 0;

    //    for (int i = 0; i < arraySize; i++)
    //    {
    //        arr[i] = int.Parse(Console.ReadLine()); // add elements in array
    //    }

    //    int targetValue = int.Parse(Console.ReadLine());

    //    int middle = arraySize / 2;

    //    if (targetValue == arr[middle]) // comparing the middle element of the array with the target value
    //    {
    //        index = middle;
    //    }

    //    else if (targetValue > arr[middle]) // comparing the elements bigger than the middle element
    //    {
    //        for (int i = middle; i < arraySize; i++)
    //        {
    //            if (targetValue == arr[i])
    //            {
    //                index = i;
    //            }
    //        }
    //    }

    //    else if (targetValue < arr[middle]) // comparing the elements smaller than the middle element
    //    {
    //        for (int i = 0; i < middle; i++)
    //        {
    //            if (targetValue == arr[i])
    //            {
    //                index = i;
    //            }
    //        }
    //    }

    //    if (index == 0) // if there's no occurences
    //    {
    //        index = -1;
    //    }

    //    Console.WriteLine(index);
    //}

