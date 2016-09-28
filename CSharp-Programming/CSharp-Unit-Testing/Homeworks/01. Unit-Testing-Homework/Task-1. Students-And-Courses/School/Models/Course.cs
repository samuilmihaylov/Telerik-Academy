using System;
using System.Collections.Generic;
using School.Contracts;
using School.Common;

namespace School.Models
{
    public class Course : ICourse
    {
        private string name;
        private int maximumCapacityInStudents;

        private ICollection<IStudent> students;

        public Course(string name, int maximumCapacityInStudents)
        {
            students = new List<IStudent>();
            this.maximumCapacityInStudents = maximumCapacityInStudents;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, GlobalConstants.CourseNameCannotBeNullOrEmpty);

                this.name = value;
            }
        }

        public ICollection<IStudent> Students
        {
            get
            {
                return this.students;
            }
            private set
            {
                Validator.CheckIfObjectIsNull(value, string.Format(GlobalConstants.ObjectCannotBeNull, "Student collection"));

                this.students = value;
            }
        }

        public void AddStudentToCourse(IStudent student)
        {
            Validator.CheckIfObjectIsNull(student, string.Format(GlobalConstants.ObjectCannotBeNull, "Student"));

            if (this.students.Count == this.maximumCapacityInStudents)
            {
                throw new ArgumentException(string.Format(GlobalConstants.CourseOverCapacityErrorMessage, this.maximumCapacityInStudents));
            }

            if (Validator.IsPartOfCollection(students, student))
            {
                throw new ArgumentException(GlobalConstants.DuplicateStudentErrorMessage);
            }

            this.students.Add(student);
        }

        public void RemoveStudentFromCourse(IStudent student)
        {
            Validator.CheckIfObjectIsNull(student, string.Format(GlobalConstants.ObjectCannotBeNull, "Student"));

            if (Validator.IsPartOfCollection(students, student))
            {
                this.students.Remove(student);
            }
            else
            {
                throw new ArgumentException(GlobalConstants.StudentNotFoundErrorMessage);
            }
        }
    }
}
