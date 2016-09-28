namespace StatisticsManipulations
{
    /// <summary>
    /// The entry point of the program.
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// The main method of the program that creates Statistic object and execute manipulations with them.
        /// </summary>
        public static void Main(string[] args)
        {
            double[] statisticsArray = new double[] { 11, 16.7, 43, 2.4, 1.5, 0.15 };

            var statistics = new Statistics();

            statistics.PrintStatistics(statisticsArray);
        }
    }
}
