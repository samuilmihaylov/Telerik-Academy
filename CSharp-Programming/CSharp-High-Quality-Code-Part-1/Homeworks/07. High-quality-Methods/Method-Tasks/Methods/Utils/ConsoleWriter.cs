namespace Methods.Utils
{
    using System;

    public class ConsoleWriter
    {
        public static void PrintInConsoleAsNumberInGivenFormat(object number, string format)
        {
            if (number == null)
            {
                throw new ArgumentNullException("Number cannot be null.");
            }

            if (string.IsNullOrEmpty(format))
            {
                throw new ArgumentNullException("Format cannot be null.");
            }

            decimal parsedNumber;
            var isParsed = decimal.TryParse(number.ToString(), out parsedNumber);
            if (!isParsed)
            {
                throw new ArgumentException("Invalid number.");
            }

            if (format == "f")
            {
                Console.WriteLine("{0:f2}", number);
            }
            else if (format == "%")
            {
                Console.WriteLine("{0:p0}", number);
            }
            else if (format == "r")
            {
                Console.WriteLine("{0,8}", number);
            }
            else
            {
                throw new ArgumentException("Invalid format string command.");
            }
        }
    }
}
