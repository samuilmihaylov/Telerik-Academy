using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Decimal_to_Binary
{
    class DecimalToBinary
    {
        static void Main(string[] args)
        {
            long decNum = long.Parse(Console.ReadLine());

            string s = "";

            if (decNum == 0)
            {
                s += '0';
            }

            while (decNum > 0)
            {
                if (decNum % 2 == 1)
                {
                    s += '1';
                }
                else if (decNum % 2 == 0)
                {
                    s += '0';
                }
                decNum = decNum / 2;
            }
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(charArray);
        }
    }
}
