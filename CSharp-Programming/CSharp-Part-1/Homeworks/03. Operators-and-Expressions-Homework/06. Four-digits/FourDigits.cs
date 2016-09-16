namespace _06.Four_digits
{
    using System;
    
    class FourDigits
    {
        static void Main(string[] args)
        {
            string inputNumberAsString = Console.ReadLine();

            char[] charArray = inputNumberAsString.ToCharArray();

            char firstDigitAsChar = inputNumberAsString[0];

            char secondDigitAsChar = inputNumberAsString[1];

            char thirdDigitAsChar = inputNumberAsString[2];

            char fourtDigitAsChar = inputNumberAsString[3];

            double sumOfDigits = char.GetNumericValue(firstDigitAsChar) + char.GetNumericValue(secondDigitAsChar) + char.GetNumericValue(thirdDigitAsChar) + char.GetNumericValue(fourtDigitAsChar);

            Console.WriteLine(sumOfDigits);

            // The number in reversed order
            string reversedNumberAsString = "";
            for (int index = charArray.Length-1; index >= 0; index--)
            {
                reversedNumberAsString += charArray[index];
            }

            Console.WriteLine(reversedNumberAsString);

            // Puts the last digit in the first position
            char[] newCharArray = new char[charArray.Length];
            Array.Copy(charArray, newCharArray, charArray.Length);
            newCharArray[0] = fourtDigitAsChar;
            newCharArray[3] = firstDigitAsChar;
            Console.WriteLine(newCharArray);

            // Exchanges the second and the third digits
            charArray[1] = thirdDigitAsChar;
            charArray[2] = secondDigitAsChar;
            Console.WriteLine(charArray);

            // An other way to extract the digits
            int inputNumber = Int32.Parse(Console.ReadLine());

            int firstDigit = (inputNumber / 1000) % 10;
            int secondDigit = (inputNumber / 100) % 10;
            int thirdDigit = (inputNumber / 10) % 10;
            int fourtDigit = (inputNumber % 10);

            Console.WriteLine(firstDigit + secondDigit + thirdDigit + fourtDigit);
        }
    }
}
