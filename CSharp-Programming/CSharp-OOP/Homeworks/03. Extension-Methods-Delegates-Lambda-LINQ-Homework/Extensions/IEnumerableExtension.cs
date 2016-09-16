namespace ExtensionMethodsDelegatesLambdaLINQ.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class IEnumerableExtensions
    {
        // Implement a set of extension methods for IEnumerable<T> 
        // that implement the following group functions: sum, product, min, max, average.

        // Sum
        public static decimal SumOfTheCollection<T>(this IEnumerable<T> collection) where T : IConvertible
        {
            return collection
                    .Select(x => Convert.ToDecimal(x))
                    .Sum();
        }

        // Product
        public static decimal ProductOfTheCollection<T>(this IEnumerable<T> collection) where T : IConvertible
        {
            var decimalCollection = collection
                                    .Select(x => Convert.ToDecimal(x));

            decimal result = 1;

            foreach (var number in decimalCollection)
            {
                result *= number;
            }
            return result;
        }

        // Min
        public static decimal MinInCollection<T>(this IEnumerable<T> collection) where T : IConvertible
        {
            return collection
                    .Select(x => Convert.ToDecimal(x))
                    .Min();
        }

        // Max
        public static decimal MaxInCollection<T>(this IEnumerable<T> collection) where T : IConvertible
        {
            return collection
                    .Select(x => Convert.ToDecimal(x))
                    .Max();
        }

        // Average
        public static decimal AverageOfTheCollection<T>(this IEnumerable<T> collection) where T : IConvertible
        {
            return collection.SumOfTheCollection() / collection.Count();
        }

        // Printing collection
        public static IEnumerable<T> ForEach<T>(this IEnumerable<T> collection, Action<T> action)
        {
            foreach (var item in collection)
            {
                action(item);
            }
            return collection;
        }

    }
}

