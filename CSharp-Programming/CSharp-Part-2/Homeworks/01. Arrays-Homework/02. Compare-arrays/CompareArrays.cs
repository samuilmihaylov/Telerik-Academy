using System;
using System.Linq;


namespace _02.Compare_arrays
{
    class CompareArrays
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] firstAray = new int[n];
            int[] secondArray = new int[n];

            for (int i = 0; i < firstAray.Length; i++)
            {
                firstAray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < secondArray.Length; i++)
            {
                secondArray[i] = int.Parse(Console.ReadLine());
            }

            if (firstAray.SequenceEqual(secondArray))
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }

        }
    }
}
