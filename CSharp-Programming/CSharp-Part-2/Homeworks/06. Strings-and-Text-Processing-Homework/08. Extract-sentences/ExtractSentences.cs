namespace _08.Extract_sentences
{
    using System;
    using System.Linq;

    class ExtractSentences
    {
        static void Main()
        {
            string wordSearch = Console.ReadLine().Trim();
            string inputText = Console.ReadLine();

            string[] sentences = inputText.Split(new string[] { "." }, StringSplitOptions.RemoveEmptyEntries);

            char[] separators = GetNonLetterSymbols(inputText); 

            foreach (string sentence in sentences)
            {
                string[] words = sentence.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                foreach (var word in words)
                {
                    if (word.Trim() == wordSearch)
                    {
                        Console.Write(sentence.Trim() + ". ");

                        break;
                    }
                }
            }
        }

        private static char[] GetNonLetterSymbols(string input)
        {
            char[] symbols = input
                .Where(ch => !char.IsLetter(ch))
                .Distinct()                      
                .ToArray();

            return symbols;
        }
    }
}

