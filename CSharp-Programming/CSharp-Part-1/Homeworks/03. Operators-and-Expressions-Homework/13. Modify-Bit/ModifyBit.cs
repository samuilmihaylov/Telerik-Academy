using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Modify_Bit
{
    class ModifyBit
    {
        static void Main(string[] args)
        {
            ulong N = ulong.Parse(Console.ReadLine()); // вкарвам числото

            byte P = byte.Parse(Console.ReadLine()); // вкарвам позицията

            byte v = byte.Parse(Console.ReadLine()); // вкарвам 0 или 1, според зависи с каква стойност искам да променя бита на позиция P

            if (P >= 0 && P < 64) // правя проверка дали числото се намира между 0 и 64
            {
                if (v == 1) // когато искам да променя бита на позиция P с 1
                {
                    ulong mask = (ulong)1 << P; // правя маска като единицата равна на 0001 изместваме позицията с P  
                    ulong newNumber = N | mask; // използавам битовия оператор ИЛИ
                    Console.WriteLine(newNumber);
                }

                if (v == 0)
                {
                    ulong mask = (ulong)~(1 << P); // правя маската, като обръщам всичките битове с противоположния им и измествам с позиция P
                    ulong newNumber = N & mask; // използвам битовия оператор И
                    Console.WriteLine(newNumber);
                }
            }
        }
    }
}
