namespace _15.Prime_numbers
{
    using System;

    class PrimeNumbers
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length + 1];
            int maxPrime = 0;

            for (int i = 2; i <= length; i++)
            {
                // Adding elements to array
                arr[i] = i; 
            }
            for (int i = 2; i < arr.Length; i++)
            {
                if (i % 2 == 0 && i != 2)
                {
                    arr[i] = 0;
                }
                if (arr[i] != 0 && i != 2) 
                {
                    for (int j = i; j < arr.Length; j += i) 
                    {
                        if (j != i)
                        {
                            arr[j] = 0;
                        }
                    }
                }
                if (arr[i] != 0)
                {
                    if (maxPrime <= arr[i])
                    {
                        maxPrime = arr[i];
                    }
                }
            }
            Console.WriteLine(maxPrime);
        }
    }
}
