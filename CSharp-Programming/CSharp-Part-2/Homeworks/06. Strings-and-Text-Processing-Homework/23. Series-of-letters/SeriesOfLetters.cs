﻿namespace _23.Series_of_letters
{
    using System;
    using System.Text;

    class SeriesOfLetters
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char previousLetter = input[0];

            StringBuilder sb = new StringBuilder();

            sb.Append(previousLetter);

            for (int i = 1; i < input.Length; i++)
            {
                if(previousLetter == input[i])
                {
                    continue;
                }

                if(previousLetter != input[i])
                {
                    sb.Append(input[i]);
                }

                previousLetter = input[i];
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
