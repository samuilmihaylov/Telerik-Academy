using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Maximal_sum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            string[] sizes = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = int.Parse(sizes[0]);
            int columns = int.Parse(sizes[1]);

            int[,] matrix = new int[rows, columns];

            for (int row = 0; row < rows; row++)
            {
                string[] inputRows = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < columns; col++)
                {
                    matrix[row, col] = int.Parse(inputRows[col]);
                }
            }

            // Find the maximal sum platform of size 3 x 3
            int bestSum = int.MinValue;
            int bestRow = 0;
            int bestCol = 0;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                              matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                              matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        bestRow = row;
                        bestCol = col;
                    }
                }
            }
            Console.WriteLine(bestSum);
        }
    }
}
