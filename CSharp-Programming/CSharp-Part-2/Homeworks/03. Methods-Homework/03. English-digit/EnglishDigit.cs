using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.English_digit
{
    class EnglishDigit
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string word ="";

            digitToEnglishWord(number, word);
            word = digitToEnglishWord(number, word);

            Console.WriteLine(word);
        }


        static string digitToEnglishWord(int integer, string engWord)
        {

            int lastDigit = integer % 10;
            switch (lastDigit)
            {
                case 1:
                    engWord = "one";
                    break;
                case 2:
                    engWord = "two";
                    break;
                case 3:
                    engWord = "three";
                    break;
                case 4:
                    engWord = "four";
                    break;
                case 5:
                    engWord = "five";
                    break;
                case 6:
                    engWord = "six";
                    break;
                case 7:
                    engWord = "seven";
                    break;
                case 8:
                    engWord = "eight";
                    break;
                case 9:
                    engWord = "nine";
                    break;
                case 0:
                    engWord = "zero";
                    break;
                default:
                    break;
            }
                
            return engWord;
        }
    }
}
