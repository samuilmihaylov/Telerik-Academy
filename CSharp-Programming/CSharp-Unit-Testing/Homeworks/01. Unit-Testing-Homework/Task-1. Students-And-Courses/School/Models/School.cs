namespace School.Models
{
    using Common;
    using Contracts;
    using System;
    using System.Collections.Generic;

    public class School : ISchool
    {
        private string name;
        private ICollection<ICourse> courses;
        private ICollection<IStudent> students;

        public School(string name)
        {
            this.name = Name;
            this.courses = new List<ICourse>();
            this.students = new List<IStudent>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, GlobalConstants.SchoolNameCannotBeNullOrEmpty);

                this.name = value;
            }
        }

        public ICollection<ICourse> Courses
        {
            get
            {
                return this.courses;
            }
        }

        public ICollection<IStudent> Students
        {
            get
            {
                return this.students;
            }
        }

        public void AddCourse(ICourse course)
        {
            Validator.CheckIfObjectIsNull(course, string.Format(GlobalConstants.ObjectCannotBeNull, "Course"));

            if (Validator.IsPartOfCollection(this.courses, course))
            {
                throw new ArgumentException(GlobalConstants.DuplicateCourseErrorMessage);
            }
            else
            {
                this.courses.Add(course);
            }
        }

        public void RemoveCourse(ICourse course)
        {
            Validator.CheckIfObjectIsNull(course, string.Format(GlobalConstants.ObjectCannotBeNull, "Course"));

            if (Validator.IsPartOfCollection(this.courses, course))
            {
                this.courses.Remove(course);
            }
            else
            {
                throw new ArgumentException(GlobalConstants.CourseNotFoundErrorMessage);
            }
        }

        public void AddStudent(IStudent student)
        {
            Validator.CheckIfObjectIsNull(student, string.Format(GlobalConstants.ObjectCannotBeNull, "Course"));

            if (Validator.IsPartOfCollection(this.students, student))
            {
                throw new ArgumentException(GlobalConstants.DuplicateStudentErrorMessage);
            }
            else
            {
                this.students.Add(student);
            }
        }


        public void RemoveStudent(IStudent student)
        {
            Validator.CheckIfObjectIsNull(student, string.Format(GlobalConstants.ObjectCannotBeNull, "Course"));

            if (Validator.IsPartOfCollection(this.students, student))
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
