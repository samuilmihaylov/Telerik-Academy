namespace SchoolClasses.Models
{
    using System.Collections.Generic;

    public class Classes
    {
        private List<Teacher> teachers;
        private List<Student> students;
        private string textID;

        public Classes(string textID)
        {
            this.TextID = textID;

            this.teachers = new List<Teacher>();

            this.students = new List<Student>();
        }

        public string TextID
        {
            get
            {
                return this.textID;
            }
            private set
            {
                this.textID = value;
            }
        }

        public List<Teacher> Teachers
        {
            get
            {
                return new List<Teacher>(this.teachers);
            }
            private set
            {
                this.teachers = value;
            }
        }
        
        public List<Student> Students
        {
            get
            {
                return new List<Student>(this.students);
            }
            private set
            {
                this.students = value;
            }
        }

        public void AddStudent(Student student)
        {
            this.students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            this.students.Remove(student);
        }

        public void AddTeacher(Teacher teacher)
        {
            this.teachers.Add(teacher);
        }

        public void RemoveTeacher(Teacher teacher)
        {
            this.teachers.Remove(teacher);
        }

    }
}
