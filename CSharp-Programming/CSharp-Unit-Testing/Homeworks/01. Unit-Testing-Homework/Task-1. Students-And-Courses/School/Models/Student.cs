namespace School.Models
{
    using Contracts;
    using Common;
    using Utils;

    public class Student : IStudent
    {
        private string name;
        private int id;

        public Student(string name)
        {
            this.Name = name;
            this.Id = DataGenerator.GenerateUniqueId();
        }

        public int Id
        {
            get
            {
                return this.id;
            }

            private set
            {
                this.id = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, GlobalConstants.StudentNameCannotBeNullOrEmpty);

                this.name = value;
            }
        }

        public void JoinCourse(ICourse course)
        {
            Validator.CheckIfObjectIsNull(course, string.Format(GlobalConstants.ObjectCannotBeNull, "Course"));

            course.AddStudentToCourse(this);
        }

        public void LeaveCourse(ICourse course)
        {
            Validator.CheckIfObjectIsNull(course, string.Format(GlobalConstants.ObjectCannotBeNull, "Course"));

            course.RemoveStudentFromCourse(this);
        }
    }
}
