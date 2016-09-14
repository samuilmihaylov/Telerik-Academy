using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sum_of_3_numbers
{
    class SumOf3Numbers
    {
        static void Main(string[] args)
        {
            short a = short.Parse(Console.ReadLine());
            short b = short.Parse(Console.ReadLine());
            short c = short.Parse(Console.ReadLine());

            Console.WriteLine(a+b+c);
        }
    }
}
