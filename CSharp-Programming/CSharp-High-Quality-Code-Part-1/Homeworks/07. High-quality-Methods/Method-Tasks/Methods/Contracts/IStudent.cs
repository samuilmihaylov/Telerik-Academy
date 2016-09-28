namespace Methods.Contracts
{
    /// <summary>
    /// Student class.
    /// </summary>
    public interface IStudent
    {
        /// <summary>
        /// Student's first name.
        /// </summary>
        string FirstName { get; }

        /// <summary>
        /// Student's last name.
        /// </summary>
        string LastName { get; }

        /// <summary>
        /// Student's birday date.
        /// </summary>
        string BirthdayDate { get; }
    }
}
