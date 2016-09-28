namespace Bunnies
{
    using System.Collections.Generic;
    using System.IO;

    using Enumerations;
    using Models;
    using Workers;

    /// <summary>
    /// Factory class for building many Bunny objects.
    /// </summary>
    public class BunniesFactory
    {
        /// <summary>
        /// The entry point of the project that creates bunnies and export them in text file.
        /// </summary>
        public static void Main()
        {
            var bunnies = new List<Bunny>
            {
                new Bunny { Name = "Leonid", Age = 1, FurType = FurType.NotFluffy },
                new Bunny { Name = "Rasputin",  Age = 2, FurType = FurType.ALittleFluffy },
                new Bunny { Name = "Tiberii", Age = 3, FurType = FurType.ALittleFluffy },
                new Bunny { Name = "Neron", Age = 1, FurType = FurType.ALittleFluffy },
                new Bunny { Name = "Klavdii", Age = 3, FurType = FurType.Fluffy },
                new Bunny { Name = "Vespasian", Age = 3, FurType = FurType.Fluffy },
                new Bunny { Name = "Domician", Age = 4, FurType = FurType.FluffyToTheLimit },
                new Bunny { Name = "Tit", Age = 2, FurType = FurType.FluffyToTheLimit }
            };

            var consoleWriter = new ConsoleWriter();

            // Introduce all bunnies.
            foreach (var bunny in bunnies)
            {
                bunny.Introduce(consoleWriter);
            }

            // Create bunnies text file.
            var bunniesFilePath = @"..\..\bunnies.txt";
            var fileStream = File.Create(bunniesFilePath);

            fileStream.Close();

            // Save bunnies to a text file.
            using (var streamWriter = new StreamWriter(bunniesFilePath))
            {
                foreach (var bunny in bunnies)
                {
                    streamWriter.WriteLine(bunny.ToString());
                }
            }
        }
    }
}
