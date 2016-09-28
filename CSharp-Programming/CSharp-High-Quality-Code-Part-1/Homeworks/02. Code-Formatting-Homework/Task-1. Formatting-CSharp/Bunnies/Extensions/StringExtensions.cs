namespace Bunnies.Extensions
{
    using System.Text;

    /// <summary>
    /// Provides string extensions for custom string manipulation.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Inserts whitespace in a string between two capital letters.
        /// </summary>
        /// <param name="sequence"> The string to parse. </param>
        /// <returns> Returns a new string with inserted whitespace before capital letters. </returns>
        public static string SplitToSeparateWordsByUppercaseLetter(this string sequence)
        {
            var probableStringMargin = 10;
            var probableStringSize = sequence.Length + probableStringMargin;
            var builder = new StringBuilder(probableStringSize);

            var singleWhitespace = ' ';
            foreach (var letter in sequence)
            {
                if (char.IsUpper(letter))
                {
                    builder.Append(singleWhitespace);
                }

                builder.Append(letter);
            }

            return builder.ToString().Trim();
        }
    }
}
