namespace _03.Range_Exceptions
{
    using System;

    class Startup
    {
        static void Main(string[] args)
        {
            try
            {
                int number = 1000;

                if (number < 1 || number > 100)
                {
                    throw new InvalidRangeException<int>("Invalid number", 1, 100);
                }
            }
            catch (InvalidRangeException<int> ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                DateTime date = new DateTime(1270, 5, 05);
                if (date < new DateTime(1980, 1, 1) || date > new DateTime(2013, 12, 31))
                {
                    throw new InvalidRangeException<DateTime>("Invalid date", new DateTime(1980, 1, 1), new DateTime(2013, 12, 31));
                }
            }
            catch (InvalidRangeException<DateTime> ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
