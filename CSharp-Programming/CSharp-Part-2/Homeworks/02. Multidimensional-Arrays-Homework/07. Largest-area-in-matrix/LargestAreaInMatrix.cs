namespace _07.Largest_area_in_matrix
{
    using System;

    class LargestAreaInMatrix
    {
        public static void Main(string[] args)
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

            bool[,] calculated = new bool[matrix.GetLength(0), matrix.GetLength(1)];
            int bestCount = 0;
            int indexRow = 0;
            int indexCol = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (!calculated[row, col])
                    {
                        int count = DepthFirstSearch(matrix, row, col, calculated); // calling the method

                        if (bestCount < count)
                        {
                            bestCount = count;
                            indexRow = row;
                            indexCol = col;
                        }
                    }
                }
            }

            Console.WriteLine(bestCount);
        }

        static int DepthFirstSearch(int[,] array, int row, int col, bool[,] calc)
        {
            int result = 1;
            calc[row, col] = true;

            if ((row - 1 >= 0) && (array[row - 1, col] == array[row, col]) && !calc[row - 1, col])
            {
                result += DepthFirstSearch(array, row - 1, col, calc);
            }
            if ((row + 1 < array.GetLength(0)) && (array[row + 1, col] == array[row, col]) && !calc[row + 1, col])
            {
                result += DepthFirstSearch(array, row + 1, col, calc);
            }
            if ((col - 1 >= 0) && (array[row, col - 1] == array[row, col]) && !calc[row, col - 1])
            {
                result += DepthFirstSearch(array, row, col - 1, calc);
            }
            if ((col + 1 < array.GetLength(1)) && (array[row, col + 1] == array[row, col]) && !calc[row, col + 1])
            {
                result += DepthFirstSearch(array, row, col + 1, calc);
            }

            return result;
        }
    }
}
