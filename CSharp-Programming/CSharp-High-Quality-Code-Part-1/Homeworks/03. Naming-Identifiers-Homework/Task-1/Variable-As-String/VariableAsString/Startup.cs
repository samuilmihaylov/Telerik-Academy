namespace VariableAsString
{
    /// <summary>
    /// Startup class that contains the entry point of the project.
    /// </summary>
    public class Startup
    {
        /// <summary>
        ///  The entry point of the project that parse boolean variable to string and print it.
        /// </summary>
        public static void Main(string[] args)
        {
            VariableParser parser = new VariableParser();

            parser.ParseBooleanToString(true);
        }
    }
}
