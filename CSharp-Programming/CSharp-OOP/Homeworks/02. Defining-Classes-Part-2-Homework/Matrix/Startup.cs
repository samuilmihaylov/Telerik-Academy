namespace Matrix
{
    using System;

    class Startup
    {
        static void Main(string[] args)
        {
            // First Matrix 
            int row = 5, col = 5;
            var matrixOne = new Matrix<int>(row, col);
            int i = 0, j = 0;
            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    matrixOne[r, c] = i++;
                }
            }

            Console.WriteLine("Matrix One:");
            Console.WriteLine(matrixOne.ToString());

            // Second Matrix
            row = 5; col = 5;
            var matrixTwo = new Matrix<int>(row, col);
            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    matrixTwo[r, c] = j;
                    j += 2;
                }
            }

            Console.WriteLine("Matrix Two:");
            Console.WriteLine(matrixTwo.ToString());

            Console.WriteLine("Matrix One + Matrix Two:");
            Console.WriteLine(matrixOne + matrixTwo);
            Console.WriteLine("Matrix One - Matrix Two:");
            Console.WriteLine(matrixOne - matrixTwo);
            Console.WriteLine("Matrix One * Matrix Two:");
            Console.WriteLine(matrixOne * matrixTwo);

            // If there is zero in the matrix the result is False
            if (matrixTwo)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
