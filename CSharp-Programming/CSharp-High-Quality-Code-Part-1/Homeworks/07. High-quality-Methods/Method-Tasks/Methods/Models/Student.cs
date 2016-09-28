namespace Methods
{
    using System;

    using Methods.Contracts;
 
    public class Student : IStudent
    {
        private string firstName;
        private string lastName;
        private string birthdayDate;

        public Student(string firstName, string lastName, string birthdayDate)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthdayDate = birthdayDate;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First name cannot be null or empty!");
                }

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
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Last name cannot be null or empty!");
                }

                this.lastName = value;
            }
        }

        public string BirthdayDate
        {
            get
            {
                return this.birthdayDate;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Birth date cannot be null or empty!");
                }

                this.birthdayDate = value;
            }
        }
    }
}
