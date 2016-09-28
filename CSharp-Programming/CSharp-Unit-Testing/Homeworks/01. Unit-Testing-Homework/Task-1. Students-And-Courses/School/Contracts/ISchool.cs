namespace School.Contracts
{
    using System.Collections.Generic;

    public interface ISchool : INameable
    {
        ICollection<IStudent> Students { get; }

        ICollection<ICourse> Courses { get; }

        void AddStudent(IStudent student);

        void RemoveStudent(IStudent student);

        void AddCourse(ICourse course);

        void RemoveCourse(ICourse course);
    }
}
