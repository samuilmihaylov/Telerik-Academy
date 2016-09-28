namespace School.Contracts
{
    using System.Collections.Generic;

    public interface ICourse : INameable
    {
        ICollection<IStudent> Students { get; }

        void AddStudentToCourse(IStudent student);

        void RemoveStudentFromCourse(IStudent student);
    }
}
