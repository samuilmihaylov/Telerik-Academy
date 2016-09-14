using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Correct_brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int countLeft = 0, countRight = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    countLeft++;
                }

                if (input[i] == ')')
                {
                    countRight++;
                }
            }
            if (countLeft == countRight)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
        }
    }
}
