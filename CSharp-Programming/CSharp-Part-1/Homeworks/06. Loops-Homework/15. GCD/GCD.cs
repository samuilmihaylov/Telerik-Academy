namespace _15.GCD
{
    using System;

    class GCD
    {
        static void Main(string[] args)
        {
            string[] splitNumbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int firstNumber = Math.Abs(int.Parse(splitNumbers[0]));
            int secondNumber = Math.Abs(int.Parse(splitNumbers[1]));

            int gcd = 0;

            int remainder = firstNumber % secondNumber;

            while (remainder != 0)
            {
                remainder = firstNumber % secondNumber;
                firstNumber = secondNumber;
                secondNumber = remainder;
            }

            if (firstNumber != 0)
            {
                gcd = firstNumber;
                Console.WriteLine(gcd);
            }
            else
            {
                gcd = secondNumber;
                Console.WriteLine(gcd);
            }
        }
    }
}
