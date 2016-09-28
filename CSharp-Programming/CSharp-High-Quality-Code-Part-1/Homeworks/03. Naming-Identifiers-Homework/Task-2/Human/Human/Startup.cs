namespace Human
{
    using System;

    /// <summary>
    /// Startup class that builds human objects.
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// The entry point of the project that creates human with given integer number from the console.
        /// </summary>
        public static void Main(string[] args)
        {
            var personalNumber = int.Parse(Console.ReadLine());

            var human = Human.HumanFactory(personalNumber);
        }
    }
}
