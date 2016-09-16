namespace SchoolClasses.Models
{
    using SchoolClasses.Enumerations;
    using SchoolClasses.Interfaces;
    using System.Collections.Generic;

    public class Teacher : IHuman
    {
        private string firstName;
        private string lastName;
        private GenderType gender;
        private List<Disciplines> disciplines;

        public Teacher(string firstName, string lastName, GenderType gender, List<Disciplines> disciplines)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Gender = gender;
            this.disciplines = new List<Disciplines>();
        }

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

        public List<Disciplines> Disciplines
        {
            get
            {
                return new List<Disciplines>(this.disciplines);
            }
            private set
            {
                this.disciplines = value;
            }
        }

        public override string ToString()
        {
            return $"{ this.FirstName + " " + this.LastName + " " + this.Gender + " " + string.Join(", ", this.Disciplines)}";
        }
    }
}
