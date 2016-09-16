namespace _15.Age
{
    using System;

    class Age
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your birthday date in following format: MM.dd.yyyy");
            string inputBirthDayDate = Console.ReadLine();

            DateTime birthDate = DateTime.ParseExact(inputBirthDayDate, "MM.dd.yyyy", null);
            int days = (DateTime.Now.Year * 365 + DateTime.Now.DayOfYear) - (birthDate.Year * 365 + birthDate.DayOfYear);
            int years = days / 365;

            Console.WriteLine($"Now you are {years} old.");
            Console.WriteLine($"After 10 years, you will be {years + 10} old.");
        }
    }
}
