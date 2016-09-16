namespace SchoolClasses.Models
{
    using System;
    using SchoolClasses.Interfaces;
    using SchoolClasses.Enumerations;
    using Uitls;
    public class Student : IHuman
    {
        private string firstName;
        private string lastName;
        private GenderType gender;

        public Student(string firstName, string lastName, GenderType gender)
        {
            this.Id = UniqueDataGenerator.GenerateUniqueId();
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Gender = gender;
        }

        public int Id { get; }

        public GenderType Gender
        {
            get
            {
                return this.gender;
            }

            private set
            {
                this.gender = value;
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            private set
            {
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            private set
            {
                this.lastName = value;
            }
        }

        public override string ToString()
        {
            return $"{ "ID: " + this.Id + ", " + "Name: " + this.FirstName + " " + this.LastName + ", " + "Gender: "+ this.Gender}";
        }

    }
}
