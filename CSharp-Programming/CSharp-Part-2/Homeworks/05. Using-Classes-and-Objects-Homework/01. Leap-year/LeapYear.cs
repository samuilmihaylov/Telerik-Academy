using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Leap_year
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            int inputYear = int.Parse(Console.ReadLine());

            isLeap(inputYear);
        }

        static void isLeap(int year)
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
