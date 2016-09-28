namespace _01.Leap_year
{
    using System;

    class LeapYear
    {
        static void Main(string[] args)
        {
            int inputYear = int.Parse(Console.ReadLine());

            IsLeap(inputYear);
        }

        static void IsLeap(int year)
        {
            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine("Leap");
            }
            else
            {
                Console.WriteLine("Common");
            }
        }
    }
}
