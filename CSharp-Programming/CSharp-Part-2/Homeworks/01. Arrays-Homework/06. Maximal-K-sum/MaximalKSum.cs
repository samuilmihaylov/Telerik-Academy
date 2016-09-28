namespace _06.Maximal_K_sum
{
    using System;

    class MaximalKSum
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];

            int elements = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int el = int.Parse(Console.ReadLine());
                arr[i] = el;
            }

            Array.Sort(arr);
            Array.Reverse(arr);

            for (int i = 0; i < elements; i++)
            {
                sum += arr[i];
            }

            Console.WriteLine(sum);
        }
    }
}
