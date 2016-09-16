namespace ExtensionMethodsDelegatesLambdaLINQ.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using ExtensionMethodsDelegatesLambdaLINQ.Extensions;

    public static class IEnumerableTest
    {
        public static void Test()
        { 
            // Testing IEnumerable Extension Methods
            Console.WriteLine();
            var collection = new List<int>() { 1, 5, 4, 8, 9 };

            Console.WriteLine("The given collection is: {0}", string.Join(", ", collection));
            Console.WriteLine();
            Console.WriteLine("Max {0}", collection.MaxInCollection());
            Console.WriteLine("Min {0}", collection.MinInCollection());
            Console.WriteLine("Product {0}", collection.ProductOfTheCollection());
            Console.WriteLine("Sum {0}", collection.SumOfTheCollection());
            Console.WriteLine("Average {0}", collection.AverageOfTheCollection());
            Console.WriteLine();
        }
    }
}
