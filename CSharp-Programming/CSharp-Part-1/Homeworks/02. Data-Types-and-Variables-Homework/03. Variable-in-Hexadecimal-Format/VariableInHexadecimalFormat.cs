using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Variable_in_Hexadecimal_Format
{
    class VariableInHexadecimalFormat
    {
        static void Main(string[] args)
        {

            int intValue = 254;
            string hexValue = intValue.ToString("X");
            Console.WriteLine("The number 254 in hexadecimal is: " + hexValue);
        }
    }
}
