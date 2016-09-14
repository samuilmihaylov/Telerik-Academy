
/* 
   16. Print Long Sequence
  
   Description: Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …
   
   Input: There is no input for this task.
  
   Output: Output the first 1000 members of the sequence, each on a separate line.
  
   Constraints: Time limit: 0.1s
                Memory limit: 16MB
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Long_Sequence
{
    class LongSequence
    {
        static void Main(string[] args)
        {

            for (int i = 2; i <= 1001; i++)
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
