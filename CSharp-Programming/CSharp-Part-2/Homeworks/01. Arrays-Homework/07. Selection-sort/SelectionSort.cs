using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Selection_sort
{
    class SelectionSort
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }


            for (int i = 0; i < size - 1; i++)
            {
                int iMin = i;

                for (int j = i + 1; j < size; j++)
                {
                    Console.WriteLine("array[j] " + array[j] + " array[iMin] " + array[iMin]);
                    if (array[j] < array[iMin])
                    {
                        iMin = j;
                    }
                }
                if (iMin != i)
                {
                    var temp = array[i];
                    array[i] = array[iMin];
                    array[iMin] = temp;
                }

                Console.WriteLine(array[i]);
                if (i == size - 2)
                {
                    Console.WriteLine(array[i + 1]);
                }
            }
        }
    }
}
