namespace _05.Boolean_Variable
{
    using System;

    class BooleanVariable
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Are you female: Yes/No");
            string answer = Console.ReadLine();

            bool isFemale = false;
            if (answer.Equals("Yes"))
            {
                isFemale = true;
            }

            if (isFemale)
            {
                Console.WriteLine("You are female.");
            }
            else
            {
                Console.WriteLine("You are male.");
            }
        }
    }
}
