namespace Bunnies.Models
{
    using System;
    using System.Text;

    using Bunnies.Enumerations;
    using Bunnies.Extensions;
    using Contracts;

    /// <summary>
    /// Implements base IBunny.
    /// </summary>
    [Serializable]
    public class Bunny : IBunny
    {
        /// <summary>
        /// Private age field that is used to make verification in Age property.
        /// </summary>
        private int age;

        /// <summary>
        /// Empty default constructor.
        /// Initializes a new instance of the Bunny class.
        /// </summary>
        public Bunny()
        {
            this.Name = string.Empty;
            this.Age = 0;
            this.FurType = FurType.NotFluffy;
        }

        /// <summary>
        /// Initializes a new instance of the Bunny class.
        /// Constructor that takes as arguments: name, age and furType of the Bunny.
        /// </summary>
        /// <param name="name">The name of the Bunny.</param>
        /// <param name="age">The age of the Bunny.</param>
        /// <param name="furType">The fur type of the Bunny.</param>
        public Bunny(string name, int age, FurType furType)
        {
            this.Name = name;
            this.Age = age;
            this.FurType = furType;
        }

        /// <summary>
        /// Gets or sets the name of the Bunny.
        /// </summary>
        /// <value>The name of the Bunny.</value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the name of the Bunny, if age is in correct value is passed.
        /// </summary>
        /// <value>The age of the Bunny.</value>
        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("BunnyAge", "Bunny age cannot be negative!");
                }

                this.age = value;
            }
        }

        /// <summary>
        /// Gets or sets the type of the fur of the Bunny.
        /// </summary>
        /// <value>The fur type of the Bunny.</value>
        public FurType FurType { get; set; }

        /// <summary>
        /// Introduce method that show's the main information for each Bunny.
        /// </summary>
        /// <param name="writer">Invokes IWriter.WriteLine().</param>
        public void Introduce(IWriter writer)
        {
            writer.WriteLine(this.Name + " - \"I am " + this.Age + " years old!");
            writer.WriteLine(this.Name + " - \"And I am " + this.FurType.ToString().SplitToSeparateWordsByUppercaseLetter());
        }

        /// <summary>
        /// ToString method print the information on the Console.
        /// </summary>
        /// <returns>Returns the information of Bunny in formatted string.</returns>
        public override string ToString()
        {
            var builderSize = 200;
            var builder = new StringBuilder(builderSize);

            builder.AppendLine($"Bunny name: {this.Name}");
            builder.AppendLine($"Bunny age: {this.Age}");
            builder.AppendLine($"Bunny fur: {this.FurType.ToString().SplitToSeparateWordsByUppercaseLetter()}");

            return builder.ToString();
        }
    }
}
