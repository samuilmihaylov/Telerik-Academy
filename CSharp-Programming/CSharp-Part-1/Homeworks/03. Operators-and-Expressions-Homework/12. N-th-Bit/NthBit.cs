using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.N_th_bit
{
    class NthBit
    {
        static void Main(string[] args)
        {

            long P = long.Parse(Console.ReadLine());

            byte N = byte.Parse(Console.ReadLine());  

            long nRightP = P >> N; // преместваме битовете на числото с желаната позиция, реално търсения бита на позицията отива на начална позиция 

            long bit = nRightP & 1; // правим битовата операция (битовия код на 1 е .... 0000 0001) и ако след тзи операция се получи като резултат 0 => 0 и 1 дават 0, значи последния бит = 0;

            if (bit == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine("1");
            }
        }
    }
}
