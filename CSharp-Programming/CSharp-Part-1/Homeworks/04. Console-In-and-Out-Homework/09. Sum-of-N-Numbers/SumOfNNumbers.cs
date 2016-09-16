namespace _09.Sum_of_n_Numbers
{
    using System;

    class SumOfNNumbers
    {
        static void Main(string[] args)
        {
            double totalSum = 0;

            int inputCountOfNumbers = int.Parse(Console.ReadLine());

            for (int i = 1; i <= inputCountOfNumbers; i++)
            {
                double inputNumber = double.Parse(Console.ReadLine());

                totalSum = totalSum + inputNumber;
            }

            Console.WriteLine(totalSum);
        }
    }
}
