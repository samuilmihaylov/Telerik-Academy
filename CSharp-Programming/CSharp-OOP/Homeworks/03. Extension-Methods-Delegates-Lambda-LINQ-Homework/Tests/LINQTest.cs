namespace ExtensionMethodsDelegatesLambdaLINQ.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using ExtensionMethodsDelegatesLambdaLINQ.LINQ;
    using ExtensionMethodsDelegatesLambdaLINQ.Extensions;

    public static class LINQTest
    {
        public static void Test()
        {
            var students = StudentsGenerator();

            // Students whos first name lexicographically before last 

            // with extension method
            Console.WriteLine("Lexicographically-First name before last");
            Console.WriteLine();
            Console.WriteLine("With extension method");
            Console.WriteLine();
            var result = students.FirstBeforeLastName();
            result.ForEach(x => Console.WriteLine(x.FullName));

            // with normal method
            Console.WriteLine();
            Console.WriteLine("With normal method");
            Console.WriteLine();
            result = LINQNormalMethods.FirstBeforeLastName(students);
            result.ForEach(x => Console.WriteLine(x.FullName));

            // Students in age range 18-25 including

            // with extension method
            Console.WriteLine();
            Console.WriteLine("Age range");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("With extension method");
            Console.WriteLine();
            var otherResult = students.AgeInterval(18, 25);
            otherResult.ForEach(x => Console.WriteLine(x));

            // with normal method
            Console.WriteLine();
            Console.WriteLine("With normal method");
            Console.WriteLine();
            otherResult = LINQNormalMethods.AgeInterval(students, 18, 25);
            otherResult.ForEach(x => Console.WriteLine(x));


            // Sorted students lexicographically by decending first name - then by last name

            // with extension method
            Console.WriteLine();
            Console.WriteLine("Lexicographically-Descending");
            Console.WriteLine();
            Console.WriteLine("With extension method");
            Console.WriteLine();
            result = students.SortStudentsByDescending();
            result.ForEach(x => Console.WriteLine(x.FullName));

            // with normal method
            Console.WriteLine();
            Console.WriteLine("With normal method");
            Console.WriteLine();
            result = LINQNormalMethods.SortStudentsByDescending(students);
            result.ForEach(x => Console.WriteLine(x.FullName));

            Console.WriteLine();
            Console.WriteLine("The array of numbers: ");
            var numbers = new[] { 4, 19, 21, 144, 48, 84, 96, 12, 7, 100, 0, 13, -5, 12, 3, 7 };
            PrintNumbers(numbers);

            // Print numbers from array that can be devided by 3 AND 7 without reminder 
            Console.WriteLine();
            Console.WriteLine("Numbers from array that can be divided by 3 and 7");
            // with extension method
            Console.WriteLine();
            Console.WriteLine("With extension method");
            Console.WriteLine();
            var numResult = numbers.DivisibleBy7And3();
            PrintNumbers(numResult);

            // with normal method
            Console.WriteLine();
            Console.WriteLine("With normal method");
            Console.WriteLine();
            numResult = LINQNormalMethods.DivisibleBy7And3(numResult);
            PrintNumbers(numResult);

        }

        // Students from group 2
        public static void StudentsGroupTwoTest()
        {
            var students = StudentsGenerator();

            // with extension method
            Console.WriteLine();
            Console.WriteLine("With extension method");
            Console.WriteLine();
            students
                .StudentsFromSpecificGroup(2)
                .OrderBy(x => x.FirstName)
                .ForEach(x => Console.WriteLine($"{x.FullName} Group: {x.GroupNumber}"));

            // with normal method 
            Console.WriteLine();
            Console.WriteLine("With normal method");
            Console.WriteLine();
            var result = LINQNormalMethods.StudentsFromSpecificGroup(students, 2);
            result
                .OrderBy(x => x.FirstName)
                .ForEach(x => Console.WriteLine($"{x.FullName} Group: {x.GroupNumber}"));

            // Students with specific domain

            // with extension method
            Console.WriteLine();
            Console.WriteLine("With extension method");
            Console.WriteLine();
            students
                .ExtractStudentsByEmail("abv.bg")
                .ForEach(x => Console.WriteLine($"{x.FullName} Email: {x.Email}"));

            // with normal method 
            Console.WriteLine();
            Console.WriteLine("With normal method");
            Console.WriteLine();
            result = LINQNormalMethods.ExtractStudentsByEmail(students, "abv.bg");
            result
                .ForEach(x => Console.WriteLine($"{x.FullName} Email: {x.Email}"));

            // with extension method
            Console.WriteLine();
            Console.WriteLine("With extension method");
            Console.WriteLine();
            students
                .ExtractStudentsByPhoneNumber(2, "2")
                .ForEach(x => Console.WriteLine($"{x.FullName} Tel: {x.TelephoneNumber}"));

            // with normal method
            Console.WriteLine();
            Console.WriteLine("With normal method");
            Console.WriteLine();
            result = LINQNormalMethods.ExtractStudentsByPhoneNumber(students, 2, "2");
            result
                .ForEach(x => Console.WriteLine($"{x.FullName} Tel: {x.TelephoneNumber}"));

            Console.WriteLine();

        }

        public static void AnonymousArrayTest()
        {
            Console.WriteLine("AnonymousArrayTest");
            Console.WriteLine();
            var anonymousArray = new[]
            {
                new {FullName = "Pesho Peshov", Marks=new List<int> { 6, 5, 2, 6, 2, 4 }},
                new {FullName = "Gosho Goshov", Marks=new List<int> {3, 5, 3, 6, 5, 4 }},
                new {FullName = "Ivan Ivanov", Marks=new List<int> { 3, 5, 5, 6, 3, 4 }},
                new {FullName = "Dimityr Dimitrov", Marks=new List<int> { 2, 5, 2, 6, 2, 4 }},
                new {FullName = "Hristo Hristov", Marks=new List<int> { 3, 5, 2, 3, 2, 4 }},
                new {FullName = "Petyr Petrov", Marks=new List<int> { 3, 5, 2, 6, 4, 4 }},
                new {FullName = "Dimcho Dimchev", Marks=new List<int> { 4, 5, 2, 6, 2, 4 }},
            };

            // students who have at least 1 mark = 6
            Console.WriteLine("Students with at least one mark = 6");
            Console.WriteLine();
            anonymousArray
                .Where(x => x.Marks.Contains(6))
                .ForEach(x => Console.WriteLine($"{x.FullName} , Marks: {string.Join(" ", x.Marks)}"));

            // students with exact 2 marks = 2
            Console.WriteLine();
            Console.WriteLine("Students with exact two marks = 2");
            Console.WriteLine();
            anonymousArray
                .Where(x => x.Marks
                            .Where(m => m == 2)
                            .Count() == 2)
                 .ForEach(x => Console.WriteLine($"{x.FullName} , Marks: {string.Join(" ", x.Marks)}"));
        }

        public static void JoinGroups()
        {
            Console.WriteLine();
            Console.WriteLine("Joining groups and students by their GroupNumbers");
            Console.WriteLine();
            var students = StudentsGenerator();
            var groups = GroupsGenerator();

            // join groups and students by their GroupNumbers
            students
                 .Join(groups,
                     st => st.GroupNumber, // student group numbers
                     gr => gr.GroupNumber, // group group number
                     (st, gr) => new { st.FullName, gr.DepartamentName })
                 .Where(x => x.DepartamentName == "Mathematics")
                 .ForEach(x => Console.WriteLine($"{x.DepartamentName} {x.FullName}"));
        }
       
        public static void CollectionSplit()
        {
            Console.WriteLine();
            Console.WriteLine("Split collection of Student to sub-collections of Student");
            Console.WriteLine();
            var students = StudentsGenerator();

            // Split collection of Student to sub-collections of Student (IEnumerable<IGrouping<int, T>> where T : Student)

            // with extension method
            Console.WriteLine();
            Console.WriteLine("With extension method");
            Console.WriteLine();
            students
                .StudentsByGroups()
                .ForEach(x =>
                {
                    Console.WriteLine($"Group: {x.Key}");
                    x.ForEach(y => Console.WriteLine($"{y.FullName}"));
                });


            // with normal method
            Console.WriteLine();
            Console.WriteLine("With normal method");
            Console.WriteLine();
            var result = LINQNormalMethods.StudentsByGroups(students);
            result
                .ForEach(x =>
                {
                    Console.WriteLine($"Group: {x.Key}");
                    x.ForEach(y => Console.WriteLine($"{y.FullName}"));
                });  
        }

        // Methods
        private static void PrintNumbers(int[] numbers)
        {
            Console.WriteLine(string.Join(" ", numbers));
        }

        // Test data generators
        private static Student[] StudentsGenerator()
        {
            var result = new Student[10];
            result[0] = new Student("Pesho", "Peshov", 5, 10230667, "+359 2 111 2222", "Pesho@abv.bg", new List<int> { 6, 5, 2, 6, 2, 4 }, 2);
            result[1] = new Student("Gosho", "Goshov", 15, 10230557, "+359 2 222 3333", "Gosho@mail.bg", new List<int> { 3, 5, 3, 6, 5, 4 }, 3);
            result[2] = new Student("Ivan", "Ivanov", 20, 19234127, "+359 2 333 4444", "Ivan@abv.bg", new List<int> { 3, 5, 5, 6, 3, 4 }, 2);
            result[3] = new Student("Dimityr", "Dimitrov", 3, 10234817, "+359 33 444 555", "Dimityr@gmail.com", new List<int> { 2, 5, 2, 6, 2, 4 }, 5);
            result[4] = new Student("Hristo", "Hristov", 4, 10230617, "+359 33 555 666", "Hristo@yahoo.com", new List<int> { 3, 5, 2, 3, 2, 4 }, 1);
            result[5] = new Student("Petyr", "Petrov", 7, 10230167, "+359 55 666 777", "Petyr@abv.bg", new List<int> { 3, 5, 2, 6, 4, 4 }, 3);
            result[6] = new Student("Dimityr", "Blagoev", 60, 16234057, "+359 44 777 888", "Dimityr@mail.bg", new List<int> { 4, 5, 2, 6, 2, 4 }, 4);
            result[7] = new Student("Hristo", "Gospodinov", 32, 10230997, "+359 55 888 999", "Hristo@mail.com", new List<int> { 5, 5, 6, 6, 3, 4 }, 1);
            result[8] = new Student("Petar", "Hristov", 25, 13234127, "+359 2 999 888", "Petar@abv.bg", new List<int> { 4, 5, 2, 6, 4, 4 }, 1);
            result[9] = new Student("Atanas", "Atanasov", 49, 17230667, "+359 2 888 7777", "Atanas@dir.bg", new List<int> { 2, 5, 2, 3, 2, 4 }, 4);
            return result;
        }

        private static Group[] GroupsGenerator()
        {
            var result = new Group[5];
            result[0] = new Group(1, "French");
            result[1] = new Group(2, "Mathematics");
            result[2] = new Group(3, "Physics");
            result[3] = new Group(4, "History");
            result[4] = new Group(5, "Biology");
            return result;
        }
    }
}