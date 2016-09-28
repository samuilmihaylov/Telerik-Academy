namespace _02.Reverse_string
{
    using System;

    class ReverseString
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
           
            Console.WriteLine(ReverseStr(input));
        }

        public static string ReverseStr(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);

            return new string(charArray);
        }
    }
}
