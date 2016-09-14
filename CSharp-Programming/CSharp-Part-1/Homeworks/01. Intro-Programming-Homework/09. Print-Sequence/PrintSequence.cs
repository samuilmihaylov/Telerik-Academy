
/* 
   9. Print Sequence

   Description: Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

   Input: There is no input for this task.
   
   Output: Print on the console the first 10 members of the sequence from the description. Print each member on a separate line.
   
   Constraints: Time limit: 0.1s 
                Memory limit: 16MB
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Print_Sequence
{
    class PrintSequence
    {
        static void Main(string[] args)
        {

            for (int i = 2; i <= 11; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine("-" + i);
                }
                else
                    Console.WriteLine(i);

            }
        }
    }
}
