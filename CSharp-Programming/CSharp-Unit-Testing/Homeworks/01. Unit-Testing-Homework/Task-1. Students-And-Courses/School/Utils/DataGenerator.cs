namespace School.Utils
{
    using School.Common;
    using System.Threading;

    public static class DataGenerator
    {
        private static int counter;

        static DataGenerator()
        {
            counter = 1;
        }

        public static int GenerateUniqueId()
        {
            int uniqueId;

            uniqueId = GlobalConstants.StudentIdStartsFrom + Interlocked.Increment(ref counter);

            Validator.CheckIfNumberIsInRange(uniqueId, GlobalConstants.StudentIdStartsFrom, GlobalConstants.StudentsIdEndsWith,
                  string.Format(GlobalConstants.UniqueIdOutOfRange, GlobalConstants.StudentIdStartsFrom, GlobalConstants.StudentsIdEndsWith));

            return uniqueId;
        }
    }
}
