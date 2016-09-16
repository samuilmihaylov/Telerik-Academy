namespace ExtensionMethodsDelegatesLambdaLINQ.Tests
{
    using System;
    using ExtensionMethodsDelegatesLambdaLINQ.LongestString;

    public static class LongestStringTest
    {
        public static void Test()
        {
            // Testing LongestStringInArray Method

            string[] stingArray = { "ff", "apple", "mouse", "phone", "dog", "kvottakova" };
            Console.WriteLine(LINQLongestStringInArray.LongestStringInArray(stingArray));
        }
    }
}
