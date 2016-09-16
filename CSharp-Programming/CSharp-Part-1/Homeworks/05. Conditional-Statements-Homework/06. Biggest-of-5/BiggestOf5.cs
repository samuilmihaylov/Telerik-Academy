namespace _06.Biggest_of_5
{
    using System;
    using System.Linq;

    class BiggestOf5
    {
        static void Main(string[] args)
        {
            double inputNumber;
            double[] array = new double[5];

            for (int index = 0; index < 5; index++)
            {
               inputNumber = double.Parse(Console.ReadLine());

                if (inputNumber <= 200 && inputNumber >= -200)
                {
                    array[index] = inputNumber;
                }
            }
            double maxNumberInArray = array.Max();

            Console.WriteLine(maxNumberInArray);
        }
    }
}
