using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Four_digits
{
    class FourDigits
    {
        static void Main(string[] args)
        {
            string stringNumber = Console.ReadLine();
            char[] array = stringNumber.ToCharArray();

            //first digit
            char a = stringNumber[0];

            //second digit
            char b = stringNumber[1];

            //third digit
            char c = stringNumber[2];

            //fourt digit
            char d = stringNumber[3];

            double sum = char.GetNumericValue(a) + char.GetNumericValue(b) + char.GetNumericValue(c) + char.GetNumericValue(d);

            Console.WriteLine(sum);
            Console.WriteLine("{0}{1}{2}{3}", d, c, b, a);
            Console.WriteLine("{0}{1}{2}{3}", d, a, b, c);
            Console.WriteLine("{0}{1}{2}{3}", a, c, b, d);

            // SECOND METHOD

            int intNumber = Int32.Parse(Console.ReadLine());

            int firstDigit = (intNumber / 1000) % 10;
            int secondDigit = (intNumber / 100) % 10;
            int thirdDigit = (intNumber / 10) % 10;
            int fourtDigit = (intNumber % 10);

            Console.WriteLine(firstDigit + secondDigit + thirdDigit + fourtDigit);
        }
    }
}
