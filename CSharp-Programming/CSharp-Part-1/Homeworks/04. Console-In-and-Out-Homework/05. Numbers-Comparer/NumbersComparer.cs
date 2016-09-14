using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Numbers_Comparer
{
    class NumbersComparer
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double greaterNumber = Math.Max(a, b);
            Console.WriteLine(greaterNumber);
            
        }
    }
}
