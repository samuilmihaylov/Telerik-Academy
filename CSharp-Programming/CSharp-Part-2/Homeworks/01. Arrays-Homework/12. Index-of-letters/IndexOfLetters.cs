using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Index_of_letters
{
    class IndexOfLetters
    {
        static void Main(string[] args)
        {
            char[] alpha = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            string word = Console.ReadLine();
            int index = 0;

            for (int i = 0; i < word.Length; i++)
            {
                foreach (char ch in alpha)
                {
                    if (ch == word[i])
                    {
                        // index = Array.FindIndex(alpha, item => item == word[i]);
                        index = Array.IndexOf(alpha, word[i]);
                    }
                }
                Console.WriteLine(index);
            }         
        }
    }
}
