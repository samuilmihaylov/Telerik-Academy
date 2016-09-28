namespace _18.Remove_elements_from_array
{
    using System;

    class RemoveElementsFromArray
    {
        static void Main(string[] args)
        {
            int arraySize = int.Parse(Console.ReadLine());
            int[] arr = new int[arraySize];
            int minIndex = 0;
            int current = 0;
            int elToRemove = 0;
            int maxElToRemove = 0;
            int subSequenceCount = 0;

            for (int i = 0; i < arraySize; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int min = arr[0];

            for (int i = 0; i < arraySize; i++)
            {
                if (arr[i] < min && i != arraySize - 1)  
                {
                    min = arr[i]; 
                    minIndex = i;            
                }
            }

            for (int i = 0; i < minIndex; i++)
            {
                elToRemove++;
            }

            for (int j = minIndex + 1; j < arraySize; j++) 
            {
                current = arr[j]; 

                for (int i = j + 1; i < arraySize; i++) 
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

