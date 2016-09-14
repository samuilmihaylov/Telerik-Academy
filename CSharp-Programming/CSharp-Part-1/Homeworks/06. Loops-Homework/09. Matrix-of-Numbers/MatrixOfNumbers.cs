using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Matrix_of_Numbers
{
    class MatrixOfNumbers
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int row = 1; row <= N; row++)
            {
                for (int num = row; num < row + N; num++)    // num <= (row + n - 1)
                {
                    Console.Write("{0} ", num);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
