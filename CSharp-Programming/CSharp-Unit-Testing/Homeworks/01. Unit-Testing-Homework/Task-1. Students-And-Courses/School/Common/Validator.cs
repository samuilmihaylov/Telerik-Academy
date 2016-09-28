namespace School.Common
{
    using System;
    using System.Collections.Generic;

    public static class Validator
    {
        public static void CheckIfObjectIsNull(object value, string message)
        {
            if (value == null)
            {
                throw new ArgumentNullException(message);
            }
        }

        public static void CheckIfNumberIsInRange(int value, int minimumValue, int maximumValue, string message)
        {
            if (value <= minimumValue || value >= maximumValue )
            {
                throw new ArgumentException(message);
            }
        }

        public static void CheckIfStringIsNullOrEmpty(string value, string message)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException(message);
            }
        }

        public static bool IsPartOfCollection<T>(IEnumerable<T> collection, T element)
        {
            CheckIfObjectIsNull(collection, "The collection cannot be null");
            CheckIfObjectIsNull(element, "The element of the collection cannot be null");

            foreach (var member in collection)
            {
                if (member.Equals(element))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
