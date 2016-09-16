namespace StudentsAndWorkers.Models
{
    using System;

    public class Student : Human
    {
        private const int MIN_GRADE = 1;
        private const int MAX_GRADE = 12;

        private int grade;

        public Student(string firstName, string lastName, int grade) : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public int Grade
        {
            get
            {
                return this.grade;
            }
            private set
            {
                if (value < MIN_GRADE || value > MAX_GRADE)
                {
                    throw new ArgumentOutOfRangeException("Invalid grade.");
                }
                this.grade = value;
            }
        }

        public override string ToString()
        {
            return $"{"Name: " + this.FirstName + " " + this.LastName}";
        }
    }
}
