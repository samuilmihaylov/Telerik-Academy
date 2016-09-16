namespace SchoolClasses.Models
{
    using System;
    using SchoolClasses.Interfaces;
    using SchoolClasses.Enumerations;
    using Uitls;

    public class Student : Human, IHuman
    {
        public Student(string firstName, string lastName, GenderType gender) : base(firstName, lastName, gender)
        {
            this.Id = UniqueDataGenerator.GenerateUniqueId();
        }

        public int Id { get; }

        public override string ToString()
        {
            return $"{ "ID: " + this.Id + ", " + "Name: " + this.FirstName + " " + this.LastName + ", " + "Gender: "+ this.Gender}";
        }

    }
}
