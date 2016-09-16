namespace _04.Unicode_Character
{
    using System;

    class UnicodeCharacter
    {
        static void Main(string[] args)
        {
            int intVariable = 42;
            Console.WriteLine("The variable 42 in hexadecimal is {0:X}", intVariable);

            char symbolUnicode = '\u002A';
            Console.WriteLine("The symbol is {0}", symbolUnicode);
        }
    }
}
