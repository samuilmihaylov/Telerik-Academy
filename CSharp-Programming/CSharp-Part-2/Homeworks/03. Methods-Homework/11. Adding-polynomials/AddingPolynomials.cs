using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Adding_polynomials
{
    class AddingPolynomials
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            string[] arrayA = Console.ReadLine().Split(' ');
            string[] arrayB = Console.ReadLine().Split(' ');

            int[] arrA = new int[N];
            int[] arrB = new int[N];

            arrA = fillArray(arrA, arrayA);
            arrB = fillArray(arrB, arrayB);

            int[] sumArray = new int[N];

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
