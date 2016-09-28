namespace StatisticsManipulations
{
    using System;

    /// <summary>
    /// Class that contains methods for manipulating array.
    /// </summary>
    public class Statistics
    {
        /// <summary>
        /// Executes the methods for the manipulation of the array.
        /// </summary>
        /// <param name="array"> The given array wanted to be manipulated. </param>
        public void PrintStatistics(double[] array)
        {
            double maximumValue = this.GetMaxValueFromArray(array);
            Console.Write("Maximum value: ");
            this.PrintValue(maximumValue);

            double minumumValue = this.GetMinValueFromArray(array);
            Console.Write("Minimum value: ");
            this.PrintValue(minumumValue);

            double averageValue = this.GetAverageValueFromArray(array);
            Console.Write("Average value: ");
            this.PrintValue(averageValue);
        }

        /// <summary>
        /// Prints on console given value.
        /// </summary>
        /// <param name="valueToPrint">The given value wanted to be printed.</param>
        public void PrintValue(double valueToPrint)
        {
            Console.WriteLine(valueToPrint);
        }

        /// <summary>
        /// Finds the maximum value of all values in given array.
        /// </summary>
        /// <param name="array"> The given array wanted to be manipulated.</param>
        /// <returns> Returns the maximum value of all values in the given array. </returns>
        public double GetMaxValueFromArray(double[] array)
        {
            double maximumValue = double.MinValue;

            for (int index = 0; index < array.Length; index++)
            {
                if (array[index] > maximumValue)
                {
                    maximumValue = array[index];
                }
            }

            return maximumValue;
        }

        /// <summary>
        /// Finds the minimum value of all values in given array.
        /// </summary>
        /// <param name="array"> The given array wanted to be manipulated. </param>
        /// <returns> Returns the minimum value of all values in the given array. </returns>
        public double GetMinValueFromArray(double[] array)
        {
            double minimumValue = double.MaxValue;

            for (int index = 0; index < array.Length; index++)
            {
                if (array[index] < minimumValue)
                {
                    minimumValue = array[index];
                }
            }

            return minimumValue;
        }

        /// <summary>
        /// Finds the average value of all values in given array.
        /// </summary>
        /// <param name="array"> The given array wanted to be manipulated. </param>
        /// <returns> Returns the average value of all values in the given array. </returns>
        public double GetAverageValueFromArray(double[] array)
        {
            var totalSumOfValuesInArray = 0d;
            var countOfTheValuesInArray = array.Length;

            for (int index = 0; index < countOfTheValuesInArray; index++)
            {
                totalSumOfValuesInArray += array[index];
            }

            var averageValue = totalSumOfValuesInArray / countOfTheValuesInArray;

            return averageValue;
        }
    }
}
