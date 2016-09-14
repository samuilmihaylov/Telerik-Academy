using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.GCD
{
    class GCD
    {
        static void Main(string[] args)
        {
            string[] splitNumbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int A = Math.Abs(int.Parse(splitNumbers[0]));
            int B = Math.Abs(int.Parse(splitNumbers[1]));

            int gcd = 0;

            int remainder = A % B;

            while (remainder != 0)
            {
                remainder = A % B;
                A = B;
                B = remainder;
            }

            if (A != 0)
            {
                gcd = A;
                Console.WriteLine(gcd);
            }
            else
            {
                gcd = B;
                Console.WriteLine(gcd);
            }
        }
    }
}
