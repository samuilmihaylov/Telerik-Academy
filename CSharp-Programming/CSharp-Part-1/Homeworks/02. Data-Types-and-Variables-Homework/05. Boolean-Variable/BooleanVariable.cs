using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Boolean_Variable
{
    class BooleanVariable
    {
        static void Main(string[] args)
        {
            bool isFemale = false;
            Console.WriteLine("Are you female: yes/no");
            string answer = Console.ReadLine();
            if (answer.Equals("no"))
            {
                Console.WriteLine("You are male.");
            }
            else
            {
                Console.WriteLine("Then you are female.");
            }
        }
    }
}
