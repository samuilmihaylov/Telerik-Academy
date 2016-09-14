using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sum_of_5_Numbers
{
    class SumOf5Numbers
    {
        static void Main(string[] args)
        {
            int result = 0;

            for (int i = 1; i <= 5; i++)

            {             
                int val = int.Parse(Console.ReadLine());
           
                result = result + val;          
            }

            Console.WriteLine(result);
        }
    }
}
