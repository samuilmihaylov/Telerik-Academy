namespace ExtensionMethodsDelegatesLambdaLINQ.LongestString
{
    using System.Linq;

    public static class LINQLongestStringInArray
    {
        public static string LongestStringInArray(string[] input)
        {
            return input.OrderByDescending(longest => longest.Length)
                                .First()
                                .ToString();
        }
    }
}
