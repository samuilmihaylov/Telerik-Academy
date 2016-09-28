namespace School.Contracts
{
    using System.Collections.Generic;

    public interface IStudent : INameable
    {
        int Id { get; }

        void JoinCourse(ICourse course);

        void LeaveCourse(ICourse course);
    }
}
