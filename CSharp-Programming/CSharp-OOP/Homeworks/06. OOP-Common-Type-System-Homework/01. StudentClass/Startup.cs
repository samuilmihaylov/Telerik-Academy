namespace _01.StudentClass
{
    using System;
    using _01.StudentClass.Models;
    using _01.StudentClass.Enumerations;

    class Startup
    {
        static void Main(string[] args)
        {
            var goshoStudent = new Student("Gosho", "Goshev", "Goshkov", 696969, "Unknown", "+359898989898", "gosho@nagoshomaila.bg", 1, UniversitiesType.TU, FacultiesType.Mathematics, SpecialtiesType.Engineering);
            Console.WriteLine(goshoStudent);

            var peshoStudent = new Student("Pesho", "Peshev", "Peshkov", 797979, "Sesame Street", "+359898112233", "pesho@napeshomeila.bg", 2, UniversitiesType.NSA, FacultiesType.Sport, SpecialtiesType.Nursing);
            Console.WriteLine(peshoStudent);

            Console.WriteLine();
            Console.WriteLine(new string('*', 40));
            Console.WriteLine("Testing: Equals(), == and != ");
            Console.WriteLine(goshoStudent.Equals(peshoStudent));
            Console.WriteLine(goshoStudent == peshoStudent);
            Console.WriteLine(goshoStudent != peshoStudent);

            Console.WriteLine();
            Console.WriteLine(new string('*', 40));
            Console.WriteLine("Testing: GetHashCode()");
            Console.WriteLine(goshoStudent.GetHashCode());
            Console.WriteLine(peshoStudent.GetHashCode());

            Console.WriteLine();
            Console.WriteLine(new string('*', 40));
            Console.WriteLine("Testing: Clone()");
            Student newGoshoStudentClone = (Student)goshoStudent.Clone();
            newGoshoStudentClone.FirstName = "Toncho";
            Console.WriteLine(newGoshoStudentClone.FirstName.CompareTo(goshoStudent.FirstName) == 0 ? "names are equal - clone NOT successful!" : "names are not equal - successful clone!");

            Console.WriteLine();
            Console.WriteLine(new string('*', 40));
            Console.WriteLine("Testing: CompareTo()");

            Console.WriteLine(goshoStudent.CompareTo(peshoStudent));
        }
    }
}
