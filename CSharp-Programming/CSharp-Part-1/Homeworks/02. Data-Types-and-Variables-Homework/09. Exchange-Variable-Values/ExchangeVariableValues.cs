using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Exchange_Variable_Values
{
    class ExchangeVariableValues
    {
        static void Main(string[] args)
        {

            int a = 5;
            int b = 10;
            int c;
            Console.WriteLine("Before");
            Console.WriteLine("a = " + a + " b = " + b);

            c = a; // c = 5
            a = b; // a = 10 
            b = c; // b = 5

            Console.WriteLine("After");
            Console.WriteLine("a = " + a + " b =  " + b);
        }
    }
}
