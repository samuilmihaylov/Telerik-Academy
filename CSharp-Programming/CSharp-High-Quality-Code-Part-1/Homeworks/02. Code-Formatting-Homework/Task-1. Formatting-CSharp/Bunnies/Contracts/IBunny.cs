namespace Bunnies.Contracts
{
    using Bunnies.Enumerations;

    /// <summary>
    /// Interface IBunny.
    /// </summary>
    public interface IBunny
    {
        /// <summary>
        /// Gets or sets the name of the IBunny.
        /// </summary>
        /// <value>The name of the IBunny.</value>
        string Name { get; set; }

        /// <summary>
        /// Gets or sets the age of the IBunny.
        /// </summary>
        /// <value>The age of the IBunny.</value>
        int Age { get; set; }

        /// <summary>
        /// Gets or sets the type of the fur of the IBunny.
        /// </summary>
        /// <value>The fur type of the IBunny.</value>
        FurType FurType { get; set; }

        /// <summary>
        /// Writes a string to the provided IWriter.
        /// </summary>
        /// <param name="writer">IWriter used to write a string. </param>
        void Introduce(IWriter writer);
    }
}
