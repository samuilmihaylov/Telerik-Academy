using SchoolClasses.Enumerations;
using SchoolClasses.Models;
using System;
using System.Collections.Generic;

namespace SchoolClasses
{
    class Startup
    {
        static void Main(string[] args)
        {
            // Creating Disciplines
            var math = new Disciplines(DisciplinesType.Mathematics, 3, 3);
            Console.WriteLine(math);
            var physics = new Disciplines(DisciplinesType.Physics, 4, 4);
            Console.WriteLine(physics);

            var listOfDisciplines = new List<Disciplines>();

            // Adding Disciplines to the teacher
            listOfDisciplines.Add(math);
            listOfDisciplines.Add(physics);

            // Creating Teacher
            var dimityr = new Teacher("Dimityr", "Dimitrov", GenderType.Male);
            Console.WriteLine(dimityr);

            // Creating Students
            var student1 = new Student("Glady", "Suther", GenderType.Male);
            Console.WriteLine(student1);
            var student2 = new Student("Melanie", "Buchholtz", GenderType.Female);
            Console.WriteLine(student2);

            var classA = new Classes("classA");

            classA.AddStudent(student1);
            classA.RemoveStudent(student1);
            classA.AddStudent(student1);
            classA.AddStudent(student2);
            classA.AddTeacher(dimityr);
        }
    }
}
