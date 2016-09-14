using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Unicode_Character
{
    class UnicodeCharacter
    {
        static void Main(string[] args)
        {
            int var = 42;
            Console.WriteLine("The variable 42 in hexadecimal is {0:X}", var);
            char symbol = '\u002A';
            Console.WriteLine("The symbol is {0}", symbol);
        }
    }
}
