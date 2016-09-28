namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using InheritanceAndPolymorphism.Contracts;
    using InheritanceAndPolymorphism.Courses;

    public class OffsiteCourse : Course, IOffsiteCourse
    {
        private string town;

        public OffsiteCourse(string name, string town) 
            : base(name)
        {
            this.Town = town;
        }

        public OffsiteCourse(string courseName, string teacherName, string town) 
            : base(courseName, teacherName)
        {
            this.Town = town;
        }

        public OffsiteCourse(string courseName, string teacherName, IList<string> students, string town) 
            : base(courseName, teacherName, students)
        {
            this.Town = town;
        }

        public string Town
        {
            get
            {
                return this.town;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Town cannot be null or empty!");
                }

                this.town = value;
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.Append(base.ToString());
            if (this.Town != null)
            {
                result.Append("; Town = ");
                result.Append(this.Town);
            }

            result.Append(" }");

            return result.ToString();
        }
    }
}
