namespace ExtensionMethodsDelegatesLambdaLINQ.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using ExtensionMethodsDelegatesLambdaLINQ.Extensions;

    public static class StringBuilderTest
    {
        public static void Test()
        {
            // Testing StringBuilder Extension Substring Method

            StringBuilder sb = new StringBuilder();

            sb.Append("Testing the Extension Method Substring");

            Console.WriteLine(sb.Substring(0, 7));
            Console.WriteLine(sb.Substring(12));
            Console.WriteLine();
        }
    }
}
