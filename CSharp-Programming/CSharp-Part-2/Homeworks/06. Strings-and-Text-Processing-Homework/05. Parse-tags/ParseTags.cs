namespace _05.Parse_tags
{
    using System;
    using System.Text;

    class ParseTags
    {
        static void Main()
        {
            string text = Console.ReadLine();
            StringBuilder stringBuilder = new StringBuilder();

            // Checks if we have to enter UPPERCASE MODE
            int toUpper = -1;   

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '<')
                {
                    i++;

                    // An opening tag => start UPPER
                    toUpper = toUpper * (-1); 

                    // Disregard all of the tag's content
                    while (text[i] != '>')    
                    {
                        i++;
                    }
                }
                else
                {
                    if (toUpper == 1)
                    {
                        stringBuilder.Append(text[i].ToString().ToUpper());
                    }
                    else
                    {
                        stringBuilder.Append(text[i]);
                    }
                }
            }

            Console.WriteLine(stringBuilder.ToString());
        }
    }
}
