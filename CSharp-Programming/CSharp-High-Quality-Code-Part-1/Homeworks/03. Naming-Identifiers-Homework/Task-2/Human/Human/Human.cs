namespace Human
{
    /// <summary>
    /// Implements the properties for human object.
    /// </summary>
    public class Human
    {
        /// <summary>
        ///  Gets or sets the name of the human.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///  Gets or sets the age of the human.
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        ///  Gets or sets the gender of the human.
        /// </summary>
        public GenderType Gender { get; set; }

        /// <summary>
        /// Static method that creates new object of type Human
        /// </summary>
        /// <param name="personalNumber">accepts any valid integer number</param>
        /// <returns>new object of type Human</returns>
        public static Human HumanFactory(int personalNumber)
        {
            var human = new Human();

            human.Age = personalNumber;

            if (human.Age % 2 == 0)
            {
                human.Name = "Hulk Hogan";
                human.Gender = GenderType.Male;
            }
            else
            {
                human.Name = "Justin Bieber";
                human.Gender = GenderType.Female;
            }

            return human;
        }
    }
}
