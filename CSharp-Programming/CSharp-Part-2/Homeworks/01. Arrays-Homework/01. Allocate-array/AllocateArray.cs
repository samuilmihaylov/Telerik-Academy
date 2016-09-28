namespace _01.Allocate_arra
{
    using System;

    class AllocateArray
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(i * 5);
            }
        }
    }
}
