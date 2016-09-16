namespace SchoolClasses.Models
{
    using SchoolClasses.Enumerations;
    using SchoolClasses.Interfaces;
    using System.Collections.Generic;

    public class Teacher : Human, IHuman
    {
        private List<Disciplines> disciplines;

        public Teacher(string firstName, string lastName, GenderType gender) : base(firstName, lastName, gender)
        {
            this.disciplines = new List<Disciplines>();
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

        public void AddDiscipline(Disciplines discipline)
        {
            this.Disciplines.Add(discipline);
        }

        public void RemoveDiscipline(Disciplines discipline)
        {
            this.Disciplines.Remove(discipline);
        }

        public override string ToString()
        {
            return $"{ this.FirstName + " " + this.LastName + " " + this.Gender + " " + string.Join(", ", this.Disciplines)}";
        }
    }
}
