using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Remove_elements_from_array
{
    class RemoveElementsFromArray
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];
            int minIndex = 0;
            int current = 0;
            int elToRemove = 0;
            int maxElToRemove = 0;
            int subSequenceCount = 0;

            for (int i = 0; i < length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int min = arr[0];

            for (int i = 0; i < length; i++)
            {
                if (arr[i] < min && i != length - 1)  // finding the minimum value in the arr[]
                {
                    min = arr[i]; // minimum value in array
                    minIndex = i; // the index of minimum value              
                }
            }

            for (int i = 0; i < minIndex; i++)
            {
                elToRemove++;
            }

            for (int j = minIndex + 1; j < length; j++) // starting from the next index of the minimum value
            {
                current = arr[j]; // next value after the min

                for (int i = j + 1; i < length; i++) // starting from the value after the current
                {
                    int numToCompare = arr[i];

                    if (current > numToCompare && current != min)
                    {
                        elToRemove++;
                        break;
                    }

                    if (current == min)
                    {

                        maxElToRemove = elToRemove + subSequenceCount;

                        elToRemove = 0;
                        subSequenceCount = 0;
                    }

                    else if (current < numToCompare)
                    {
                        subSequenceCount++;
                        break;
                    }
                }
            }
            Console.WriteLine(maxElToRemove);
        }
    }
}

