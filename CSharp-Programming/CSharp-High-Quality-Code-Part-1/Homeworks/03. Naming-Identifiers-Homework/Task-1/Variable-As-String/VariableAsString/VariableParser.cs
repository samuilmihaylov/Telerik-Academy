namespace VariableAsString
{
    using System;

    /// <summary>
    /// Class that contains parse methods for the variables.
    /// </summary>
    public class VariableParser
    {
        /// <summary>
        /// Integer constant that represents the maximum execution count of the method ParseBooleanToString.
        /// </summary>
        private const int ParseBoolToStringMaxExecutionCount = 6;

        /// <summary>
        /// Method that takes boolean variable, parse it to string and print it in console.
        /// </summary>
        /// <param name="variable">Boolean variable</param>
        public void ParseBooleanToString(bool variable)
        {
            string boolVariableAsString = variable.ToString();
            Console.WriteLine(boolVariableAsString);
        }
    }
}
