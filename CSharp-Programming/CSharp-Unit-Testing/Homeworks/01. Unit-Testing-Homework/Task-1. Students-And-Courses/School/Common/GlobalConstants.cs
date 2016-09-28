namespace School.Common
{
    public static class GlobalConstants
    {
        public const int MaxStudentsInCourse = 29;

        public const int StudentIdStartsFrom = 10000;
        public const int StudentsIdEndsWith = 99999;

        public const string UniqueIdOutOfRange = "Student Id must be in range {0} - {1}";
        public const string ObjectCannotBeNull = "{0} cannot be null";
        public const string StudentNameCannotBeNullOrEmpty = "Student name cannot be null or empty";

        public const string SchoolNameCannotBeNullOrEmpty = "School name cannot be null or empty";

        public const string CourseNameCannotBeNullOrEmpty = "Course name cannot be null or empty";

        public const string StudentNotFoundErrorMessage = "Must pass an existing Student object to remove";
        public const string DuplicateStudentErrorMessage = "Must pass a unique student to add to course";
        public const string CourseOverCapacityErrorMessage = "Can only add new students up to the {0} course capacity";

        public const string CourseNotFoundErrorMessage = "Must pass an existing Course object to remove";
        public const string DuplicateCourseErrorMessage = "Must pass a unique course to add to school";
    }
}
