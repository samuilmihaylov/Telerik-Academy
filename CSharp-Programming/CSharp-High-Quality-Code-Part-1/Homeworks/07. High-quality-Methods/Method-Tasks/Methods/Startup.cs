namespace Methods
{
    using System;

    using Methods.Utils;

    public class Startup
    {
        public static void Main()
        {
            MathCalculations();

            StringFormatting();

            StudentAgeOperations();
        }

        private static void StudentAgeOperations()
        {
            Student peter = new Student("Peter", "Petrov", "17.03.1992");

            Student stella = new Student("Stella", "Markova", "03.11.1993");

            var olderStudent = StudentOperations.GetOlderStudent(peter, stella);

            Console.WriteLine($"The older student is : {olderStudent.FirstName}");
        }

        private static void MathCalculations()
        {
            Console.WriteLine(Calculations.CalculateTriangleArea(3, 4, 5));
            Console.WriteLine(Calculations.DigitToWord(5));
            Console.WriteLine(Calculations.FindMaximumValue(5, -1, 3, 2, 14, 2, 3));

            bool horizontal, vertical;
            Console.WriteLine(Calculations.CalculateDistance(3, -1, 3, 2.5, out horizontal, out vertical));
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);
        }

        private static void StringFormatting()
        {
            ConsoleWriter.PrintInConsoleAsNumberInGivenFormat(1.3, "f");

            ConsoleWriter.PrintInConsoleAsNumberInGivenFormat(0.75, "%");

            ConsoleWriter.PrintInConsoleAsNumberInGivenFormat(2.30, "r");
        }
    }
}
