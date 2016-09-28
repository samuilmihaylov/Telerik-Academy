namespace Methods.Utils
{
    using System;
    using System.Globalization;

    using Methods.Contracts;

    public class StudentOperations
    {
        public static IStudent GetOlderStudent(IStudent firstStudent, IStudent secondStudent)
        {
            DateTime firstDate = DateTime.ParseExact(firstStudent.BirthdayDate, "dd.MM.yyyy", CultureInfo.InvariantCulture);
            DateTime secondDate = DateTime.ParseExact(secondStudent.BirthdayDate, "dd.MM.yyyy", CultureInfo.InvariantCulture);

            var olderStudent = firstDate < secondDate ? firstStudent : secondStudent;

            return olderStudent;
        }
    }
}
