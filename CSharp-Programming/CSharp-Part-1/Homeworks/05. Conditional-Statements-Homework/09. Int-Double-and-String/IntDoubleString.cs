using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Int__Double_and_String
{
    class IntDoubleString
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            switch (type)
            {
                case "integer":
                    int intValue = int.Parse(Console.ReadLine());
                    intValue += 1;
                    Console.WriteLine(intValue);
                    break;
                case "real":
                    double realValue = double.Parse(Console.ReadLine());
                    realValue += 1;
                    Console.WriteLine(realValue.ToString("F2"));
                    break;
                case "text":
                    string text = Console.ReadLine();
                    Console.WriteLine(text + "*");
                    break;
            }
        }
    }
}
