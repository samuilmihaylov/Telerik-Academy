using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.String_length
{
    class StringLength
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            input = input.Replace(@"\", string.Empty);
            sb.Append(input);

            for (int i = input.Length; i <20; i++)
            {
                sb.Append("*");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
