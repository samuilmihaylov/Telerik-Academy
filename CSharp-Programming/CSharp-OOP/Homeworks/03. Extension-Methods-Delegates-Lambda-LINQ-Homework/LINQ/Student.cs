namespace ExtensionMethodsDelegatesLambdaLINQ.LINQ
{
    using System;
    using System.Collections.Generic;

    public class Student
    {
        // Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
        // Create a List<Student> with sample students.Select only the students that are from group number 2.
        // Use LINQ query.Order the students by FirstName.

        // Fields

        private string firstName;
        private string lastName;
        private short age;
        private int facultyNumber;
        private string telephoneNumber;
        private string email;
        private List<int> marks;
        private int groupNumber;

        // Constructor

        public Student(string firstName, string lastName, short age, int facultyNumber,
            string telephoneNumber, string email, List<int> marks, int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FacultyNumber = facultyNumber;
            this.TelephoneNumber = telephoneNumber;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }

        //Properties

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
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
            set
            {
                this.lastName = value;
            }
        }

        public short Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }

        public int FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }
            set
            {
                this.facultyNumber = value;
            }
        }

        public string TelephoneNumber
        {
            get
            {
                return this.telephoneNumber;
            }
            set
            {
                this.telephoneNumber = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }

        public List<int> Marks
        {
            get
            {
                return this.marks;
            }
            set
            {
                this.marks = value;
            }
        }

        public int GroupNumber
        {
            get
            {
                return this.groupNumber;
            }
            set
            {
                this.groupNumber = value;
            }
        }

        public string FullName
        {
            get
            {
                return this.FirstName + " " + this.LastName;
            }
        }
    }
}
