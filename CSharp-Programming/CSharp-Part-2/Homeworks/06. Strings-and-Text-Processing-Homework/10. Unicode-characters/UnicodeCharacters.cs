namespace _10.Unicode_characters
{
    using System;
    using System.Text;

    class UnicodeCharacters
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder answer = new StringBuilder();

            foreach (char character in input)
            {
                answer.AppendFormat("\\u{0:X4}", (int)character);
            }

            Console.WriteLine(answer.ToString());
        }
    }
}
