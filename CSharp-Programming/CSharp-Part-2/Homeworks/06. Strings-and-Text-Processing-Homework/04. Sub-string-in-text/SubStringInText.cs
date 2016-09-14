using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Sub_string_in_text
{
    class SubStringInText
    {
        static void Main(string[] args)
        {
            string pattern = Console.ReadLine();
            string text = Console.ReadLine();

            pattern = pattern.ToLower();
            text = text.ToLower();

            int counter = 0;
            int index = 0;

            while (true)
            {
                // searching for the pattern in text starting from index, return index or -1 if no found
                int found = text.IndexOf(pattern, index);

                if (found == -1) // if nothing is found, exit from loop when all the string is readed
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
