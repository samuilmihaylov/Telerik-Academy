
namespace _05.Parse_tags
{
    using System;
    using System.Text;
    using System.Collections.Generic;

    class ParseTags
    {
        static void Main()
        {
            //string text = Console.ReadLine();

            //List<int> lst = new List<int>();

            //int nextStart = text.IndexOf("<upcase>");
            //int nextEnd = text.IndexOf("</upcase>");
            //while (nextStart != -1)
            //{
            //    lst.Add(nextStart);
            //    nextStart = text.IndexOf("<upcase>", nextStart + 1);
            //    lst.Add(nextEnd);
            //    nextEnd = text.IndexOf("</upcase>", nextEnd + 1);
            //}

            //for (int i = 0; i < lst.Count; i += 2)
            //{
            //    int start = lst[i];
            //    int end = lst[i + 1];
            //    var changedString = text.Substring(start + 8, end - start - 8).ToUpper();
            //    Console.WriteLine(changedString);
            //}

            string text = Console.ReadLine();
            StringBuilder sb = new StringBuilder();

            int toUpper = -1;   //checks if we have to enter UPPERCASE MODE

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '<')
                {
                    i++;
                    toUpper = toUpper * (-1); // an opening tag => start UPPER

                    while (text[i] != '>')    // disregard all of the tag's content
                    {
                        i++;
                    }
                }
                else
                {
                    if (toUpper == 1)
                    {
                        sb.Append(text[i].ToString().ToUpper());
                    }
                    else
                    {
                        sb.Append(text[i]);
                    }
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
