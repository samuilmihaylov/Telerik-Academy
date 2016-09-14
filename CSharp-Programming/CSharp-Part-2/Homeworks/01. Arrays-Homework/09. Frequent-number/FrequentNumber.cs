using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Frequent_number
{
    class FrequentNumber
    {
        static void Main(string[] args)
        {
            int arraySize = int.Parse(Console.ReadLine());
            int[] arr = new int[arraySize];

            int maxCount = 0;
            int element = 0;

            for (int i = 0; i < arraySize; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arraySize; i++)
            {
                int tempCount = 1;
                int tempElement = arr[i];

                for (int j = i + 1; j < arraySize; j++)
                {
                    if (tempElement == arr[j])
                    {
                        tempCount++;
                    }

                    if (tempCount > maxCount)
                    {
                        maxCount = tempCount;
                        element = tempElement;
                    }
                }
            }
            Console.WriteLine("{0} ({1} times)",element, maxCount);
        }
    }
}
