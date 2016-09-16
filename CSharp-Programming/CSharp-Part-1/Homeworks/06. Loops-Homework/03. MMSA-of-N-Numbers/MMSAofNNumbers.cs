namespace _03.MMSA_of_N_Numbers
{
    using System;
    using System.Linq;

    class MMSAofNNumbers
    {
        static void Main(string[] args)
        {
            int inputCountOfNumber = int.Parse(Console.ReadLine());

            double[] arrayOfNumbers = new double[inputCountOfNumber];

            double inputNumber = 0;
            double totalSum = 0;

            for (int i = 0; i < inputCountOfNumber; i++)
            {
                inputNumber = double.Parse(Console.ReadLine());

                arrayOfNumbers[i] = inputNumber;
                totalSum += inputNumber;
            }

            double average = totalSum / inputCountOfNumber;

            Console.WriteLine("min={0}", arrayOfNumbers.Min().ToString("F2"));
            Console.WriteLine("max={0}", arrayOfNumbers.Max().ToString("F2"));
            Console.WriteLine("sum={0}", totalSum.ToString("F2"));
            Console.WriteLine("avg={0}", average.ToString("F2"));
        }
    }
}
