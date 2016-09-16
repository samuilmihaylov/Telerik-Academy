namespace _06.Strings_and_Objects
{
    using System;

    class StringsAndObjects
    {
        static void Main(string[] args)
        {
            string helloString = "Hello ";
            string worldString = "World";

            object sentence = helloString + worldString;
            Console.WriteLine(sentence);

            string objectToString = sentence.ToString();
            Console.WriteLine(objectToString);
        }
    }
}
