
namespace _10.Unicode_characters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class UnicodeCharacters
    {
        static void Main(string[] args)
        {
            //string input = console.readline();

            //int decvalue = 0;
            //string hexvalue = string.empty;

            //stringbuilder sb = new stringbuilder();

            //foreach (var c in input)
            //{
            //    decvalue = ((int)c);
            //    hexvalue = @"\u" + decvalue.tostring("x4");
            //    sb.append(hexvalue);
            //}
            //console.writeline(sb.tostring());

            string input = Console.ReadLine();
            StringBuilder answer = new StringBuilder();

            foreach (char character in input)
            {
                answer.AppendFormat("\\u{0:X4}", (int)character);
            }
            Console.WriteLine(answer.ToString());
        }
    }
}
