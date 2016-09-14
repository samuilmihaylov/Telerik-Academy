using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Strings_and_Objects
{
    class StringsAndObjects
    {
        static void Main(string[] args)
        {
            string hello = "Hello ";
            string world = "World";
            object sentence = hello + world;
            Console.WriteLine(sentence);

            string toString = sentence.ToString();
            Console.WriteLine(toString);
        }
    }
}
