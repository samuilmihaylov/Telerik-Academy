using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Prime_Check
{
    class PrimeCheck
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            if (number < 0 || number == 0 || number == 1)
            {
                Console.WriteLine("false");
            }
            else
            {
                for (int i = 2; i <= number / 2; i++)
                {
                    if (number % i == 0)
                    {
                        Console.WriteLine("false");
                        return;
                    }
                }
                Console.WriteLine("true");
            }
        }
    }
}
