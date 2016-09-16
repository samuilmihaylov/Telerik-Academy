namespace SchoolClasses.Interfaces
{
    using SchoolClasses.Enumerations;

    public interface IHuman
    {
        string FirstName { get; }

        string LastName { get; }

        GenderType Gender { get; }
    }
}
