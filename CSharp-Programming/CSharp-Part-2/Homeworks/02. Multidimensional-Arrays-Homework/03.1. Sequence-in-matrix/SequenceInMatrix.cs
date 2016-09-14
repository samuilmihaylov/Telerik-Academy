using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sequence_in_matrix
{
    class SequenceInMatrix
    {
        static void Main(string[] args)
        {
            string[] sizes = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = int.Parse(sizes[0]);
            int columns = int.Parse(sizes[1]);

            int[,] matrix = new int[rows, columns];

            // Entering the elements in matrix
            for (int row = 0; row < rows; row++)
            {
                string[] inputRows = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < columns; col++)
                {
                    matrix[row, col] = int.Parse(inputRows[col]);
                }
            }

            //Finding the length of the longest sequence of equal equal strings in the matrix

            // checking the columns
            int colsSubsequneceLength = 1;
            int colsCountMax = 0;

            for (int col = 0; col < columns; col++)
            {
                for (int row = 0; row < rows - 1; row++)
                {
                    if (matrix[row, col] == matrix[row + 1, col])
                    {
                        colsSubsequneceLength++;
                    }
                }
                if (colsSubsequneceLength > colsCountMax)
                {
                    colsCountMax = colsSubsequneceLength;
                }
                colsSubsequneceLength = 1;
            }

            // checking the rows
            int rowsSubsequenceLength = 1;
            int rowsCountMax = 0;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1])
                    {
                        rowsSubsequenceLength++;
                    }
                }

                if (rowsSubsequenceLength > rowsCountMax)
                {
                    rowsCountMax = rowsSubsequenceLength;
                }

                rowsSubsequenceLength = 1;
            }

            // checking the right diagonal 
            int rightDiagonalLength = 1;
            int rightDiagonalMax = 0;

            for (int row = 0, col = 0; row < matrix.GetLength(0) - 1 && col < matrix.GetLength(1) - 1; row++, col++)
            {
                if (col >= columns - 1 || row >= rows - 1)
                {
                    break;
                }
                else
                {
                    if (matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        rightDiagonalLength++;
                    }
                    if (rightDiagonalLength > rightDiagonalMax)
                    {
                        rightDiagonalMax = rightDiagonalLength;
                    }
                    rightDiagonalLength = 1;
                }
            }

            //checking the left diagonal
            int leftDiagonalLength = 1;
            int leftDiagonalMax = 0;

            for (int row = 0, col = matrix.GetLength(1) - 1; row < matrix.GetLength(0) - 1 && col >= 0; row++, col--)
            {
                if (col <= 0 || row >= rows - 1)
                {
                    break;
                }
                else
                {
                    if (matrix[row, col] == matrix[row + 1, col - 1])
                    {
                        leftDiagonalLength++;
                    }
                    if (leftDiagonalLength > leftDiagonalMax)
                    {
                        leftDiagonalMax = leftDiagonalLength;
                    }
                    leftDiagonalLength = 1;
                }
            }

            int[] maxLengthArray = new int[4];
            maxLengthArray[0] = colsCountMax;
            maxLengthArray[1] = rowsCountMax;
            maxLengthArray[2] = rightDiagonalMax;
            maxLengthArray[3] = leftDiagonalMax;
            int maxLength = maxLengthArray.Max();
            Console.WriteLine(maxLength);
        }
    }
}
