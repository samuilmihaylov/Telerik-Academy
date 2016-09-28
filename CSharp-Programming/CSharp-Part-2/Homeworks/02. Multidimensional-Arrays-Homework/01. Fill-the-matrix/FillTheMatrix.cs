namespace _01.Fill_the_matrix
{
    using System;

    class FillTheMatrix
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            int[,] arr = new int[matrixSize, matrixSize];
            char typeOfMatrix = (char)Console.Read();
            int val = 1;
            int currentRow = 0;
            int currentColumn = 0;
            string direction = "down";

            // Case "A"
            if (Char.ToUpper(typeOfMatrix).Equals('A'))
            {
                for (int col = 0; col < matrixSize; col++)
                {
                    for (int row = 0; row < matrixSize; row++)
                    {
                        arr[row, col] = val;
                        val++;
                    }
                }
            }

            // Case "B"
            else if (Char.ToUpper(typeOfMatrix).Equals('B'))
            {
                for (int col = 0; col < matrixSize; col++)
                {
                    if (col % 2 == 0)
                    {
                        for (int row = 0; row < matrixSize; row++)
                        {
                            arr[row, col] = val;
                            val++;
                        }
                    }
                    else
                    {
                        for (int row = matrixSize - 1; row >= 0; row--)
                        {
                            arr[row, col] = val;
                            val++;
                        }
                    }
                }
            }

            // Case "C"
            else if (Char.ToUpper(typeOfMatrix).Equals('C'))
            {
                for (int row = matrixSize - 1; row >= 0; row--)
                {
                    for (int col = 0; col < matrixSize - row; col++)
                    {
                        arr[row + col, col] = val;
                        val++;
                    }
                }
                for (int col = 1; col < matrixSize; col++)
                {
                    for (int row = 0; row < matrixSize - col; row++)
                    {
                        arr[row, col + row] = val++;
                    }
                }
            }

            // Case "D"
            else if (Char.ToUpper(typeOfMatrix).Equals('D'))
            {
                for (int i = 1; i <= matrixSize * matrixSize; i++)
                {
                    if (direction == "down" && (currentRow >= matrixSize || arr[currentRow, currentColumn] != 0))
                    {
                        currentRow--;
                        currentColumn++;
                        direction = "right";
                    }
                    else if (direction == "right" && (currentColumn >= matrixSize || arr[currentRow, currentColumn] != 0))
                    {
                        currentColumn--;
                        currentRow--;
                        direction = "up";
                    }
                    else if (direction == "up" && (currentRow < 0 || arr[currentRow, currentColumn] != 0))
                    {
                        currentRow++;
                        currentColumn--;
                        direction = "left";
                    }
                    else if (direction == "left" && (currentColumn < 0 || arr[currentRow, currentColumn] != 0))
                    {
                        currentColumn++;
                        currentRow++;
                        direction = "down";
                    }

                    arr[currentRow, currentColumn] = i;

                    if (direction == "down")
                    {
                        currentRow++;
                    }
                    else if (direction == "right")
                    {
                        currentColumn++;
                    }
                    else if (direction == "up")
                    {
                        currentRow--;
                    }
                    else if (direction == "left")
                    {
                        currentColumn--;
                    }
                }
            }

            // Printing the matrix
            for (int row = 0; row < arr.GetLength(0); row++)
            {
                for (int col = 0; col < arr.GetLength(1); col++)
                {
                    if (col != arr.GetLength(1) - 1)
                    {
                        Console.Write("{0} ", arr[row, col]);
                    }
                    else
                    {
                        Console.Write("{0}", arr[row, col]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
