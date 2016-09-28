namespace _11.Adding_polynomials
{
    using System;

    class AddingPolynomials
    {
        static void Main(string[] args)
        {
            int arraySize = int.Parse(Console.ReadLine());

            string[] arrayA = Console.ReadLine().Split(' ');
            string[] arrayB = Console.ReadLine().Split(' ');

            int[] arrA = new int[arraySize];
            int[] arrB = new int[arraySize];

            arrA = fillArray(arrA, arrayA);
            arrB = fillArray(arrB, arrayB);

            int[] sumArray = new int[arraySize];
            sumArray = SumOfThePolynomials(arrA, arrB, sumArray);

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

        static int[] SumOfThePolynomials(int[] A, int[] B, int[] Sum)
        { 
            for (int i = 0; i < Sum.Length; i++)
            {
                Sum[i] = A[i] + B[i];
            }

            return Sum;
        }
    }
}
