namespace _10.Odd_and_Even_Product
{
    using System;
    using System.Numerics;

    class OddOrEvenProduct
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            while (inputNumber >= 4 && inputNumber <= 50)
            {
                string[] splitNumbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                BigInteger evenProduct = 1, oddProduct = 1, zero = 1;

                int[] numbers = new int[50];
                numbers = Array.ConvertAll(splitNumbers, int.Parse);

                for (int index = 0; index < inputNumber; index++)
                {
                    int value = numbers[index];

                    if ((index + 1) % 2 == 0 && index != 0)
                    {
                        evenProduct *= value;
                    }

                    if ((index + 1) % 2 == 1)
                    {
                        oddProduct *= value;
                    }
                }

                if (evenProduct == oddProduct)
                {
                    Console.WriteLine("yes {0}", evenProduct);
                    return;
                }
                else
                {
                    Console.WriteLine("no {0} {1}", oddProduct * zero, evenProduct);
                    return;
                }
            }
        }
    }
}
