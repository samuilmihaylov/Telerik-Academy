using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Divide_by_7_and_5
{
    class DivideBy7And5
    {
        static void Main(string[] args)
        {
            int i = Convert.ToInt32(Console.ReadLine());

            if (i % 5 == 0 && i % 7 == 0)
            {
                Console.WriteLine("true {0}", i);
            }
            else
            {
                Console.WriteLine("false {0}", i);
            }
        }
    }
}
