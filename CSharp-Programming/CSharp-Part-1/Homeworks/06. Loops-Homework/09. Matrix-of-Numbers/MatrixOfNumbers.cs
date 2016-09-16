namespace _09.Matrix_of_Numbers
{
    using System;

    class MatrixOfNumbers
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            for (int row = 1; row <= inputNumber; row++)
            {
                for (int num = row; num < row + inputNumber; num++)    // num <= (row + n - 1)
                {
                    Console.Write("{0} ", num);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
