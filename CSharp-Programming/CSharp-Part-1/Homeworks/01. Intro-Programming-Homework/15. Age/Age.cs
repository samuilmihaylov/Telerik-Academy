
/* 
   15. Age
   
   Description: Write a program that reads your birthday(in the format MM.DD.YYYY)
   from the console and prints on the console how old you are you now and how old will you be after 10 years.
   
   Input: The input will always consist of a single line - a birthdate.
   
   Output: You should print two lines with one number on the each line:
    1) How old are you now, on the first line.
    2) How old will you be after 10 years, on the second line.

   Constraints:The date read from the console will always be in a valid DateTime format.
               All dates will be earlier than 2017. 
               Time limit: 0.1s 
               Memory limit: 16MB
 */


using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Age
{
    class Age
    {
        static void Main(string[] args)
        {
            string birthdayText = Console.ReadLine();
            DateTime birthDate = DateTime.ParseExact(birthdayText, "MM.dd.yyyy", null);
            int Days = (DateTime.Now.Year * 365 + DateTime.Now.DayOfYear) - (birthDate.Year * 365 + birthDate.DayOfYear);
            int Years = Days / 365;
            Console.WriteLine(Years);
            Console.WriteLine((Years + 10));
        }
    }
}
