namespace _08.Sum_integers
{
    using System;

    class SumIntegers
    {
        static void Main(string[] args)
        {
            string stringValues = Console.ReadLine();

            Console.WriteLine(SumOfIntegers(ArrayOfIntegers(stringValues)));
        }

        static int[] ArrayOfIntegers(string input)
        {
            string[] splitedIntegers = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int[] IntegersArray = new int[splitedIntegers.Length];

            for (int i = 0; i < splitedIntegers.Length; i++)
            {
                IntegersArray[i] = int.Parse(splitedIntegers[i]);
            }

            return IntegersArray;
        }

        static int SumOfIntegers(int[] intArray)
        {
            int sum = 0;

            foreach (int value in intArray)
            {
                sum += value;
            }

            return sum;
        }
    }
}
