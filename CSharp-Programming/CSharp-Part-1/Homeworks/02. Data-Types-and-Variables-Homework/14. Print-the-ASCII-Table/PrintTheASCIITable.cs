using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _14.Print_the_ASCII_Table
{
    class PrintTheASCIITable
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 33; i <= 126; i++)
            {
                char c = Convert.ToChar(i);
                Console.Write(c);
            }
            Console.WriteLine();
        }
    }
}
