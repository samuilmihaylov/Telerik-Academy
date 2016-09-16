namespace ExtensionMethodsDelegatesLambdaLINQ.Extensions
{
    using System;
    using System.Text;

    public static class StringBuilderExtensions
    {
        // Substring the input from given index and lenght
        public static StringBuilder Substring(this StringBuilder input, int index, int length)
        {
            Validate(input, index, length);
            return new StringBuilder(input.ToString().Substring(index, length));
        }

        // Substring the input from the first index, to the last
        public static StringBuilder Substring(this StringBuilder input, int index)
        {
            Validate(input, index);
            return new StringBuilder(input.ToString(index, input.Length - index));
        }

        // Validation if the index is out of range
        private static void Validate(StringBuilder input, int index, int length = 0)
        {
            if (index < 0 || index > input.Length)
            {
                throw new ArgumentException("Index out of range!");
            }

            if (length < 0 || length > input.Length - index)
            {
                throw new ArgumentOutOfRangeException("Inavlid lenght!");
            }
        }
    }
}
