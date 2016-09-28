namespace _04.Sub_string_in_text
{
    using System;

    class SubStringInText
    {
        static void Main(string[] args)
        {
            string inputPattern = Console.ReadLine();
            string inputText = Console.ReadLine();

            inputPattern = inputPattern.ToLower();
            inputText = inputText.ToLower();

            int counter = 0;
            int index = 0;

            while (true)
            {
                // Searching for the pattern in text starting from index, return index or -1 if no found
                int found = inputText.IndexOf(inputPattern, index);

                // If nothing is found, exit from loop when all the string is readed
                if (found == -1) 
                {
                    break;
                }

                counter++;
                index = found + 1; 
            }

            Console.WriteLine(counter);
        }
    }
}
