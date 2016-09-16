namespace _17.Spiral_Matrix
{
    using System;

    class SpiralMatrix
    {
        static void Main(string[] args)
        {
            int inputLength = int.Parse(Console.ReadLine());
            int[,] matrix = new int[inputLength, inputLength];
            int row = 0;
            int col = 0;
            string direction = "right";
            int maxRotations = inputLength * inputLength;

            for (int i = 1; i <= maxRotations; i++)
            {
                if (direction == "right" && (col > inputLength - 1 || matrix[row, col] != 0))
                {
                    direction = "down";
                    col--;
                    row++;
                }
                if (direction == "down" && (row > inputLength - 1 || matrix[row, col] != 0))
                {
                    direction = "left";
                    row--;
                    col--;
                }
                if (direction == "left" && (col < 0 || matrix[row, col] != 0))
                {
                    direction = "up";
                    col++;
                    row--;
                }
                if (direction == "up" && row < 0 || matrix[row, col] != 0)
                {
                    direction = "right";
                    row++;
                    col++;
                }

                matrix[row, col] = i;

                if (direction == "right")
                {
                    col++;
                }
                if (direction == "down")
                {
                    row++;
                }
                if (direction == "left")
                {
                    col--;
                }
                if (direction == "up")
                {
                    row--;
                }
            }

            for (int r = 0; r < inputLength; r++)
            {
                for (int c = 0; c < inputLength; c++)
                {
                    Console.Write("{0} ",matrix[r, c]);
                }
                Console.WriteLine();
            }
        }
    }
}

