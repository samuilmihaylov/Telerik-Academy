using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Reverse_number
{
    class ReverseNumber
    {
        static void Main(string[] args)
        {
            decimal number = decimal.Parse(Console.ReadLine());

            string reversedDecimal = "";
            reversedDecimal = ReverseDecimalNumber(number, reversedDecimal);
            Console.WriteLine(reversedDecimal);
        }

        static string ReverseDecimalNumber(decimal input, string reversed)
        {
            reversed = new string(input.ToString().Reverse().ToArray());

            return reversed;
        }
    }
}
