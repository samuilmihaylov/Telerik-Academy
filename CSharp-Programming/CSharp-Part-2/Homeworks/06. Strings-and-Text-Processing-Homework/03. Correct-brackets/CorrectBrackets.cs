namespace _03.Correct_brackets
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            int countLeft = 0, countRight = 0;

            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] == '(')
                {
                    countLeft++;
                }

                if (inputString[i] == ')')
                {
                    countRight++;
                }
            }

            if (countLeft == countRight)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
        }
    }
}
