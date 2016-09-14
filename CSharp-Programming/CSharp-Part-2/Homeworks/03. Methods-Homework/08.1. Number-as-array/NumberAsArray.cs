using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Number_as_array
{
    class NumberAsArray
    {
        static void Main(string[] args)
        {
            string[] sizes = Console.ReadLine().Split(' ');
            int sizeA = int.Parse(sizes[0]);
            int sizeB = int.Parse(sizes[1]);

            string[] arrayA = Console.ReadLine().Split(' ');
            string[] arrayB = Console.ReadLine().Split(' ');
            int[] arrA = new int[sizeA];
            int[] arrB = new int[sizeB];

            // adding the values in the first array
            for (int i = 0; i < arrA.Length; i++)
            {
                arrA[i] = int.Parse(arrayA[i]);
            }
            // adding values in the second array
            for (int i = 0; i < arrB.Length; i++)
            {
                arrB[i] = int.Parse(arrayB[i]);
            }

            int maxLength = Math.Max(arrA.Length, arrB.Length);
            int[] sumArray = new int[maxLength];

            // resize the arrys with the max length
            Array.Resize(ref arrA, maxLength);
            Array.Resize(ref arrB, maxLength);


            sumArray = SumOfArrays(arrA, arrB, sumArray, maxLength);

            Console.Write(string.Join(" ", sumArray));
        }

        static int[] SumOfArrays(int[] A, int[] B, int[] Sum, int maxSize)
        {
            int sum = 0;
            bool remainder = false;

            for (int i = 0; i < maxSize; i++)
            {
                sum = A[i] + B[i];

                if (sum > 10)
                {
                    Sum[i] = A[i] + B[i] - 10;

                    if (remainder == true)
                    {
                        Sum[i] += 1; 
                    }

                    remainder = true;
                }
                else
                {
                    if (remainder == true)
                    {
                        Sum[i] = A[i] + B[i] + 1;
                    }

                    else
                    {
                        Sum[i] = A[i] + B[i];
                    }

                    remainder = false;
                    sum = 0;
                }
            }
            return Sum;
        }
    }
}
