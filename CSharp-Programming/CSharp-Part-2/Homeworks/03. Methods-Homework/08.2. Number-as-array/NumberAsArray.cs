namespace _08._1.Number_as_array
{
    using System;
    using System.Linq;

    class NumberAsArray
    {
        static void Main(string[] args)
        {
            string[] sizes = Console.ReadLine().Split(' ');
            int sizeA = int.Parse(sizes[0]);
            int sizeB = int.Parse(sizes[1]);

            string[] arrayA = Console.ReadLine().Split(' ');
            string[] arrayB = Console.ReadLine().Split(' ');
            arrayA.Reverse();
            arrayB.Reverse();

            int[] arrA = new int[sizeA];
            int[] arrB = new int[sizeB];
            arrA = fillArray(arrA, arrayA);
            arrB = fillArray(arrB, arrayB);

            int maxLength = Math.Max(arrA.Length, arrB.Length);
            int[] sumArray = new int[maxLength];

            sumArray = SumOfArrays(arrA, arrB, sumArray);
            Console.Write(string.Join(" ", sumArray));
        }

        static int[] fillArray(int[] arrayToFill, string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                arrayToFill[i] = int.Parse(array[i]);
            }

            return arrayToFill;
        }

        static int[] SumOfArrays(int[] A, int[] B, int[] Sum)
        {
            int remainder = 0;

            for (int i = 0; i < Sum.Length; i++)
            {
                int num = (i < A.Length ? A[i] : 0) + (i < B.Length ? B[i] : 0) + remainder;
                Sum[i] = (num % 10);
                remainder = num / 10;
            }

            return Sum;
        }
    }
}
