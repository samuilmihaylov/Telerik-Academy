namespace ExtensionMethodsDelegatesLambdaLINQ
{
    using System;
    using ExtensionMethodsDelegatesLambdaLINQ.Tests;
    using ExtensionMethodsDelegatesLambdaLINQ.Timer;

    public static class StartUp
    {
        public static void Main()
        {

            StringBuilderTest.Test();

            Console.WriteLine("-----------------------------------------");

            IEnumerableTest.Test();

            Console.WriteLine("-----------------------------------------");

            LongestStringTest.Test();

            Console.WriteLine("-----------------------------------------");

            LINQTest.Test();

            Console.WriteLine("-----------------------------------------");

            LINQTest.StudentsGroupTwoTest();

            Console.WriteLine("-----------------------------------------");

            LINQTest.AnonymousArrayTest();

            Console.WriteLine("-----------------------------------------");

            LINQTest.JoinGroups();

            Console.WriteLine("-----------------------------------------");

            LINQTest.CollectionSplit();

            Console.WriteLine("-----------------------------------------");

            // TimerTest.Test();

        }
    }
}