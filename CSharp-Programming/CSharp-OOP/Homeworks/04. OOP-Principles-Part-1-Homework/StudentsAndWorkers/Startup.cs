namespace StudentsAndWorkers
{
    using StudentsAndWorkers.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Startup
    {
        static void Main(string[] args)
        {
            //Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
            List<Student> students = new List<Student>();
            students.Add(new Student("Simeon", "Slavov", 2));
            students.Add(new Student("Iskra", "Lumbeva", 7));
            students.Add(new Student("Veronika", "Zhelqzkova", 3));
            students.Add(new Student("Ivonna", "Zhelqzkova", 6));
            students.Add(new Student("Toni", "Zhelqzkova", 5));
            students.Add(new Student("Lubo", "Kolov", 9));
            students.Add(new Student("Boqn", "Zeraw", 12));
            students.Add(new Student("Katerina", "Qrova", 8));
            students.Add(new Student("Georgi", "Tonkov", 10));
            students.Add(new Student("Doroteq", "Kolarova", 12));

            var orderedStudents = students
                .OrderBy(x => x.Grade);

            foreach (var student in orderedStudents)
            {
                Console.WriteLine(string.Format("Student {0} with grade {1}",student, student.Grade));
            }

            //Initialize a list of 10 workers and sort them by money per hour in descending order.
            List<Worker> workers = new List<Worker>();
            workers.Add(new Worker("Dobrin", "Vladislavov", 200, 3));
            workers.Add(new Worker("Asman", "Florinov", 700, 4));
            workers.Add(new Worker("Vladislab", "Yanov", 300, 7));
            workers.Add(new Worker("Yano", "Asmanov", 600, 5));
            workers.Add(new Worker("Toncho", "Tonchov", 500, 10));
            workers.Add(new Worker("Lorin", "Dobrionv", 900, 9));
            workers.Add(new Worker("Florin", "Zeraw", 1200, 7));
            workers.Add(new Worker("Katerina", "Korova", 800, 2));
            workers.Add(new Worker("Georgi", "Salzadjiev", 1000, 11));
            workers.Add(new Worker("Doroteq", "Armaneva", 1200, 12));

            Console.WriteLine();
            Console.WriteLine();

            var orderedWorkers = workers
                .OrderByDescending(x => x.MoneyPerHour());

            foreach (var worker in orderedWorkers)
            {
                Console.WriteLine(string.Format("Worker with {0} with {1:N2} money per hour.", worker, worker.MoneyPerHour()));
            }
            Console.WriteLine();
            Console.WriteLine();
            //Merge the lists and sort them by first name and last name

            var mergedList = new List<Human>(students.Count + workers.Count);
            mergedList.AddRange(students);
            mergedList.AddRange(workers);
            var orderedMergedList = mergedList.OrderBy(x => x.FirstName)
                                              .ThenBy(x => x.LastName);
            foreach (var item in mergedList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
