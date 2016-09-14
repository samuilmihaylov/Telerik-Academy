using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _05.Hexadecimal_to_binary
{
    class HexadecimalToBinary
    {
        static void Main(string[] args)
        {
            string hexValue = Console.ReadLine();

            StringBuilder binaryString = new StringBuilder();

            foreach (char hexElement in hexValue)
            {
                switch (hexElement)
                {
                    case '0':
                        binaryString.Append("0000");
                        break;
                    case '1':
                        binaryString.Append("0001");
                        break;
                    case '2':
                        binaryString.Append("0010");
                        break;
                    case '3':
                        binaryString.Append("0011");
                        break;
                    case '4':
                        binaryString.Append("0100");
                        break;
                    case '5':
                        binaryString.Append("0101");
                        break;
                    case '6':
                        binaryString.Append("0110");
                        break;
                    case '7':
                        binaryString.Append("0111");
                        break;
                    case '8':
                        binaryString.Append("1000");
                        break;
                    case '9':
                        binaryString.Append("1001");
                        break;
                    case 'A':
                        binaryString.Append("1010");
                        break;
                    case 'B':
                        binaryString.Append("1011");
                        break;
                    case 'C':
                        binaryString.Append("1100");
                        break;
                    case 'D':
                        binaryString.Append("1101");
                        break;
                    case 'E':
                        binaryString.Append("1110");
                        break;
                    case 'F':
                        binaryString.Append("1111");
                        break;
                    default: Console.WriteLine("Invalid hexadecimal number!"); break;
                }
            }
            string s = binaryString.ToString();
            s = s.TrimStart('0');

            foreach (var el in s)
            {
                Console.Write(el);
            }
            Console.WriteLine();
        }
    }
}
