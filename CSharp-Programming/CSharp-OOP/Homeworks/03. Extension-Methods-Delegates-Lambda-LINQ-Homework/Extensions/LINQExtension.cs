namespace ExtensionMethodsDelegatesLambdaLINQ.LINQ
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class LINQExtensions
    {
        // Write a method that from a given array of students finds all students 
        // whose first name is before its last name alphabetically.

        public static IEnumerable<T> FirstBeforeLastName<T>(this IEnumerable<T> students) where T : Student
        {
            var orderedStudents = students
                .Where(x => (x.FirstName).CompareTo(x.LastName) < 0)
                .ToArray();

            return orderedStudents;
        }

        // Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

        public static IEnumerable<string> AgeInterval<T>(this IEnumerable<T> students, int minAge, int maxAge) where T : Student
        {
            var orderedStudents = students
                .Where(x => x.Age >= minAge && x.Age <= maxAge)
                .Select(x => String.Format($"{x.FirstName} {x.LastName} {x.Age}"))
                .ToArray();

            return orderedStudents;
        }

        // Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students 
        // by first name and last name in descending order.
        // Rewrite the same with LINQ.


        public static IEnumerable<T> SortStudentsByDescending<T>(this IEnumerable<T> students) where T : Student
        {
            var orderedStudents = students
               .OrderByDescending(x => x.FirstName)
               .ThenByDescending(x => x.LastName)
               .ToArray();

            return orderedStudents;
        }

        // Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. 
        // Use the built-in extension methods and lambda expressions.Rewrite the same with LINQ.

        public static int[] DivisibleBy7And3(this int[] numbers)
        {
            var orderedNumbers = numbers
                .Where(x => x % 7 == 0 && x % 3 == 0)
                .ToArray();

            return orderedNumbers;
        }

        // return collection of students from specific group

        public static IEnumerable<T> StudentsFromSpecificGroup<T>(this IEnumerable<T> students, int group) where T : Student
        {
            var orderedStudentsByGroup = students
                .Where(x => x.GroupNumber == 2)
                .ToArray();

            return orderedStudentsByGroup;
        }

        // Extract all students that have email in abv.bg.
        // Use string methods and LINQ.

        public static IEnumerable<T> ExtractStudentsByEmail<T>(this IEnumerable<T> students, string domain) where T : Student
        {
            var orderedStudentsByEmail = students
                .Where(x => x.Email.Split('@').Last() == domain)
                .ToArray();

            return orderedStudentsByEmail;
        }

        // Extract all students with phones in Sofia.
        // Use LINQ.

        public static IEnumerable<T> ExtractStudentsByPhoneNumber<T>(this IEnumerable<T> students, int phoneGroup, string expectedGroupContain) where T : Student
        {
            var orderedStudentsByPhoneNumber = students
                .Where(x => x.TelephoneNumber
                                .Split(' ')
                                .Skip(phoneGroup - 1)
                                .FirstOrDefault() == expectedGroupContain)
                .ToArray();

            return orderedStudentsByPhoneNumber;
        }

        // split collection of Student to sub-collections of Student by their groupNumber
        public static IEnumerable<IGrouping<int, T>> StudentsByGroups<T>(this IEnumerable<T> students) where T : Student
        {
            var result = students
                .OrderBy(x => x.GroupNumber)
                .GroupBy(x => x.GroupNumber);
            return result;
        }
    }
}
