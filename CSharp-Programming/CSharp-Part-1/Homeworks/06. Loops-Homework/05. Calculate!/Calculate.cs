namespace _05.Calculate_
{
    using System;

    class Calculate
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());

            double factorial = 1;
            double sum = 1 + 1 / x;

            for (int index = 2; index <= N; index++)
            {
                factorial *= index;
                double pow = Math.Pow(x, index);
                sum += (factorial / pow);
            }

            Console.WriteLine("{0:F5}", sum);
        }
    }
}
