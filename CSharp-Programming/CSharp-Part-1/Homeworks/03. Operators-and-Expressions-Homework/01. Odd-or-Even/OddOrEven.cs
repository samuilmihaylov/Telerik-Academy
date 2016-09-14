using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Odd_or_Even
{
    class OddOrEven
    {
        static void Main(string[] args)
        {
            int i = Convert.ToInt32(Console.ReadLine());

            if ((i % 2) == 0)
            {
                Console.WriteLine("even {0}", i);
            }
            else
            {
                Console.WriteLine("odd {0}", i);
            }
        }
    }
}
