namespace _07.Reverse_number
{
    using System;
    using System.Linq;

    class ReverseNumber
    {
        static void Main(string[] args)
        {
            decimal inputNumber = decimal.Parse(Console.ReadLine());
            string reversedDecimal = "";

            reversedDecimal = ReverseDecimalNumber(inputNumber, reversedDecimal);

            Console.WriteLine(reversedDecimal);
        }

        static string ReverseDecimalNumber(decimal input, string reversed)
        {
            reversed = new string(input.ToString().Reverse().ToArray());

            return reversed;
        }
    }
}
