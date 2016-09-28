namespace Engine
{
    using School.Models;
    using System;

    class StartUp
    {
        static void Main(string[] args)
        {
            // Testing

            var testStudent1 = new Student("gosho");
            var testStudent2 = new Student("pesho");

            Console.WriteLine(testStudent1.Id);
            Console.WriteLine(testStudent2.Id);
        }
    }
}
