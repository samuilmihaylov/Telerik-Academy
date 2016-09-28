namespace _15.Replace_tags
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    class ReplaceTags
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            input = input.Remove(0, 3); // removing <p> tag
            input = input.Remove(input.Length - 4, 4); // removing </p> tag
            string replacement = Regex.Replace(input, @"\t|\n|\r", "");
            string[] sentences = replacement.Split(new string[] { ". " }, StringSplitOptions.RemoveEmptyEntries);

            StringBuilder sb = new StringBuilder();
      
            for (int i = 0; i < sentences.Length; i++)
            {
                int startIndex = 0;
                startIndex = sentences[i].IndexOf("<a");

                // Not found
                if (startIndex < 0)
                {
                    sb.Append(sentences[i]);
                }

                // Is found
                if (startIndex > 0)
                {
                    int replaceSentenceStartIndex = 0;
                    int sentenceEndIndex = 0;
                    string replaceSentence = string.Empty;

                    replaceSentenceStartIndex = sentences[i].IndexOf("<a href=");
                    sentenceEndIndex = sentences[i].IndexOf("</a>");

                    int sentenceSentenceLength = 0;
                    for (int j = replaceSentenceStartIndex; j < sentenceEndIndex; j++)
                    {
                        sentenceSentenceLength += 1;
                    }

                    replaceSentence = sentences[i].Substring(replaceSentenceStartIndex, sentenceSentenceLength);

                    int textStartIndex = 0;
                    string text = string.Empty;
                    textStartIndex = replaceSentence.IndexOf(">") + 1;

                    int textLength = 0;
                    for (int j = textStartIndex; j < replaceSentence.Length; j++)
                    {
                        textLength += 1;
                    }

                    text = replaceSentence.Substring(textStartIndex, textLength);

                    int urlStartIndex = 0;
                    int urlEndIndex = 0;
                    string url = string.Empty;
                    urlStartIndex = replaceSentence.IndexOf("<a href=") + 9;
                    urlEndIndex = replaceSentence.IndexOf(">");

                    int urlLength = 0;
                    for (int j = urlStartIndex; j < urlEndIndex - 1; j++)
                    {
                        urlLength += 1;
                    }
                    url = replaceSentence.Substring(urlStartIndex, urlLength);
                    String replacedString = String.Format("[{0}]({1})",text,url);
                    string replaced = sentences[i].Replace(replaceSentence, replacedString);
                    sb.Append(replaced + ". ");
                }   
            }

            sb = sb.Replace("</a>", "");
            sb = sb.Remove(sb.Length - 2, 2);

            Console.WriteLine("<p>" + sb.ToString() + "</p>");
        }
    }
}
