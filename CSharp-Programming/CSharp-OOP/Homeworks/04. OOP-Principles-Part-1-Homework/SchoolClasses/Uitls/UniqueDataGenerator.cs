namespace SchoolClasses.Uitls
{
    using System.Threading;

    public static class UniqueDataGenerator
    {
        private static int counter;

        static UniqueDataGenerator()
        {
            counter = 0;
        }

        public static int GenerateUniqueId()
        {
            return Interlocked.Increment(ref counter);
        }
    }
}
